namespace android.text.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Rfc822Tokenizer : java.lang.Object, android.widget.MultiAutoCompleteTextView.Tokenizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Rfc822Tokenizer()
		{
			InitJNI();
		}
		protected Rfc822Tokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _tokenize8431;
		public static void tokenize(java.lang.CharSequence arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._tokenize8431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tokenize8432;
		public static global::android.text.util.Rfc822Token[] tokenize(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.util.Rfc822Token>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._tokenize8432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.util.Rfc822Token[];
		}
		internal static global::MonoJavaBridge.MethodId _findTokenStart8433;
		public virtual int findTokenStart(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.util.Rfc822Tokenizer._findTokenStart8433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._findTokenStart8433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public int findTokenStart(string arg0, int arg1)
		{
			return findTokenStart((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _findTokenEnd8434;
		public virtual int findTokenEnd(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.util.Rfc822Tokenizer._findTokenEnd8434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._findTokenEnd8434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public int findTokenEnd(string arg0, int arg1)
		{
			return findTokenEnd((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _terminateToken8435;
		public virtual global::java.lang.CharSequence terminateToken(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Tokenizer._terminateToken8435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._terminateToken8435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence terminateToken(string arg0)
		{
			return terminateToken((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _Rfc822Tokenizer8436;
		public Rfc822Tokenizer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Rfc822Tokenizer.staticClass, global::android.text.util.Rfc822Tokenizer._Rfc822Tokenizer8436);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Rfc822Tokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Rfc822Tokenizer"));
			global::android.text.util.Rfc822Tokenizer._tokenize8431 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "tokenize", "(Ljava/lang/CharSequence;Ljava/util/Collection;)V");
			global::android.text.util.Rfc822Tokenizer._tokenize8432 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "tokenize", "(Ljava/lang/CharSequence;)[Landroid/text/util/Rfc822Token;");
			global::android.text.util.Rfc822Tokenizer._findTokenStart8433 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "findTokenStart", "(Ljava/lang/CharSequence;I)I");
			global::android.text.util.Rfc822Tokenizer._findTokenEnd8434 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "findTokenEnd", "(Ljava/lang/CharSequence;I)I");
			global::android.text.util.Rfc822Tokenizer._terminateToken8435 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.text.util.Rfc822Tokenizer._Rfc822Tokenizer8436 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Tokenizer.staticClass, "<init>", "()V");
		}
	}
}
