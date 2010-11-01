namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.datatype.DatatypeFactory_))]
	public abstract partial class DatatypeFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatatypeFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.xml.datatype.DatatypeFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/datatype/DatatypeFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.datatype.DatatypeFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.xml.datatype.DatatypeFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeFactory._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newInstance", "()Ljavax/xml/datatype/DatatypeFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._m1)) as javax.xml.datatype.DatatypeFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::javax.xml.datatype.Duration newDuration(long arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::javax.xml.datatype.Duration newDuration(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigDecimal arg6);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::javax.xml.datatype.Duration newDuration(bool arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(ZIIIIII)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::javax.xml.datatype.Duration newDuration(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(J)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(ZIIII)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(J)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(bool arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(ZII)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.util.GregorianCalendar arg0);
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.math.BigDecimal arg6, int arg7);
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(IIIIIIII)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar();
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarDate(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarDate", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, java.math.BigDecimal arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIIII)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected DatatypeFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeFactory._m23.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeFactory._m23 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._m23);
			Init(@__env, handle);
		}
		public static global::java.lang.String DATATYPEFACTORY_PROPERTY
		{
			get
			{
				return "javax.xml.datatype.DatatypeFactory";
			}
		}
		public static global::java.lang.String DATATYPEFACTORY_IMPLEMENTATION_CLASS
		{
			get
			{
				return "com.sun.org.apache.xerces.internal.jaxp.datatype.DatatypeFactoryImpl";
			}
		}
		static DatatypeFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeFactory"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.DatatypeFactory))]
	internal sealed partial class DatatypeFactory_ : javax.xml.datatype.DatatypeFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatatypeFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::javax.xml.datatype.Duration newDuration(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(J)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::javax.xml.datatype.Duration newDuration(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigDecimal arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::javax.xml.datatype.Duration newDuration(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/lang/String;)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.util.GregorianCalendar arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/util/GregorianCalendar;)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.math.BigDecimal arg6, int arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/math/BigInteger;IIIIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory_._m6) as javax.xml.datatype.XMLGregorianCalendar;
		}
		static DatatypeFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeFactory"));
		}
	}
}