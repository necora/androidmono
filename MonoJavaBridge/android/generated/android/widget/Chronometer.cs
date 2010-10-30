namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Chronometer : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Chronometer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Chronometer.OnChronometerTickListener_))]
		public partial interface OnChronometerTickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onChronometerTick(android.widget.Chronometer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Chronometer.OnChronometerTickListener))]
		internal sealed partial class OnChronometerTickListener_ : java.lang.Object, OnChronometerTickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnChronometerTickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onChronometerTick16859;
			void android.widget.Chronometer.OnChronometerTickListener.onChronometerTick(android.widget.Chronometer arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.OnChronometerTickListener_.staticClass, "onChronometerTick", "(Landroid/widget/Chronometer;)V", ref global::android.widget.Chronometer.OnChronometerTickListener_._onChronometerTick16859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnChronometerTickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Chronometer.OnChronometerTickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer$OnChronometerTickListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnChronometerTickListenerDelegate(android.widget.Chronometer arg0);

		internal partial class OnChronometerTickListenerDelegateWrapper : java.lang.Object, OnChronometerTickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnChronometerTickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnChronometerTickListenerDelegateWrapper16860;
			public OnChronometerTickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper._OnChronometerTickListenerDelegateWrapper16860.native == global::System.IntPtr.Zero)
					global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper._OnChronometerTickListenerDelegateWrapper16860 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper.staticClass, global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper._OnChronometerTickListenerDelegateWrapper16860);
				Init(@__env, handle);
			}
			static OnChronometerTickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer_OnChronometerTickListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnChronometerTickListenerDelegateWrapper
		{
			private OnChronometerTickListenerDelegate myDelegate;
			public void onChronometerTick(android.widget.Chronometer arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnChronometerTickListenerDelegateWrapper(OnChronometerTickListenerDelegate d)
			{
				global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper ret = new global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _start16861;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "start", "()V", ref global::android.widget.Chronometer._start16861);
		}
		internal static global::MonoJavaBridge.MethodId _stop16862;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "stop", "()V", ref global::android.widget.Chronometer._stop16862);
		}
		public new global::java.lang.String Format
		{
			get
			{
				return getFormat();
			}
			set
			{
				setFormat(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormat16863;
		public virtual global::java.lang.String getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.Chronometer.staticClass, "getFormat", "()Ljava/lang/String;", ref global::android.widget.Chronometer._getFormat16863) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16864;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.Chronometer._onDetachedFromWindow16864);
		}
		internal static global::MonoJavaBridge.MethodId _setFormat16865;
		public virtual void setFormat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "setFormat", "(Ljava/lang/String;)V", ref global::android.widget.Chronometer._setFormat16865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged16866;
		protected override void onWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "onWindowVisibilityChanged", "(I)V", ref global::android.widget.Chronometer._onWindowVisibilityChanged16866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBase16867;
		public virtual void setBase(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "setBase", "(J)V", ref global::android.widget.Chronometer._setBase16867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Base
		{
			get
			{
				return getBase();
			}
			set
			{
				setBase(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBase16868;
		public virtual long getBase()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.Chronometer.staticClass, "getBase", "()J", ref global::android.widget.Chronometer._getBase16868);
		}
		internal static global::MonoJavaBridge.MethodId _setOnChronometerTickListener16869;
		public virtual void setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Chronometer.staticClass, "setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V", ref global::android.widget.Chronometer._setOnChronometerTickListener16869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnChronometerTickListener(global::android.widget.Chronometer.OnChronometerTickListenerDelegate arg0)
		{
			setOnChronometerTickListener((global::android.widget.Chronometer.OnChronometerTickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getOnChronometerTickListener16870;
		public virtual global::android.widget.Chronometer.OnChronometerTickListener getOnChronometerTickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Chronometer.OnChronometerTickListener>(this, global::android.widget.Chronometer.staticClass, "getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;", ref global::android.widget.Chronometer._getOnChronometerTickListener16870) as android.widget.Chronometer.OnChronometerTickListener;
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer16871;
		public Chronometer(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Chronometer._Chronometer16871.native == global::System.IntPtr.Zero)
				global::android.widget.Chronometer._Chronometer16871 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer16871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer16872;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Chronometer._Chronometer16872.native == global::System.IntPtr.Zero)
				global::android.widget.Chronometer._Chronometer16872 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer16872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Chronometer16873;
		public Chronometer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Chronometer._Chronometer16873.native == global::System.IntPtr.Zero)
				global::android.widget.Chronometer._Chronometer16873 = @__env.GetMethodIDNoThrow(global::android.widget.Chronometer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Chronometer.staticClass, global::android.widget.Chronometer._Chronometer16873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Chronometer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Chronometer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Chronometer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
