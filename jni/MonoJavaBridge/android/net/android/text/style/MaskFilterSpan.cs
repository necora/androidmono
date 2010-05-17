namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MaskFilterSpan : android.text.style.CharacterStyle, UpdateAppearance
	{ 
		internal new static global::java.lang.Class staticClass; 
		static MaskFilterSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.MaskFilterSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.MaskFilterSpan(@__env); 
			} 
		} 
		protected MaskFilterSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaskFilter6991; 
		public virtual android.graphics.MaskFilter getMaskFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.MaskFilterSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallObjectMethodPtr(this, _getMaskFilter6991)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.MaskFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.MaskFilterSpan.staticClass, _getMaskFilter6991)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState6992; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.MaskFilterSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState6992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.MaskFilterSpan.staticClass, _updateDrawState6992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MaskFilterSpan6993; 
		public MaskFilterSpan(android.graphics.MaskFilter arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.MaskFilterSpan.staticClass, _MaskFilterSpan6993, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.MaskFilterSpan.staticClass = @__class; 
			global::android.text.style.MaskFilterSpan._getMaskFilter6991 = @__env.GetMethodID(global::android.text.style.MaskFilterSpan.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;"); 
			global::android.text.style.MaskFilterSpan._updateDrawState6992 = @__env.GetMethodID(global::android.text.style.MaskFilterSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.MaskFilterSpan._MaskFilterSpan6993 = @__env.GetMethodID(global::android.text.style.MaskFilterSpan.staticClass, "<init>", "(Landroid/graphics/MaskFilter;)V"); 
		} 
	} 
} 