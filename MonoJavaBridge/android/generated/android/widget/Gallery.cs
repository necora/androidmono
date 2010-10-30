namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Gallery : android.widget.AbsSpinner, android.view.GestureDetector.OnGestureListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Gallery(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17116;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Gallery.LayoutParams._LayoutParams17116.native == global::System.IntPtr.Zero)
					global::android.widget.Gallery.LayoutParams._LayoutParams17116 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams17116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17117;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Gallery.LayoutParams._LayoutParams17117.native == global::System.IntPtr.Zero)
					global::android.widget.Gallery.LayoutParams._LayoutParams17117 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams17117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17118;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Gallery.LayoutParams._LayoutParams17118.native == global::System.IntPtr.Zero)
					global::android.widget.Gallery.LayoutParams._LayoutParams17118 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._LayoutParams17118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Gallery.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Gallery$LayoutParams"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown17119;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.Gallery._onKeyDown17119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp17120;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.Gallery._onKeyUp17120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17121;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.Gallery._onTouchEvent17121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17122;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.widget.Gallery._dispatchKeyEvent17122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Gravity
		{
			set
			{
				setGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGravity17123;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setGravity", "(I)V", ref global::android.widget.Gallery._setGravity17123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenu17124;
		public override bool showContextMenu()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "showContextMenu", "()Z", ref global::android.widget.Gallery._showContextMenu17124);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged17125;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.Gallery._onFocusChanged17125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed17126;
		protected override void dispatchSetPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "dispatchSetPressed", "(Z)V", ref global::android.widget.Gallery._dispatchSetPressed17126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.ContextMenu_ContextMenuInfo ContextMenuInfo
		{
			get
			{
				return getContextMenuInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo17127;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu_ContextMenuInfo>(this, global::android.widget.Gallery.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", ref global::android.widget.Gallery._getContextMenuInfo17127) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange17128;
		protected override int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Gallery.staticClass, "computeHorizontalScrollRange", "()I", ref global::android.widget.Gallery._computeHorizontalScrollRange17128);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset17129;
		protected override int computeHorizontalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Gallery.staticClass, "computeHorizontalScrollOffset", "()I", ref global::android.widget.Gallery._computeHorizontalScrollOffset17129);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollExtent17130;
		protected override int computeHorizontalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Gallery.staticClass, "computeHorizontalScrollExtent", "()I", ref global::android.widget.Gallery._computeHorizontalScrollExtent17130);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17131;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.Gallery._onLayout17131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected17132;
		public override void dispatchSetSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "dispatchSetSelected", "(Z)V", ref global::android.widget.Gallery._dispatchSetSelected17132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild17133;
		public override bool showContextMenuForChild(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z", ref global::android.widget.Gallery._showContextMenuForChild17133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder17134;
		protected override int getChildDrawingOrder(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Gallery.staticClass, "getChildDrawingOrder", "(II)I", ref global::android.widget.Gallery._getChildDrawingOrder17134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildStaticTransformation17135;
		protected override bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z", ref global::android.widget.Gallery._getChildStaticTransformation17135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17136;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.Gallery._checkLayoutParams17136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17137;
		public override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.Gallery._generateLayoutParams17137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17138;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.Gallery._generateLayoutParams17138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17139;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Gallery.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.Gallery._generateDefaultLayoutParams17139) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _onLongPress17140;
		public virtual void onLongPress(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V", ref global::android.widget.Gallery._onLongPress17140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSingleTapUp17141;
		public virtual bool onSingleTapUp(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.Gallery._onSingleTapUp17141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onScroll17142;
		public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", ref global::android.widget.Gallery._onScroll17142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onFling17143;
		public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", ref global::android.widget.Gallery._onFling17143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onShowPress17144;
		public virtual void onShowPress(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V", ref global::android.widget.Gallery._onShowPress17144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDown17145;
		public virtual bool onDown(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.Gallery._onDown17145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CallbackDuringFling
		{
			set
			{
				setCallbackDuringFling(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCallbackDuringFling17146;
		public virtual void setCallbackDuringFling(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setCallbackDuringFling", "(Z)V", ref global::android.widget.Gallery._setCallbackDuringFling17146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AnimationDuration
		{
			set
			{
				setAnimationDuration(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationDuration17147;
		public virtual void setAnimationDuration(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setAnimationDuration", "(I)V", ref global::android.widget.Gallery._setAnimationDuration17147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Spacing
		{
			set
			{
				setSpacing(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSpacing17148;
		public virtual void setSpacing(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setSpacing", "(I)V", ref global::android.widget.Gallery._setSpacing17148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float UnselectedAlpha
		{
			set
			{
				setUnselectedAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setUnselectedAlpha17149;
		public virtual void setUnselectedAlpha(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setUnselectedAlpha", "(F)V", ref global::android.widget.Gallery._setUnselectedAlpha17149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Gallery17150;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Gallery._Gallery17150.native == global::System.IntPtr.Zero)
				global::android.widget.Gallery._Gallery17150 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery17150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Gallery17151;
		public Gallery(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Gallery._Gallery17151.native == global::System.IntPtr.Zero)
				global::android.widget.Gallery._Gallery17151 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery17151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Gallery17152;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Gallery._Gallery17152.native == global::System.IntPtr.Zero)
				global::android.widget.Gallery._Gallery17152 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._Gallery17152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Gallery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Gallery.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Gallery"));
		}
		internal static void InitJNI()
		{
		}
	}
}
