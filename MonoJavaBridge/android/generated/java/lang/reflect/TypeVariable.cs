namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.TypeVariable_))]
	public partial interface TypeVariable : Type
	{
		global::java.lang.String getName();
		global::java.lang.reflect.Type[] getBounds();
		global::java.lang.reflect.GenericDeclaration getGenericDeclaration();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.TypeVariable))]
	internal sealed partial class TypeVariable_ : java.lang.Object, TypeVariable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TypeVariable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName21155;
		global::java.lang.String java.lang.reflect.TypeVariable.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.TypeVariable_.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.reflect.TypeVariable_._getName21155) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBounds21156;
		global::java.lang.reflect.Type[] java.lang.reflect.TypeVariable.getBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.TypeVariable_.staticClass, "getBounds", "()[Ljava/lang/reflect/Type;", ref global::java.lang.reflect.TypeVariable_._getBounds21156) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getGenericDeclaration21157;
		global::java.lang.reflect.GenericDeclaration java.lang.reflect.TypeVariable.getGenericDeclaration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.reflect.GenericDeclaration>(this, global::java.lang.reflect.TypeVariable_.staticClass, "getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;", ref global::java.lang.reflect.TypeVariable_._getGenericDeclaration21157) as java.lang.reflect.GenericDeclaration;
		}
		static TypeVariable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.TypeVariable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/TypeVariable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
