namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewDebug : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewDebug(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.CapturedViewProperty_))]
		public partial interface CapturedViewProperty : java.lang.annotation.Annotation
		{
			bool retrieveReturn();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.CapturedViewProperty))]
		internal sealed partial class CapturedViewProperty_ : java.lang.Object, CapturedViewProperty
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal CapturedViewProperty_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _retrieveReturn14977;
			bool android.view.ViewDebug.CapturedViewProperty.retrieveReturn()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "retrieveReturn", "()Z", ref global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn14977);
			}
			internal static global::MonoJavaBridge.MethodId _equals14978;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.ViewDebug.CapturedViewProperty_._equals14978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString14979;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.ViewDebug.CapturedViewProperty_._toString14979) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode14980;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "hashCode", "()I", ref global::android.view.ViewDebug.CapturedViewProperty_._hashCode14980);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType14981;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.view.ViewDebug.CapturedViewProperty_._annotationType14981) as java.lang.Class;
			}
			static CapturedViewProperty_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.CapturedViewProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$CapturedViewProperty"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.ExportedProperty_))]
		public partial interface ExportedProperty : java.lang.annotation.Annotation
		{
			global::java.lang.String prefix();
			bool resolveId();
			global::android.view.ViewDebug.IntToString[] mapping();
			global::android.view.ViewDebug.IntToString[] indexMapping();
			global::android.view.ViewDebug.FlagToString[] flagMapping();
			bool deepExport();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.ExportedProperty))]
		internal sealed partial class ExportedProperty_ : java.lang.Object, ExportedProperty
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ExportedProperty_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _prefix14982;
			global::java.lang.String android.view.ViewDebug.ExportedProperty.prefix()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "prefix", "()Ljava/lang/String;", ref global::android.view.ViewDebug.ExportedProperty_._prefix14982) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _resolveId14983;
			bool android.view.ViewDebug.ExportedProperty.resolveId()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "resolveId", "()Z", ref global::android.view.ViewDebug.ExportedProperty_._resolveId14983);
			}
			internal static global::MonoJavaBridge.MethodId _mapping14984;
			global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.mapping()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.view.ViewDebug.IntToString>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "mapping", "()[Landroid/view/ViewDebug/IntToString;", ref global::android.view.ViewDebug.ExportedProperty_._mapping14984) as android.view.ViewDebug.IntToString[];
			}
			internal static global::MonoJavaBridge.MethodId _indexMapping14985;
			global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.indexMapping()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.view.ViewDebug.IntToString>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "indexMapping", "()[Landroid/view/ViewDebug/IntToString;", ref global::android.view.ViewDebug.ExportedProperty_._indexMapping14985) as android.view.ViewDebug.IntToString[];
			}
			internal static global::MonoJavaBridge.MethodId _flagMapping14986;
			global::android.view.ViewDebug.FlagToString[] android.view.ViewDebug.ExportedProperty.flagMapping()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.view.ViewDebug.FlagToString>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "flagMapping", "()[Landroid/view/ViewDebug/FlagToString;", ref global::android.view.ViewDebug.ExportedProperty_._flagMapping14986) as android.view.ViewDebug.FlagToString[];
			}
			internal static global::MonoJavaBridge.MethodId _deepExport14987;
			bool android.view.ViewDebug.ExportedProperty.deepExport()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "deepExport", "()Z", ref global::android.view.ViewDebug.ExportedProperty_._deepExport14987);
			}
			internal static global::MonoJavaBridge.MethodId _equals14988;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.ViewDebug.ExportedProperty_._equals14988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString14989;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.ViewDebug.ExportedProperty_._toString14989) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode14990;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "hashCode", "()I", ref global::android.view.ViewDebug.ExportedProperty_._hashCode14990);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType14991;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.view.ViewDebug.ExportedProperty_._annotationType14991) as java.lang.Class;
			}
			static ExportedProperty_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.ExportedProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$ExportedProperty"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.FlagToString_))]
		public partial interface FlagToString : java.lang.annotation.Annotation
		{
			global::java.lang.String name();
			int equals();
			int mask();
			bool outputIf();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.FlagToString))]
		internal sealed partial class FlagToString_ : java.lang.Object, FlagToString
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal FlagToString_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _name14992;
			global::java.lang.String android.view.ViewDebug.FlagToString.name()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.FlagToString_.staticClass, "name", "()Ljava/lang/String;", ref global::android.view.ViewDebug.FlagToString_._name14992) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _equals14993;
			int android.view.ViewDebug.FlagToString.equals()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "()I", ref global::android.view.ViewDebug.FlagToString_._equals14993);
			}
			internal static global::MonoJavaBridge.MethodId _mask14994;
			int android.view.ViewDebug.FlagToString.mask()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "mask", "()I", ref global::android.view.ViewDebug.FlagToString_._mask14994);
			}
			internal static global::MonoJavaBridge.MethodId _outputIf14995;
			bool android.view.ViewDebug.FlagToString.outputIf()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "outputIf", "()Z", ref global::android.view.ViewDebug.FlagToString_._outputIf14995);
			}
			internal static global::MonoJavaBridge.MethodId _equals14996;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.ViewDebug.FlagToString_._equals14996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString14997;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.FlagToString_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.ViewDebug.FlagToString_._toString14997) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode14998;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "hashCode", "()I", ref global::android.view.ViewDebug.FlagToString_._hashCode14998);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType14999;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.view.ViewDebug.FlagToString_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.view.ViewDebug.FlagToString_._annotationType14999) as java.lang.Class;
			}
			static FlagToString_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.FlagToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$FlagToString"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class HierarchyTraceType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal HierarchyTraceType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values15000;
			public static global::android.view.ViewDebug.HierarchyTraceType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewDebug.HierarchyTraceType._values15000.native == global::System.IntPtr.Zero)
					global::android.view.ViewDebug.HierarchyTraceType._values15000 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/HierarchyTraceType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.HierarchyTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._values15000)) as android.view.ViewDebug.HierarchyTraceType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf15001;
			public static global::android.view.ViewDebug.HierarchyTraceType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewDebug.HierarchyTraceType._valueOf15001.native == global::System.IntPtr.Zero)
					global::android.view.ViewDebug.HierarchyTraceType._valueOf15001 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._valueOf15001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.HierarchyTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BUILD_CACHE15002;
			public static global::android.view.ViewDebug.HierarchyTraceType BUILD_CACHE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _BUILD_CACHE15002)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DRAW15003;
			public static global::android.view.ViewDebug.HierarchyTraceType DRAW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _DRAW15003)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE15004;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE15004)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD15005;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE_CHILD15005)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD_IN_PARENT15006;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD_IN_PARENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE_CHILD_IN_PARENT15006)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_LAYOUT15007;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_LAYOUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _ON_LAYOUT15007)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_MEASURE15008;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_MEASURE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _ON_MEASURE15008)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REQUEST_LAYOUT15009;
			public static global::android.view.ViewDebug.HierarchyTraceType REQUEST_LAYOUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _REQUEST_LAYOUT15009)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			static HierarchyTraceType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.HierarchyTraceType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$HierarchyTraceType"));
				global::android.view.ViewDebug.HierarchyTraceType._BUILD_CACHE15002 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "BUILD_CACHE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._DRAW15003 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "DRAW", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE15004 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE_CHILD15005 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE_CHILD", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE_CHILD_IN_PARENT15006 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE_CHILD_IN_PARENT", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._ON_LAYOUT15007 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "ON_LAYOUT", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._ON_MEASURE15008 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "ON_MEASURE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._REQUEST_LAYOUT15009 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "REQUEST_LAYOUT", "Landroid/view/ViewDebug$HierarchyTraceType;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.IntToString_))]
		public partial interface IntToString : java.lang.annotation.Annotation
		{
			int from();
			global::java.lang.String to();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.IntToString))]
		internal sealed partial class IntToString_ : java.lang.Object, IntToString
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal IntToString_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _from15010;
			int android.view.ViewDebug.IntToString.from()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.IntToString_.staticClass, "from", "()I", ref global::android.view.ViewDebug.IntToString_._from15010);
			}
			internal static global::MonoJavaBridge.MethodId _to15011;
			global::java.lang.String android.view.ViewDebug.IntToString.to()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.IntToString_.staticClass, "to", "()Ljava/lang/String;", ref global::android.view.ViewDebug.IntToString_._to15011) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _equals15012;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.IntToString_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.ViewDebug.IntToString_._equals15012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString15013;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.IntToString_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.ViewDebug.IntToString_._toString15013) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode15014;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.IntToString_.staticClass, "hashCode", "()I", ref global::android.view.ViewDebug.IntToString_._hashCode15014);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType15015;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.view.ViewDebug.IntToString_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.view.ViewDebug.IntToString_._annotationType15015) as java.lang.Class;
			}
			static IntToString_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.IntToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$IntToString"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RecyclerTraceType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal RecyclerTraceType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values15016;
			public static global::android.view.ViewDebug.RecyclerTraceType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewDebug.RecyclerTraceType._values15016.native == global::System.IntPtr.Zero)
					global::android.view.ViewDebug.RecyclerTraceType._values15016 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/RecyclerTraceType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.RecyclerTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._values15016)) as android.view.ViewDebug.RecyclerTraceType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf15017;
			public static global::android.view.ViewDebug.RecyclerTraceType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewDebug.RecyclerTraceType._valueOf15017.native == global::System.IntPtr.Zero)
					global::android.view.ViewDebug.RecyclerTraceType._valueOf15017 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._valueOf15017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.RecyclerTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BIND_VIEW15018;
			public static global::android.view.ViewDebug.RecyclerTraceType BIND_VIEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _BIND_VIEW15018)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP15019;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP15019)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_TO_SCRAP_HEAP15020;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_TO_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _MOVE_TO_SCRAP_HEAP15020)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEW_VIEW15021;
			public static global::android.view.ViewDebug.RecyclerTraceType NEW_VIEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _NEW_VIEW15021)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_ACTIVE_HEAP15022;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _RECYCLE_FROM_ACTIVE_HEAP15022)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_SCRAP_HEAP15023;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _RECYCLE_FROM_SCRAP_HEAP15023)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			static RecyclerTraceType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.RecyclerTraceType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$RecyclerTraceType"));
				global::android.view.ViewDebug.RecyclerTraceType._BIND_VIEW15018 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "BIND_VIEW", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._MOVE_FROM_ACTIVE_TO_SCRAP_HEAP15019 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "MOVE_FROM_ACTIVE_TO_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._MOVE_TO_SCRAP_HEAP15020 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "MOVE_TO_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._NEW_VIEW15021 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "NEW_VIEW", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._RECYCLE_FROM_ACTIVE_HEAP15022 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "RECYCLE_FROM_ACTIVE_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._RECYCLE_FROM_SCRAP_HEAP15023 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "RECYCLE_FROM_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _trace15024;
		public static void trace(android.view.View arg0, android.view.ViewDebug.RecyclerTraceType arg1, int[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._trace15024.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._trace15024 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace15024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _trace15025;
		public static void trace(android.view.View arg0, android.view.ViewDebug.HierarchyTraceType arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._trace15025.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._trace15025 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace15025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startRecyclerTracing15026;
		public static void startRecyclerTracing(java.lang.String arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._startRecyclerTracing15026.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._startRecyclerTracing15026 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startRecyclerTracing15026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopRecyclerTracing15027;
		public static void stopRecyclerTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._stopRecyclerTracing15027.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._stopRecyclerTracing15027 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopRecyclerTracing", "()V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopRecyclerTracing15027);
		}
		internal static global::MonoJavaBridge.MethodId _startHierarchyTracing15028;
		public static void startHierarchyTracing(java.lang.String arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._startHierarchyTracing15028.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._startHierarchyTracing15028 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startHierarchyTracing15028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopHierarchyTracing15029;
		public static void stopHierarchyTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._stopHierarchyTracing15029.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._stopHierarchyTracing15029 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopHierarchyTracing", "()V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopHierarchyTracing15029);
		}
		internal static global::MonoJavaBridge.MethodId _dumpCapturedView15030;
		public static void dumpCapturedView(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._dumpCapturedView15030.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._dumpCapturedView15030 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._dumpCapturedView15030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ViewDebug15031;
		public ViewDebug() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._ViewDebug15031.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._ViewDebug15031 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._ViewDebug15031);
			Init(@__env, handle);
		}
		public static bool TRACE_HIERARCHY
		{
			get
			{
				return false;
			}
		}
		public static bool TRACE_RECYCLER
		{
			get
			{
				return false;
			}
		}
		static ViewDebug()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewDebug.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug"));
		}
		internal static void InitJNI()
		{
		}
	}
}
