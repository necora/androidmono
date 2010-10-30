namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2965CommentUrlAttributeHandler : java.lang.Object, org.apache.http.cookie.CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2965CommentUrlAttributeHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33339;
		public virtual void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler._parse33339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match33340;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", ref global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler._match33340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33341;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", ref global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler._validate33341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965CommentUrlAttributeHandler33342;
		public RFC2965CommentUrlAttributeHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler._RFC2965CommentUrlAttributeHandler33342.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler._RFC2965CommentUrlAttributeHandler33342 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler._RFC2965CommentUrlAttributeHandler33342);
			Init(@__env, handle);
		}
		static RFC2965CommentUrlAttributeHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2965CommentUrlAttributeHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2965CommentUrlAttributeHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
