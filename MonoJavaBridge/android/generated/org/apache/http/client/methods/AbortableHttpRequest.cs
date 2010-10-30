namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.methods.AbortableHttpRequest_))]
	public partial interface AbortableHttpRequest  : global::MonoJavaBridge.IJavaObject 
	{
		void abort();
		void setConnectionRequest(org.apache.http.conn.ClientConnectionRequest arg0);
		void setReleaseTrigger(org.apache.http.conn.ConnectionReleaseTrigger arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.methods.AbortableHttpRequest))]
	internal sealed partial class AbortableHttpRequest_ : java.lang.Object, AbortableHttpRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbortableHttpRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abort31906;
		void org.apache.http.client.methods.AbortableHttpRequest.abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, "abort", "()V", ref global::org.apache.http.client.methods.AbortableHttpRequest_._abort31906);
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionRequest31907;
		void org.apache.http.client.methods.AbortableHttpRequest.setConnectionRequest(org.apache.http.conn.ClientConnectionRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, "setConnectionRequest", "(Lorg/apache/http/conn/ClientConnectionRequest;)V", ref global::org.apache.http.client.methods.AbortableHttpRequest_._setConnectionRequest31907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReleaseTrigger31908;
		void org.apache.http.client.methods.AbortableHttpRequest.setReleaseTrigger(org.apache.http.conn.ConnectionReleaseTrigger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, "setReleaseTrigger", "(Lorg/apache/http/conn/ConnectionReleaseTrigger;)V", ref global::org.apache.http.client.methods.AbortableHttpRequest_._setReleaseTrigger31908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbortableHttpRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/AbortableHttpRequest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
