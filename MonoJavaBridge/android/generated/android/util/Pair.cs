namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Pair : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Pair(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals13813;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.Pair.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.util.Pair._equals13813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13814;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.Pair.staticClass, "hashCode", "()I", ref global::android.util.Pair._hashCode13814);
		}
		internal static global::MonoJavaBridge.MethodId _create13815;
		public static global::android.util.Pair create(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Pair._create13815.native == global::System.IntPtr.Zero)
				global::android.util.Pair._create13815 = @__env.GetStaticMethodIDNoThrow(global::android.util.Pair.staticClass, "create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Pair.staticClass, global::android.util.Pair._create13815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.util.Pair;
		}
		internal static global::MonoJavaBridge.MethodId _Pair13816;
		public Pair(java.lang.Object arg0, java.lang.Object arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Pair._Pair13816.native == global::System.IntPtr.Zero)
				global::android.util.Pair._Pair13816 = @__env.GetMethodIDNoThrow(global::android.util.Pair.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Pair.staticClass, global::android.util.Pair._Pair13816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _first13817;
		public global::java.lang.Object first
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _first13817)) as java.lang.Object;
			}
		}
		internal static global::MonoJavaBridge.FieldId _second13818;
		public global::java.lang.Object second
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _second13818)) as java.lang.Object;
			}
		}
		static Pair()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Pair.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Pair"));
			global::android.util.Pair._first13817 = @__env.GetFieldIDNoThrow(global::android.util.Pair.staticClass, "first", "Ljava/lang/Object;");
			global::android.util.Pair._second13818 = @__env.GetFieldIDNoThrow(global::android.util.Pair.staticClass, "second", "Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
