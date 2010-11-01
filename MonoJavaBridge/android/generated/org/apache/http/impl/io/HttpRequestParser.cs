namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRequestParser : org.apache.http.impl.io.AbstractMessageParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpRequestParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::org.apache.http.HttpMessage parseHead(org.apache.http.io.SessionInputBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpMessage>(this, global::org.apache.http.impl.io.HttpRequestParser.staticClass, "parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", ref global::org.apache.http.impl.io.HttpRequestParser._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpMessage;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public HttpRequestParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.message.LineParser arg1, org.apache.http.HttpRequestFactory arg2, org.apache.http.@params.HttpParams arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.HttpRequestParser._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.HttpRequestParser._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpRequestParser.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/apache/http/HttpRequestFactory;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpRequestParser.staticClass, global::org.apache.http.impl.io.HttpRequestParser._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static HttpRequestParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpRequestParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpRequestParser"));
		}
	}
}