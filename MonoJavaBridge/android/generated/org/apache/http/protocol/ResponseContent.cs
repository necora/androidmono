namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResponseContent : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResponseContent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33950;
		public virtual void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.ResponseContent.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.ResponseContent._process33950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResponseContent33951;
		public ResponseContent() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.ResponseContent._ResponseContent33951.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.ResponseContent._ResponseContent33951 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.ResponseContent.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.ResponseContent.staticClass, global::org.apache.http.protocol.ResponseContent._ResponseContent33951);
			Init(@__env, handle);
		}
		static ResponseContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.ResponseContent.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/ResponseContent"));
		}
		internal static void InitJNI()
		{
		}
	}
}
