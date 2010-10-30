namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NamespaceSupport : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NamespaceSupport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset35213;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "reset", "()V", ref global::org.xml.sax.helpers.NamespaceSupport._reset35213);
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix35214;
		public virtual global::java.lang.String getPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.helpers.NamespaceSupport._getPrefix35214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI35215;
		public virtual global::java.lang.String getURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.helpers.NamespaceSupport._getURI35215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pushContext35216;
		public virtual void pushContext()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "pushContext", "()V", ref global::org.xml.sax.helpers.NamespaceSupport._pushContext35216);
		}
		internal static global::MonoJavaBridge.MethodId _declarePrefix35217;
		public virtual bool declarePrefix(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "declarePrefix", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.xml.sax.helpers.NamespaceSupport._declarePrefix35217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _popContext35218;
		public virtual void popContext()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "popContext", "()V", ref global::org.xml.sax.helpers.NamespaceSupport._popContext35218);
		}
		internal static global::MonoJavaBridge.MethodId _processName35219;
		public virtual global::java.lang.String[] processName(java.lang.String arg0, java.lang.String[] arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "processName", "(Ljava/lang/String;[Ljava/lang/String;Z)[Ljava/lang/String;", ref global::org.xml.sax.helpers.NamespaceSupport._processName35219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String[];
		}
		public new global::java.util.Enumeration Prefixes
		{
			get
			{
				return getPrefixes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrefixes35220;
		public virtual global::java.util.Enumeration getPrefixes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefixes", "()Ljava/util/Enumeration;", ref global::org.xml.sax.helpers.NamespaceSupport._getPrefixes35220) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefixes35221;
		public virtual global::java.util.Enumeration getPrefixes(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefixes", "(Ljava/lang/String;)Ljava/util/Enumeration;", ref global::org.xml.sax.helpers.NamespaceSupport._getPrefixes35221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Enumeration;
		}
		public new global::java.util.Enumeration DeclaredPrefixes
		{
			get
			{
				return getDeclaredPrefixes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredPrefixes35222;
		public virtual global::java.util.Enumeration getDeclaredPrefixes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getDeclaredPrefixes", "()Ljava/util/Enumeration;", ref global::org.xml.sax.helpers.NamespaceSupport._getDeclaredPrefixes35222) as java.util.Enumeration;
		}
		public new bool NamespaceDeclUris
		{
			set
			{
				setNamespaceDeclUris(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceDeclUris35223;
		public virtual void setNamespaceDeclUris(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "setNamespaceDeclUris", "(Z)V", ref global::org.xml.sax.helpers.NamespaceSupport._setNamespaceDeclUris35223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceDeclUris35224;
		public virtual bool isNamespaceDeclUris()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.helpers.NamespaceSupport.staticClass, "isNamespaceDeclUris", "()Z", ref global::org.xml.sax.helpers.NamespaceSupport._isNamespaceDeclUris35224);
		}
		internal static global::MonoJavaBridge.MethodId _NamespaceSupport35225;
		public NamespaceSupport() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.NamespaceSupport._NamespaceSupport35225.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.NamespaceSupport._NamespaceSupport35225 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._NamespaceSupport35225);
			Init(@__env, handle);
		}
		public static global::java.lang.String XMLNS
		{
			get
			{
				return "http://www.w3.org/XML/1998/namespace";
			}
		}
		public static global::java.lang.String NSDECL
		{
			get
			{
				return "http://www.w3.org/xmlns/2000/";
			}
		}
		static NamespaceSupport()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.NamespaceSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/NamespaceSupport"));
		}
		internal static void InitJNI()
		{
		}
	}
}
