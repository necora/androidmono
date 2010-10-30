namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.CharacterStyle_))]
	public abstract partial class CharacterStyle : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharacterStyle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap13459;
		public static global::android.text.style.CharacterStyle wrap(android.text.style.CharacterStyle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.CharacterStyle._wrap13459.native == global::System.IntPtr.Zero)
				global::android.text.style.CharacterStyle._wrap13459 = @__env.GetStaticMethodIDNoThrow(global::android.text.style.CharacterStyle.staticClass, "wrap", "(Landroid/text/style/CharacterStyle;)Landroid/text/style/CharacterStyle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.style.CharacterStyle.staticClass, global::android.text.style.CharacterStyle._wrap13459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.style.CharacterStyle;
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13460;
		public abstract void updateDrawState(android.text.TextPaint arg0);
		internal static global::MonoJavaBridge.MethodId _getUnderlying13461;
		public virtual global::android.text.style.CharacterStyle getUnderlying()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.CharacterStyle.staticClass, "getUnderlying", "()Landroid/text/style/CharacterStyle;", ref global::android.text.style.CharacterStyle._getUnderlying13461) as android.text.style.CharacterStyle;
		}
		internal static global::MonoJavaBridge.MethodId _CharacterStyle13462;
		public CharacterStyle() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.CharacterStyle._CharacterStyle13462.native == global::System.IntPtr.Zero)
				global::android.text.style.CharacterStyle._CharacterStyle13462 = @__env.GetMethodIDNoThrow(global::android.text.style.CharacterStyle.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.CharacterStyle.staticClass, global::android.text.style.CharacterStyle._CharacterStyle13462);
			Init(@__env, handle);
		}
		static CharacterStyle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.CharacterStyle.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/CharacterStyle"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.CharacterStyle))]
	internal sealed partial class CharacterStyle_ : android.text.style.CharacterStyle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharacterStyle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13463;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.CharacterStyle_.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.CharacterStyle_._updateDrawState13463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CharacterStyle_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.CharacterStyle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/CharacterStyle"));
		}
		internal static void InitJNI()
		{
		}
	}
}
