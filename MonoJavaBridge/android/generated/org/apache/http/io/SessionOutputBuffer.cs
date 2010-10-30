namespace org.apache.http.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.io.SessionOutputBuffer_))]
	public partial interface SessionOutputBuffer  : global::MonoJavaBridge.IJavaObject 
	{
		void write(byte[] arg0, int arg1, int arg2);
		void write(byte[] arg0);
		void write(int arg0);
		void flush();
		global::org.apache.http.io.HttpTransportMetrics getMetrics();
		void writeLine(java.lang.String arg0);
		void writeLine(org.apache.http.util.CharArrayBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.io.SessionOutputBuffer))]
	internal sealed partial class SessionOutputBuffer_ : java.lang.Object, SessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SessionOutputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33478;
		void org.apache.http.io.SessionOutputBuffer.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "([BII)V", ref global::org.apache.http.io.SessionOutputBuffer_._write33478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write33479;
		void org.apache.http.io.SessionOutputBuffer.write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "([B)V", ref global::org.apache.http.io.SessionOutputBuffer_._write33479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write33480;
		void org.apache.http.io.SessionOutputBuffer.write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "write", "(I)V", ref global::org.apache.http.io.SessionOutputBuffer_._write33480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush33481;
		void org.apache.http.io.SessionOutputBuffer.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "flush", "()V", ref global::org.apache.http.io.SessionOutputBuffer_._flush33481);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33482;
		global::org.apache.http.io.HttpTransportMetrics org.apache.http.io.SessionOutputBuffer.getMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", ref global::org.apache.http.io.SessionOutputBuffer_._getMetrics33482) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _writeLine33483;
		void org.apache.http.io.SessionOutputBuffer.writeLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "writeLine", "(Ljava/lang/String;)V", ref global::org.apache.http.io.SessionOutputBuffer_._writeLine33483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLine33484;
		void org.apache.http.io.SessionOutputBuffer.writeLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.io.SessionOutputBuffer_.staticClass, "writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", ref global::org.apache.http.io.SessionOutputBuffer_._writeLine33484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SessionOutputBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.SessionOutputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/SessionOutputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
