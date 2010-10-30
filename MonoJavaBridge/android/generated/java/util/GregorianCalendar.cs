namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GregorianCalendar : java.util.Calendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GregorianCalendar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26213;
		public override void add(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "add", "(II)V", ref global::java.util.GregorianCalendar._add26213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals26214;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.GregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.GregorianCalendar._equals26214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26215;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "hashCode", "()I", ref global::java.util.GregorianCalendar._hashCode26215);
		}
		internal static global::MonoJavaBridge.MethodId _clone26216;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.GregorianCalendar.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.GregorianCalendar._clone26216) as java.lang.Object;
		}
		public new global::java.util.TimeZone TimeZone
		{
			get
			{
				return getTimeZone();
			}
			set
			{
				setTimeZone(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone26217;
		public override global::java.util.TimeZone getTimeZone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.GregorianCalendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;", ref global::java.util.GregorianCalendar._getTimeZone26217) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone26218;
		public override void setTimeZone(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V", ref global::java.util.GregorianCalendar._setTimeZone26218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLeapYear26219;
		public virtual bool isLeapYear(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.GregorianCalendar.staticClass, "isLeapYear", "(I)Z", ref global::java.util.GregorianCalendar._isLeapYear26219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeTime26220;
		protected override void computeTime()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "computeTime", "()V", ref global::java.util.GregorianCalendar._computeTime26220);
		}
		internal static global::MonoJavaBridge.MethodId _computeFields26221;
		protected override void computeFields()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "computeFields", "()V", ref global::java.util.GregorianCalendar._computeFields26221);
		}
		internal static global::MonoJavaBridge.MethodId _roll26222;
		public override void roll(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "roll", "(II)V", ref global::java.util.GregorianCalendar._roll26222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roll26223;
		public override void roll(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "roll", "(IZ)V", ref global::java.util.GregorianCalendar._roll26223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum26224;
		public override int getMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getMinimum", "(I)I", ref global::java.util.GregorianCalendar._getMinimum26224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximum26225;
		public override int getMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getMaximum", "(I)I", ref global::java.util.GregorianCalendar._getMaximum26225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum26226;
		public override int getGreatestMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getGreatestMinimum", "(I)I", ref global::java.util.GregorianCalendar._getGreatestMinimum26226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum26227;
		public override int getLeastMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getLeastMaximum", "(I)I", ref global::java.util.GregorianCalendar._getLeastMaximum26227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMinimum26228;
		public override int getActualMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getActualMinimum", "(I)I", ref global::java.util.GregorianCalendar._getActualMinimum26228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum26229;
		public override int getActualMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getActualMaximum", "(I)I", ref global::java.util.GregorianCalendar._getActualMaximum26229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGregorianChange26230;
		public virtual void setGregorianChange(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "setGregorianChange", "(Ljava/util/Date;)V", ref global::java.util.GregorianCalendar._setGregorianChange26230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Date GregorianChange
		{
			get
			{
				return getGregorianChange();
			}
			set
			{
				setGregorianChange(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGregorianChange26231;
		public virtual global::java.util.Date getGregorianChange()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.GregorianCalendar.staticClass, "getGregorianChange", "()Ljava/util/Date;", ref global::java.util.GregorianCalendar._getGregorianChange26231) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26232;
		public GregorianCalendar() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._GregorianCalendar26232.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._GregorianCalendar26232 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26232);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26233;
		public GregorianCalendar(java.util.TimeZone arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._GregorianCalendar26233.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._GregorianCalendar26233 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26234;
		public GregorianCalendar(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._GregorianCalendar26234.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._GregorianCalendar26234 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26235;
		public GregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._GregorianCalendar26235.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._GregorianCalendar26235 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26236;
		public GregorianCalendar(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._GregorianCalendar26236.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._GregorianCalendar26236 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26237;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._GregorianCalendar26237.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._GregorianCalendar26237 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GregorianCalendar26238;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._GregorianCalendar26238.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._GregorianCalendar26238 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._GregorianCalendar26238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		public static int BC
		{
			get
			{
				return 0;
			}
		}
		public static int AD
		{
			get
			{
				return 1;
			}
		}
		static GregorianCalendar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.GregorianCalendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/GregorianCalendar"));
		}
		internal static void InitJNI()
		{
		}
	}
}
