namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.EndElementListener_))]
	public partial interface EndElementListener  : global::MonoJavaBridge.IJavaObject 
	{
		void end();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.EndElementListener))]
	internal sealed partial class EndElementListener_ : java.lang.Object, EndElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EndElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _end11610;
		void android.sax.EndElementListener.end()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.EndElementListener_.staticClass, "end", "()V", ref global::android.sax.EndElementListener_._end11610);
		}
		static EndElementListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.EndElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/EndElementListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void EndElementListenerDelegate();

	internal partial class EndElementListenerDelegateWrapper : java.lang.Object, EndElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EndElementListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _EndElementListenerDelegateWrapper11611;
		public EndElementListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.sax.EndElementListenerDelegateWrapper._EndElementListenerDelegateWrapper11611.native == global::System.IntPtr.Zero)
				global::android.sax.EndElementListenerDelegateWrapper._EndElementListenerDelegateWrapper11611 = @__env.GetMethodIDNoThrow(global::android.sax.EndElementListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.EndElementListenerDelegateWrapper.staticClass, global::android.sax.EndElementListenerDelegateWrapper._EndElementListenerDelegateWrapper11611);
			Init(@__env, handle);
		}
		static EndElementListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.EndElementListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/EndElementListenerDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class EndElementListenerDelegateWrapper
	{
		private EndElementListenerDelegate myDelegate;
		public void end()
		{
			myDelegate();
		}
		public static implicit operator EndElementListenerDelegateWrapper(EndElementListenerDelegate d)
		{
			global::android.sax.EndElementListenerDelegateWrapper ret = new global::android.sax.EndElementListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
