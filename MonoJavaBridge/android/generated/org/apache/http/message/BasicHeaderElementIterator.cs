namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderElementIterator : java.lang.Object, HeaderElementIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderElementIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext33523;
		public virtual bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "hasNext", "()Z", ref global::org.apache.http.message.BasicHeaderElementIterator._hasNext33523);
		}
		internal static global::MonoJavaBridge.MethodId _next33524;
		public virtual global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "next", "()Ljava/lang/Object;", ref global::org.apache.http.message.BasicHeaderElementIterator._next33524) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove33525;
		public virtual void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "remove", "()V", ref global::org.apache.http.message.BasicHeaderElementIterator._remove33525);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement33526;
		public virtual global::org.apache.http.HeaderElement nextElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "nextElement", "()Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BasicHeaderElementIterator._nextElement33526) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderElementIterator33527;
		public BasicHeaderElementIterator(org.apache.http.HeaderIterator arg0, org.apache.http.message.HeaderValueParser arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33527.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33527 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;Lorg/apache/http/message/HeaderValueParser;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderElementIterator33528;
		public BasicHeaderElementIterator(org.apache.http.HeaderIterator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33528.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33528 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BasicHeaderElementIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderElementIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderElementIterator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
