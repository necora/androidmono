namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpClientConnection_))]
	public partial interface HttpClientConnection : HttpConnection
	{
		void flush();
		bool isResponseAvailable(int arg0);
		void sendRequestHeader(org.apache.http.HttpRequest arg0);
		void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0);
		global::org.apache.http.HttpResponse receiveResponseHeader();
		void receiveResponseEntity(org.apache.http.HttpResponse arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpClientConnection))]
	internal sealed partial class HttpClientConnection_ : java.lang.Object, HttpClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush31516;
		void org.apache.http.HttpClientConnection.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "flush", "()V", ref global::org.apache.http.HttpClientConnection_._flush31516);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable31517;
		bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "isResponseAvailable", "(I)Z", ref global::org.apache.http.HttpClientConnection_._isResponseAvailable31517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader31518;
		void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", ref global::org.apache.http.HttpClientConnection_._sendRequestHeader31518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity31519;
		void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", ref global::org.apache.http.HttpClientConnection_._sendRequestEntity31519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader31520;
		global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.HttpClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", ref global::org.apache.http.HttpClientConnection_._receiveResponseHeader31520) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity31521;
		void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", ref global::org.apache.http.HttpClientConnection_._receiveResponseEntity31521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown31522;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "shutdown", "()V", ref global::org.apache.http.HttpClientConnection_._shutdown31522);
		}
		internal static global::MonoJavaBridge.MethodId _close31523;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "close", "()V", ref global::org.apache.http.HttpClientConnection_._close31523);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen31524;
		bool org.apache.http.HttpConnection.isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "isOpen", "()Z", ref global::org.apache.http.HttpClientConnection_._isOpen31524);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics31525;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpConnectionMetrics>(this, global::org.apache.http.HttpClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", ref global::org.apache.http.HttpClientConnection_._getMetrics31525) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale31526;
		bool org.apache.http.HttpConnection.isStale()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "isStale", "()Z", ref global::org.apache.http.HttpClientConnection_._isStale31526);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout31527;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "setSocketTimeout", "(I)V", ref global::org.apache.http.HttpClientConnection_._setSocketTimeout31527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout31528;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpClientConnection_.staticClass, "getSocketTimeout", "()I", ref global::org.apache.http.HttpClientConnection_._getSocketTimeout31528);
		}
		static HttpClientConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpClientConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
