namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.StatusLine_))]
	public partial interface StatusLine  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.ProtocolVersion getProtocolVersion();
		int getStatusCode();
		global::java.lang.String getReasonPhrase();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.StatusLine))]
	internal sealed partial class StatusLine_ : java.lang.Object, StatusLine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StatusLine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31763;
		global::org.apache.http.ProtocolVersion org.apache.http.StatusLine.getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.StatusLine_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.StatusLine_._getProtocolVersion31763) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getStatusCode31764;
		int org.apache.http.StatusLine.getStatusCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.StatusLine_.staticClass, "getStatusCode", "()I", ref global::org.apache.http.StatusLine_._getStatusCode31764);
		}
		internal static global::MonoJavaBridge.MethodId _getReasonPhrase31765;
		global::java.lang.String org.apache.http.StatusLine.getReasonPhrase()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.StatusLine_.staticClass, "getReasonPhrase", "()Ljava/lang/String;", ref global::org.apache.http.StatusLine_._getReasonPhrase31765) as java.lang.String;
		}
		static StatusLine_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.StatusLine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/StatusLine"));
		}
		internal static void InitJNI()
		{
		}
	}
}
