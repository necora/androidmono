namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicEofSensorWatcher : java.lang.Object, EofSensorWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicEofSensorWatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _eofDetected32061;
		public virtual bool eofDetected(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, "eofDetected", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.BasicEofSensorWatcher._eofDetected32061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamClosed32062;
		public virtual bool streamClosed(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, "streamClosed", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.BasicEofSensorWatcher._streamClosed32062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamAbort32063;
		public virtual bool streamAbort(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, "streamAbort", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.BasicEofSensorWatcher._streamAbort32063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicEofSensorWatcher32064;
		public BasicEofSensorWatcher(org.apache.http.conn.ManagedClientConnection arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.BasicEofSensorWatcher._BasicEofSensorWatcher32064.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.BasicEofSensorWatcher._BasicEofSensorWatcher32064 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicEofSensorWatcher.staticClass, "<init>", "(Lorg/apache/http/conn/ManagedClientConnection;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.BasicEofSensorWatcher.staticClass, global::org.apache.http.conn.BasicEofSensorWatcher._BasicEofSensorWatcher32064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicEofSensorWatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.BasicEofSensorWatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/BasicEofSensorWatcher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
