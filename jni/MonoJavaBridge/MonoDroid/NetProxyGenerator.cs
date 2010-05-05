
using System;
using System.IO;

namespace MonoDroid
{
	public class NetProxyGenerator : CodeGenerator
	{
		public NetProxyGenerator (DirectoryInfo workingDirectory)
			: base(workingDirectory)
		{
		}
		
		static readonly string[] myKeywords = new string[] {
			"in",
			"out",
			"checked",
			"params",
			"lock",
			"ref",
			"internal",
			"out",
			"object",
			"string",
			"bool"
		};
		static readonly int myTypeCount = 3;
		static string[] myReplaceKeyword = new string[myKeywords.Length];
		static string[] myStartKeywords = new string[myKeywords.Length];
		static string[] myStartReplaceKeywords = new string[myKeywords.Length];
		static string[] myEndKeywords = new string[myKeywords.Length];
		static string[] myEndReplaceKeywords = new string[myKeywords.Length];
		static string[] myContainKeywords = new string[myKeywords.Length];
		static string[] myContainReplaceKeywords = new string[myKeywords.Length];

		static string EscapeName(string name)
		{
			return EscapeName(name, true);
		}

		static string EscapeName(string name, bool doExactMatchOnTypes)
		{
			for (int i = 0; i < myKeywords.Length; i++)
			{
				var keyword = myStartKeywords[i];
				if (!name.StartsWith(keyword))
					continue;
				name = myStartReplaceKeywords[i] + name.Substring(keyword.Length);
				break;
			}
			for (int i = 0; i < myKeywords.Length; i++)
			{
				var keyword = myEndKeywords[i];
				if (!name.EndsWith(keyword))
					continue;
				name = name.Substring(0, name.Length - keyword.Length) + myEndReplaceKeywords[i];
				break;
			}
			for (int i = 0; i < myKeywords.Length; i++)
			{
				var keyword = myContainKeywords[i];
				if (!name.Contains(keyword))
					continue;
				name = name.Replace(keyword, myContainReplaceKeywords[i]);
			}
			for (int i = 0; i < (doExactMatchOnTypes ? myKeywords.Length : myKeywords.Length - myTypeCount); i++)
			{
				if (name != myKeywords[i])
					continue;
				name = myReplaceKeyword[i];
			}
			return name;
		}
		
		protected override void Prepare (ObjectModel model)
		{
			foreach (var type in model.Types)
			{
				type.Name = EscapeName(type.Name);
				foreach (var method in type.Methods)
				{
					method.Name = EscapeName(method.Name);
					for (int i = 0; i < method.Parameters.Count; i++)
					{
						method.Parameters[i] = ConvertType(EscapeName(method.Parameters[i], false));
					}
					if (method.Return != null)
						method.Return = ConvertType(EscapeName(method.Return, false));
				}
				if (type.Parent != null)
					type.Parent = EscapeName(type.Parent);
				for (int i = 0; i < type.Interfaces.Count; i++)
				{
					type.Interfaces[i] = EscapeName(type.Interfaces[i]);
				}
				for (int i = 0; i < type.Fields.Count; i++)
				{
					type.Fields[i].Name = EscapeName(type.Fields[i].Name);
					type.Fields[i].Type = ConvertType(EscapeName(type.Fields[i].Type, false));
				}
			}
		}

		
		static NetProxyGenerator()
		{
			for (int i = 0; i < myKeywords.Length; i++)
			{
				string keyword = myKeywords[i];
				myReplaceKeyword[i] = '@' + keyword;
				myStartKeywords[i] = keyword + '.';
				myStartReplaceKeywords[i] = '@' + keyword + '.';
				myEndKeywords[i] = '.' + keyword;
				myEndReplaceKeywords[i] = ".@" + keyword;
				myContainKeywords[i] = '.' + keyword + '.';
				myContainReplaceKeywords[i] = ".@" + keyword + '.';
			}
		}

		protected override void BeginNamespace (string name)
		{
			WriteLine("namespace {0}", name);
			WriteLine("{");
		}
		
		protected override string GetFilePath (Type type)
		{
			return Path.Combine(type.Namespace.Replace('.', Path.DirectorySeparatorChar), type.SimpleName + ".cs");
		}		
		
		protected override void BeginType (Type type)
		{
			Write(type.Scope);
			if (type.IsNew)
				Write("new");
			if (type.Abstract && !type.IsInterface)
				Write("abstract");
			if (type.IsSealed)
				Write("sealed");
			if (type.IsInterface)
				Write("interface {0}", type.SimpleName);
			else
				Write("class {0}", type.SimpleName);
			
			if (type.Parent != null || type.Interfaces.Count > 0)
				Write(":");
			
			if (type.Parent != null)
				Write(type.Parent, false);
			
			if (!type.IsInterface && type.Interfaces.Count > 0)
			{
				Write(",");
			}
			WriteDelimited(type.InterfaceTypes, (v, i) => type.Qualifier.StartsWith(v.Qualifier) ? v.SimpleName : v.Name, ",");
			WriteLine();
			WriteLine("{");
		}
		
		private string ConvertType(String type)
		{
			if (type == "java.lang.String")
				return "string";
			if (type == "java.lang.CharSequence")
				return "string";
			return type;
		}

		protected override void EmitField (Field field)
		{
			if (field.Scope == "protected")
				return;
			
			bool hasValue = !string.IsNullOrEmpty(field.Value);
			
			Write(field.Scope);
			if (field.Static)
				Write("static");
			Write(field.Type);
			Write(field.Name, false);
			WriteLine();
			WriteLine("{");
			myIndent++;
			WriteLine("get");
			WriteLine("{");
			if (hasValue)
			{
				myIndent++;
				string val = field.Value;
				val = val.Replace("\\" , "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n");
				
				if (ConvertType(field.Type) == "string")
				{
					Write("return \"{0}\"", false, val);
				}
				else if (ConvertType(field.Type) == "char")
				{
					val = val.Replace("'", "\\'");
					Write("return '{0}'", false, val);
				}
				else
				{
					Write("return {0}", false, field.Value);
				}
				
				if (field.Type == "long")
					Write("L", false);
				else if (field.Type == "float")
					Write("f", false);
				WriteLine(";");
				myIndent--;
			}
			else
			{
				myIndent++;
				WriteLine("return default({0});", field.Type);
				myIndent--;
			}
			WriteLine("}");
			if (!field.IsReadOnly)
			{
				WriteLine("set");
				WriteLine("{");
				WriteLine("}");
			}
			myIndent--;
			WriteLine("}");
		}
		
		protected override void EmitMethod (Method method)
		{
			if (method.IsSynthetic)
				return;
			
			//if (method.PropertyType != null && method.Name.StartsWith("set"))
			//	return;
			
			if (!method.Type.IsInterface)
			{
				WriteLine("[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]");
				Write(method.Scope);
				if (method.Abstract)
					Write("abstract");
				else
				{
					if (method.Static)
					{
						Write("static");
					}
					else if (!method.IsConstructor)
					{
						if (method.IsOverride)
						{
							if (method.IsSealed)
								Write("sealed");
							Write("override");
						}
						else if (!method.Type.IsSealed && method.Scope != string.Empty)
							Write("virtual");
					}
					Write("extern");
				}
			}
			if (method.IsNew)
				Write("new");
			if (method.Return != null)
				Write(method.Return);
			//if (method.PropertyType == null)
			if (true)
			{
				Write(method.Name, false);
				Write("(", false);
				WriteDelimited(method.Parameters, (v, i) => string.Format("{0} arg{1}", v, i), ",");
				WriteLine(");");
			}
			else
			{
				WriteLine(method.Name.Substring(3), false);
				WriteLine("{");
				if (method.PropertyType == PropertyType.ReadOnly)
					WriteLine("get;");
				else
					WriteLine("get; set;");
				WriteLine("}");
			}
		}
	}
}