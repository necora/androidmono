namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MenuInflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MenuInflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate14344;
		public virtual void inflate(int arg0, android.view.Menu arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.MenuInflater.staticClass, "inflate", "(ILandroid/view/Menu;)V", ref global::android.view.MenuInflater._inflate14344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MenuInflater14345;
		public MenuInflater(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuInflater._MenuInflater14345.native == global::System.IntPtr.Zero)
				global::android.view.MenuInflater._MenuInflater14345 = @__env.GetMethodIDNoThrow(global::android.view.MenuInflater.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.MenuInflater.staticClass, global::android.view.MenuInflater._MenuInflater14345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MenuInflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuInflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuInflater"));
		}
		internal static void InitJNI()
		{
		}
	}
}
