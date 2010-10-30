namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NinePatchDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NinePatchDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate6116;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.NinePatchDrawable._inflate6116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw6117;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.NinePatchDrawable._draw6117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations6118;
		public override int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.NinePatchDrawable._getChangingConfigurations6118);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDither6119;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.NinePatchDrawable._setDither6119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FilterBitmap
		{
			set
			{
				setFilterBitmap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap6120;
		public override void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setFilterBitmap", "(Z)V", ref global::android.graphics.drawable.NinePatchDrawable._setFilterBitmap6120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6121;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.NinePatchDrawable._setAlpha6121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6122;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.NinePatchDrawable._setColorFilter6122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6123;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.NinePatchDrawable._getOpacity6123);
		}
		public new global::android.graphics.Region TransparentRegion
		{
			get
			{
				return getTransparentRegion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTransparentRegion6124;
		public override global::android.graphics.Region getTransparentRegion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;", ref global::android.graphics.drawable.NinePatchDrawable._getTransparentRegion6124) as android.graphics.Region;
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6125;
		public override int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.NinePatchDrawable._getIntrinsicWidth6125);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6126;
		public override int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.NinePatchDrawable._getIntrinsicHeight6126);
		}
		public new int MinimumWidth
		{
			get
			{
				return getMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumWidth6127;
		public override int getMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getMinimumWidth", "()I", ref global::android.graphics.drawable.NinePatchDrawable._getMinimumWidth6127);
		}
		public new int MinimumHeight
		{
			get
			{
				return getMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeight6128;
		public override int getMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getMinimumHeight", "()I", ref global::android.graphics.drawable.NinePatchDrawable._getMinimumHeight6128);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6129;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.drawable.NinePatchDrawable._getPadding6129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6130;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.NinePatchDrawable._mutate6130) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState6131;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.NinePatchDrawable._getConstantState6131) as android.graphics.drawable.Drawable.ConstantState;
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint6132;
		public virtual global::android.graphics.Paint getPaint()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;", ref global::android.graphics.drawable.NinePatchDrawable._getPaint6132) as android.graphics.Paint;
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity6133;
		public virtual void setTargetDensity(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.NinePatchDrawable._setTargetDensity6133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity6134;
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V", ref global::android.graphics.drawable.NinePatchDrawable._setTargetDensity6134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity6135;
		public virtual void setTargetDensity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(I)V", ref global::android.graphics.drawable.NinePatchDrawable._setTargetDensity6135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NinePatchDrawable6136;
		public NinePatchDrawable(android.content.res.Resources arg0, android.graphics.NinePatch arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6136.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6136 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/NinePatch;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NinePatchDrawable6137;
		public NinePatchDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1, byte[] arg2, android.graphics.Rect arg3, java.lang.String arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6137.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6137 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NinePatchDrawable6138;
		public NinePatchDrawable(android.graphics.NinePatch arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6138.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6138 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/graphics/NinePatch;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NinePatchDrawable6139;
		public NinePatchDrawable(android.graphics.Bitmap arg0, byte[] arg1, android.graphics.Rect arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6139.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6139 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable6139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static NinePatchDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.NinePatchDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/NinePatchDrawable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
