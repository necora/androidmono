namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicHttpProcessor : java.lang.Object, HttpProcessor, HttpRequestInterceptorList, HttpResponseInterceptorList, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BasicHttpProcessor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone33820;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.protocol.BasicHttpProcessor._clone33820) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _copy33821;
		public global::org.apache.http.protocol.BasicHttpProcessor copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.protocol.BasicHttpProcessor>(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "copy", "()Lorg/apache/http/protocol/BasicHttpProcessor;", ref global::org.apache.http.protocol.BasicHttpProcessor._copy33821) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _process33822;
		public void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._process33822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _process33823;
		public void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._process33823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor33824;
		public void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor33824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor33825;
		public void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", ref global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor33825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor33826;
		public global::org.apache.http.HttpResponseInterceptor getResponseInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponseInterceptor>(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", ref global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptor33826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpResponseInterceptor;
		}
		public new int ResponseInterceptorCount
		{
			get
			{
				return getResponseInterceptorCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount33827;
		public int getResponseInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getResponseInterceptorCount", "()I", ref global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptorCount33827);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors33828;
		public void clearResponseInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearResponseInterceptors", "()V", ref global::org.apache.http.protocol.BasicHttpProcessor._clearResponseInterceptors33828);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass33829;
		public void removeResponseInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._removeResponseInterceptorByClass33829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor33830;
		public void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", ref global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor33830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor33831;
		public void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor33831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptor33832;
		public global::org.apache.http.HttpRequestInterceptor getRequestInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequestInterceptor>(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;", ref global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptor33832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpRequestInterceptor;
		}
		public new int RequestInterceptorCount
		{
			get
			{
				return getRequestInterceptorCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptorCount33833;
		public int getRequestInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getRequestInterceptorCount", "()I", ref global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptorCount33833);
		}
		internal static global::MonoJavaBridge.MethodId _clearRequestInterceptors33834;
		public void clearRequestInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearRequestInterceptors", "()V", ref global::org.apache.http.protocol.BasicHttpProcessor._clearRequestInterceptors33834);
		}
		internal static global::MonoJavaBridge.MethodId _removeRequestInterceptorByClass33835;
		public void removeRequestInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._removeRequestInterceptorByClass33835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor33836;
		public void addInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", ref global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor33837;
		public void addInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", ref global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor33838;
		public void addInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor33839;
		public void addInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Interceptors
		{
			set
			{
				setInterceptors(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInterceptors33840;
		public void setInterceptors(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "setInterceptors", "(Ljava/util/List;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._setInterceptors33840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearInterceptors33841;
		public void clearInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearInterceptors", "()V", ref global::org.apache.http.protocol.BasicHttpProcessor._clearInterceptors33841);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpProcessor33842;
		public BasicHttpProcessor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.BasicHttpProcessor._BasicHttpProcessor33842.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.BasicHttpProcessor._BasicHttpProcessor33842 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._BasicHttpProcessor33842);
			Init(@__env, handle);
		}
		static BasicHttpProcessor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.BasicHttpProcessor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/BasicHttpProcessor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
