namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Double : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Double(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20088;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Double.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Double._equals20088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20089;
		public static global::java.lang.String toString(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._toString20089.native == global::System.IntPtr.Zero)
				global::java.lang.Double._toString20089 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toString", "(D)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._toString20089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20090;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Double.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Double._toString20090) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20091;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Double.staticClass, "hashCode", "()I", ref global::java.lang.Double._hashCode20091);
		}
		internal static global::MonoJavaBridge.MethodId _doubleToRawLongBits20092;
		public static long doubleToRawLongBits(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._doubleToRawLongBits20092.native == global::System.IntPtr.Zero)
				global::java.lang.Double._doubleToRawLongBits20092 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToRawLongBits", "(D)J");
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._doubleToRawLongBits20092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doubleToLongBits20093;
		public static long doubleToLongBits(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._doubleToLongBits20093.native == global::System.IntPtr.Zero)
				global::java.lang.Double._doubleToLongBits20093 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToLongBits", "(D)J");
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._doubleToLongBits20093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _longBitsToDouble20094;
		public static double longBitsToDouble(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._longBitsToDouble20094.native == global::System.IntPtr.Zero)
				global::java.lang.Double._longBitsToDouble20094 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "longBitsToDouble", "(J)D");
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._longBitsToDouble20094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20095;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Double._compareTo20095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20096;
		public int compareTo(java.lang.Double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Double;)I", ref global::java.lang.Double._compareTo20096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString20097;
		public static global::java.lang.String toHexString(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._toHexString20097.native == global::System.IntPtr.Zero)
				global::java.lang.Double._toHexString20097 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toHexString", "(D)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._toHexString20097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20098;
		public static global::java.lang.Double valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._valueOf20098.native == global::System.IntPtr.Zero)
				global::java.lang.Double._valueOf20098 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Double>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._valueOf20098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20099;
		public static global::java.lang.Double valueOf(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._valueOf20099.native == global::System.IntPtr.Zero)
				global::java.lang.Double._valueOf20099 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(D)Ljava/lang/Double;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Double>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._valueOf20099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _compare20100;
		public static int compare(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._compare20100.native == global::System.IntPtr.Zero)
				global::java.lang.Double._compare20100 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "compare", "(DD)I");
			return @__env.CallStaticIntMethod(java.lang.Double.staticClass, global::java.lang.Double._compare20100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN20101;
		public bool isNaN()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Double.staticClass, "isNaN", "()Z", ref global::java.lang.Double._isNaN20101);
		}
		internal static global::MonoJavaBridge.MethodId _isNaN20102;
		public static bool isNaN(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._isNaN20102.native == global::System.IntPtr.Zero)
				global::java.lang.Double._isNaN20102 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isNaN", "(D)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._isNaN20102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite20103;
		public static bool isInfinite(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._isInfinite20103.native == global::System.IntPtr.Zero)
				global::java.lang.Double._isInfinite20103 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isInfinite", "(D)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._isInfinite20103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite20104;
		public bool isInfinite()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Double.staticClass, "isInfinite", "()Z", ref global::java.lang.Double._isInfinite20104);
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20105;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Double.staticClass, "byteValue", "()B", ref global::java.lang.Double._byteValue20105);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20106;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Double.staticClass, "shortValue", "()S", ref global::java.lang.Double._shortValue20106);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20107;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Double.staticClass, "intValue", "()I", ref global::java.lang.Double._intValue20107);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20108;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Double.staticClass, "longValue", "()J", ref global::java.lang.Double._longValue20108);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20109;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Double.staticClass, "floatValue", "()F", ref global::java.lang.Double._floatValue20109);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20110;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Double.staticClass, "doubleValue", "()D", ref global::java.lang.Double._doubleValue20110);
		}
		internal static global::MonoJavaBridge.MethodId _parseDouble20111;
		public static double parseDouble(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._parseDouble20111.native == global::System.IntPtr.Zero)
				global::java.lang.Double._parseDouble20111 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "parseDouble", "(Ljava/lang/String;)D");
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._parseDouble20111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Double20112;
		public Double(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._Double20112.native == global::System.IntPtr.Zero)
				global::java.lang.Double._Double20112 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(D)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._Double20112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Double20113;
		public Double(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._Double20113.native == global::System.IntPtr.Zero)
				global::java.lang.Double._Double20113 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._Double20113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Double()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Double.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Double"));
		}
		internal static void InitJNI()
		{
		}
	}
}
