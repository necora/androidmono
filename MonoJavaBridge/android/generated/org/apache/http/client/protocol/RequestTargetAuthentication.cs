namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestTargetAuthentication : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestTargetAuthentication(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process32044;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.RequestTargetAuthentication.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.client.protocol.RequestTargetAuthentication._process32044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestTargetAuthentication32045;
		public RequestTargetAuthentication() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.protocol.RequestTargetAuthentication._RequestTargetAuthentication32045.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.protocol.RequestTargetAuthentication._RequestTargetAuthentication32045 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestTargetAuthentication.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.RequestTargetAuthentication.staticClass, global::org.apache.http.client.protocol.RequestTargetAuthentication._RequestTargetAuthentication32045);
			Init(@__env, handle);
		}
		static RequestTargetAuthentication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.RequestTargetAuthentication.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/RequestTargetAuthentication"));
		}
		internal static void InitJNI()
		{
		}
	}
}
