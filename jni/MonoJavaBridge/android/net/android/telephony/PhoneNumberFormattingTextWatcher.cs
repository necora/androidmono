namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PhoneNumberFormattingTextWatcher : java.lang.Object, android.text.TextWatcher
	{ 
		internal static global::java.lang.Class staticClass; 
		static PhoneNumberFormattingTextWatcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.PhoneNumberFormattingTextWatcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.telephony.PhoneNumberFormattingTextWatcher(@__env); 
			} 
		} 
		protected PhoneNumberFormattingTextWatcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged6167; 
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.PhoneNumberFormattingTextWatcher)) 
				@__env.CallVoidMethod(this, _onTextChanged6167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.PhoneNumberFormattingTextWatcher.staticClass, _onTextChanged6167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beforeTextChanged6168; 
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.PhoneNumberFormattingTextWatcher)) 
				@__env.CallVoidMethod(this, _beforeTextChanged6168, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.PhoneNumberFormattingTextWatcher.staticClass, _beforeTextChanged6168, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _afterTextChanged6169; 
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.PhoneNumberFormattingTextWatcher)) 
				@__env.CallVoidMethod(this, _afterTextChanged6169, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.PhoneNumberFormattingTextWatcher.staticClass, _afterTextChanged6169, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PhoneNumberFormattingTextWatcher6170; 
		public PhoneNumberFormattingTextWatcher()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.PhoneNumberFormattingTextWatcher.staticClass, _PhoneNumberFormattingTextWatcher6170, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass = @__class; 
			global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged6167 = @__env.GetMethodID(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged6168 = @__env.GetMethodID(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged6169 = @__env.GetMethodID(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V"); 
			global::android.telephony.PhoneNumberFormattingTextWatcher._PhoneNumberFormattingTextWatcher6170 = @__env.GetMethodID(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "<init>", "()V"); 
		} 
	} 
} 