namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.animation.Animation_))]
	public abstract partial class Animation : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Animation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.animation.Animation.AnimationListener_))]
		public partial interface AnimationListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onAnimationStart(android.view.animation.Animation arg0);
			void onAnimationEnd(android.view.animation.Animation arg0);
			void onAnimationRepeat(android.view.animation.Animation arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Animation.AnimationListener))]
		internal sealed partial class AnimationListener_ : java.lang.Object, AnimationListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AnimationListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationStart15575;
			void android.view.animation.Animation.AnimationListener.onAnimationStart(android.view.animation.Animation arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationStart", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.Animation.AnimationListener_._onAnimationStart15575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationEnd15576;
			void android.view.animation.Animation.AnimationListener.onAnimationEnd(android.view.animation.Animation arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationEnd", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.Animation.AnimationListener_._onAnimationEnd15576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAnimationRepeat15577;
			void android.view.animation.Animation.AnimationListener.onAnimationRepeat(android.view.animation.Animation arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.AnimationListener_.staticClass, "onAnimationRepeat", "(Landroid/view/animation/Animation;)V", ref global::android.view.animation.Animation.AnimationListener_._onAnimationRepeat15577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static AnimationListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.AnimationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$AnimationListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class Description : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Description(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Description15578;
			protected Description() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.animation.Animation.Description._Description15578.native == global::System.IntPtr.Zero)
					global::android.view.animation.Animation.Description._Description15578 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.Description.staticClass, global::android.view.animation.Animation.Description._Description15578);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _type15579;
			public int type
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _type15579);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _value15580;
			public float value
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _value15580);
				}
				set
				{
				}
			}
			static Description()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.Animation.Description.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation$Description"));
				global::android.view.animation.Animation.Description._type15579 = @__env.GetFieldIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "type", "I");
				global::android.view.animation.Animation.Description._value15580 = @__env.GetFieldIDNoThrow(global::android.view.animation.Animation.Description.staticClass, "value", "F");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _clone15581;
		protected virtual global::android.view.animation.Animation clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;", ref global::android.view.animation.Animation._clone15581) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _start15582;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "start", "()V", ref global::android.view.animation.Animation._start15582);
		}
		internal static global::MonoJavaBridge.MethodId _reset15583;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "reset", "()V", ref global::android.view.animation.Animation._reset15583);
		}
		internal static global::MonoJavaBridge.MethodId _initialize15584;
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V", ref global::android.view.animation.Animation._initialize15584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cancel15585;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "cancel", "()V", ref global::android.view.animation.Animation._cancel15585);
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize15586;
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F", ref global::android.view.animation.Animation._resolveSize15586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatCount15587;
		public virtual int getRepeatCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I", ref global::android.view.animation.Animation._getRepeatCount15587);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15588;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V", ref global::android.view.animation.Animation._setInterpolator15588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setInterpolator(global::android.view.animation.InterpolatorDelegate arg0)
		{
			setInterpolator((global::android.view.animation.InterpolatorDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator15589;
		public virtual void setInterpolator(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V", ref global::android.view.animation.Animation._setInterpolator15589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator15590;
		public virtual global::android.view.animation.Interpolator getInterpolator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.animation.Interpolator>(this, global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;", ref global::android.view.animation.Animation._getInterpolator15590) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _isInitialized15591;
		public virtual bool isInitialized()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "isInitialized", "()Z", ref global::android.view.animation.Animation._isInitialized15591);
		}
		internal static global::MonoJavaBridge.MethodId _setStartOffset15592;
		public virtual void setStartOffset(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V", ref global::android.view.animation.Animation._setStartOffset15592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDuration15593;
		public virtual void setDuration(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setDuration", "(J)V", ref global::android.view.animation.Animation._setDuration15593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restrictDuration15594;
		public virtual void restrictDuration(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V", ref global::android.view.animation.Animation._restrictDuration15594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scaleCurrentDuration15595;
		public virtual void scaleCurrentDuration(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V", ref global::android.view.animation.Animation._scaleCurrentDuration15595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartTime15596;
		public virtual void setStartTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V", ref global::android.view.animation.Animation._setStartTime15596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startNow15597;
		public virtual void startNow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "startNow", "()V", ref global::android.view.animation.Animation._startNow15597);
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatMode15598;
		public virtual void setRepeatMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V", ref global::android.view.animation.Animation._setRepeatMode15598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeatCount15599;
		public virtual void setRepeatCount(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V", ref global::android.view.animation.Animation._setRepeatCount15599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillEnabled15600;
		public virtual bool isFillEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z", ref global::android.view.animation.Animation._isFillEnabled15600);
		}
		internal static global::MonoJavaBridge.MethodId _setFillEnabled15601;
		public virtual void setFillEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V", ref global::android.view.animation.Animation._setFillEnabled15601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillBefore15602;
		public virtual void setFillBefore(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V", ref global::android.view.animation.Animation._setFillBefore15602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFillAfter15603;
		public virtual void setFillAfter(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V", ref global::android.view.animation.Animation._setFillAfter15603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZAdjustment15604;
		public virtual void setZAdjustment(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V", ref global::android.view.animation.Animation._setZAdjustment15604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDetachWallpaper15605;
		public virtual void setDetachWallpaper(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V", ref global::android.view.animation.Animation._setDetachWallpaper15605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStartTime15606;
		public virtual long getStartTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.Animation.staticClass, "getStartTime", "()J", ref global::android.view.animation.Animation._getStartTime15606);
		}
		internal static global::MonoJavaBridge.MethodId _getDuration15607;
		public virtual long getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.Animation.staticClass, "getDuration", "()J", ref global::android.view.animation.Animation._getDuration15607);
		}
		internal static global::MonoJavaBridge.MethodId _getStartOffset15608;
		public virtual long getStartOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.Animation.staticClass, "getStartOffset", "()J", ref global::android.view.animation.Animation._getStartOffset15608);
		}
		internal static global::MonoJavaBridge.MethodId _getRepeatMode15609;
		public virtual int getRepeatMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I", ref global::android.view.animation.Animation._getRepeatMode15609);
		}
		internal static global::MonoJavaBridge.MethodId _getFillBefore15610;
		public virtual bool getFillBefore()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z", ref global::android.view.animation.Animation._getFillBefore15610);
		}
		internal static global::MonoJavaBridge.MethodId _getFillAfter15611;
		public virtual bool getFillAfter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z", ref global::android.view.animation.Animation._getFillAfter15611);
		}
		internal static global::MonoJavaBridge.MethodId _getZAdjustment15612;
		public virtual int getZAdjustment()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I", ref global::android.view.animation.Animation._getZAdjustment15612);
		}
		internal static global::MonoJavaBridge.MethodId _getDetachWallpaper15613;
		public virtual bool getDetachWallpaper()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z", ref global::android.view.animation.Animation._getDetachWallpaper15613);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix15614;
		public virtual bool willChangeTransformationMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z", ref global::android.view.animation.Animation._willChangeTransformationMatrix15614);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds15615;
		public virtual bool willChangeBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z", ref global::android.view.animation.Animation._willChangeBounds15615);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationListener15616;
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V", ref global::android.view.animation.Animation._setAnimationListener15616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ensureInterpolator15617;
		protected virtual void ensureInterpolator()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V", ref global::android.view.animation.Animation._ensureInterpolator15617);
		}
		internal static global::MonoJavaBridge.MethodId _computeDurationHint15618;
		public virtual long computeDurationHint()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J", ref global::android.view.animation.Animation._computeDurationHint15618);
		}
		internal static global::MonoJavaBridge.MethodId _getTransformation15619;
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z", ref global::android.view.animation.Animation._getTransformation15619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasStarted15620;
		public virtual bool hasStarted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "hasStarted", "()Z", ref global::android.view.animation.Animation._hasStarted15620);
		}
		internal static global::MonoJavaBridge.MethodId _hasEnded15621;
		public virtual bool hasEnded()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.Animation.staticClass, "hasEnded", "()Z", ref global::android.view.animation.Animation._hasEnded15621);
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation15622;
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V", ref global::android.view.animation.Animation._applyTransformation15622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Animation15623;
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.Animation._Animation15623.native == global::System.IntPtr.Zero)
				global::android.view.animation.Animation._Animation15623 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation15623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Animation15624;
		public Animation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.Animation._Animation15624.native == global::System.IntPtr.Zero)
				global::android.view.animation.Animation._Animation15624 = @__env.GetMethodIDNoThrow(global::android.view.animation.Animation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Animation.staticClass, global::android.view.animation.Animation._Animation15624);
			Init(@__env, handle);
		}
		public static int INFINITE
		{
			get
			{
				return -1;
			}
		}
		public static int RESTART
		{
			get
			{
				return 1;
			}
		}
		public static int REVERSE
		{
			get
			{
				return 2;
			}
		}
		public static int START_ON_FIRST_FRAME
		{
			get
			{
				return -1;
			}
		}
		public static int ABSOLUTE
		{
			get
			{
				return 0;
			}
		}
		public static int RELATIVE_TO_SELF
		{
			get
			{
				return 1;
			}
		}
		public static int RELATIVE_TO_PARENT
		{
			get
			{
				return 2;
			}
		}
		public static int ZORDER_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int ZORDER_TOP
		{
			get
			{
				return 1;
			}
		}
		public static int ZORDER_BOTTOM
		{
			get
			{
				return -1;
			}
		}
		static Animation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Animation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Animation))]
	internal sealed partial class Animation_ : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Animation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Animation_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Animation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Animation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
