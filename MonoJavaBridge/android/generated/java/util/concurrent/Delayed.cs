namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.Delayed_))]
	public partial interface Delayed : java.lang.Comparable
	{
		long getDelay(java.util.concurrent.TimeUnit arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.Delayed))]
	internal sealed partial class Delayed_ : java.lang.Object, Delayed
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Delayed_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDelay27252;
		long java.util.concurrent.Delayed.getDelay(java.util.concurrent.TimeUnit arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.Delayed_.staticClass, "getDelay", "(Ljava/util/concurrent/TimeUnit;)J", ref global::java.util.concurrent.Delayed_._getDelay27252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo27253;
		int java.lang.Comparable.compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.Delayed_.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.Delayed_._compareTo27253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Delayed_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Delayed_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Delayed"));
		}
		internal static void InitJNI()
		{
		}
	}
}
