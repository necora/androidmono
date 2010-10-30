namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BigInteger : java.lang.Number, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BigInteger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add21252;
		public virtual global::java.math.BigInteger add(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._add21252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _bitCount21253;
		public virtual int bitCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "bitCount", "()I", ref global::java.math.BigInteger._bitCount21253);
		}
		internal static global::MonoJavaBridge.MethodId _equals21254;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.BigInteger.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.math.BigInteger._equals21254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21255;
		public virtual global::java.lang.String toString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigInteger.staticClass, "toString", "(I)Ljava/lang/String;", ref global::java.math.BigInteger._toString21255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString21256;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigInteger.staticClass, "toString", "()Ljava/lang/String;", ref global::java.math.BigInteger._toString21256) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21257;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "hashCode", "()I", ref global::java.math.BigInteger._hashCode21257);
		}
		internal static global::MonoJavaBridge.MethodId _abs21258;
		public virtual global::java.math.BigInteger abs()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "abs", "()Ljava/math/BigInteger;", ref global::java.math.BigInteger._abs21258) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _pow21259;
		public virtual global::java.math.BigInteger pow(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "pow", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._pow21259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _min21260;
		public virtual global::java.math.BigInteger min(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._min21260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _max21261;
		public virtual global::java.math.BigInteger max(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._max21261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21262;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.math.BigInteger._compareTo21262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21263;
		public virtual int compareTo(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/math/BigInteger;)I", ref global::java.math.BigInteger._compareTo21263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21264;
		public static global::java.math.BigInteger valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._valueOf21264.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._valueOf21264 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigInteger.staticClass, "valueOf", "(J)Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigInteger.staticClass, global::java.math.BigInteger._valueOf21264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _intValue21265;
		public override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "intValue", "()I", ref global::java.math.BigInteger._intValue21265);
		}
		internal static global::MonoJavaBridge.MethodId _longValue21266;
		public override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.math.BigInteger.staticClass, "longValue", "()J", ref global::java.math.BigInteger._longValue21266);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue21267;
		public override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.math.BigInteger.staticClass, "floatValue", "()F", ref global::java.math.BigInteger._floatValue21267);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue21268;
		public override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.math.BigInteger.staticClass, "doubleValue", "()D", ref global::java.math.BigInteger._doubleValue21268);
		}
		internal static global::MonoJavaBridge.MethodId _signum21269;
		public virtual int signum()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "signum", "()I", ref global::java.math.BigInteger._signum21269);
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray21270;
		public virtual byte[] toByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.math.BigInteger.staticClass, "toByteArray", "()[B", ref global::java.math.BigInteger._toByteArray21270) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _and21271;
		public virtual global::java.math.BigInteger and(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._and21271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _or21272;
		public virtual global::java.math.BigInteger or(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._or21272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _xor21273;
		public virtual global::java.math.BigInteger xor(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._xor21273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _andNot21274;
		public virtual global::java.math.BigInteger andNot(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._andNot21274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _bitLength21275;
		public virtual int bitLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "bitLength", "()I", ref global::java.math.BigInteger._bitLength21275);
		}
		internal static global::MonoJavaBridge.MethodId _probablePrime21276;
		public static global::java.math.BigInteger probablePrime(int arg0, java.util.Random arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._probablePrime21276.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._probablePrime21276 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigInteger.staticClass, "probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigInteger.staticClass, global::java.math.BigInteger._probablePrime21276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _nextProbablePrime21277;
		public virtual global::java.math.BigInteger nextProbablePrime()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "nextProbablePrime", "()Ljava/math/BigInteger;", ref global::java.math.BigInteger._nextProbablePrime21277) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _subtract21278;
		public virtual global::java.math.BigInteger subtract(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._subtract21278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _multiply21279;
		public virtual global::java.math.BigInteger multiply(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._multiply21279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _divide21280;
		public virtual global::java.math.BigInteger divide(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._divide21280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder21281;
		public virtual global::java.math.BigInteger[] divideAndRemainder(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.math.BigInteger>(this, global::java.math.BigInteger.staticClass, "divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;", ref global::java.math.BigInteger._divideAndRemainder21281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger[];
		}
		internal static global::MonoJavaBridge.MethodId _remainder21282;
		public virtual global::java.math.BigInteger remainder(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._remainder21282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _gcd21283;
		public virtual global::java.math.BigInteger gcd(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._gcd21283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _negate21284;
		public virtual global::java.math.BigInteger negate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "negate", "()Ljava/math/BigInteger;", ref global::java.math.BigInteger._negate21284) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _mod21285;
		public virtual global::java.math.BigInteger mod(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._mod21285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _modPow21286;
		public virtual global::java.math.BigInteger modPow(java.math.BigInteger arg0, java.math.BigInteger arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._modPow21286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _modInverse21287;
		public virtual global::java.math.BigInteger modInverse(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._modInverse21287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _shiftLeft21288;
		public virtual global::java.math.BigInteger shiftLeft(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "shiftLeft", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._shiftLeft21288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _shiftRight21289;
		public virtual global::java.math.BigInteger shiftRight(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "shiftRight", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._shiftRight21289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _not21290;
		public virtual global::java.math.BigInteger not()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "not", "()Ljava/math/BigInteger;", ref global::java.math.BigInteger._not21290) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _testBit21291;
		public virtual bool testBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.BigInteger.staticClass, "testBit", "(I)Z", ref global::java.math.BigInteger._testBit21291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Bit
		{
			set
			{
				setBit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBit21292;
		public virtual global::java.math.BigInteger setBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "setBit", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._setBit21292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _clearBit21293;
		public virtual global::java.math.BigInteger clearBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "clearBit", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._clearBit21293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _flipBit21294;
		public virtual global::java.math.BigInteger flipBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "flipBit", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._flipBit21294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		public new int LowestSetBit
		{
			get
			{
				return getLowestSetBit();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLowestSetBit21295;
		public virtual int getLowestSetBit()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "getLowestSetBit", "()I", ref global::java.math.BigInteger._getLowestSetBit21295);
		}
		internal static global::MonoJavaBridge.MethodId _isProbablePrime21296;
		public virtual bool isProbablePrime(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.BigInteger.staticClass, "isProbablePrime", "(I)Z", ref global::java.math.BigInteger._isProbablePrime21296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21297;
		public BigInteger(int arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._BigInteger21297.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._BigInteger21297 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(I[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21298;
		public BigInteger(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._BigInteger21298.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._BigInteger21298 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21299;
		public BigInteger(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._BigInteger21299.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._BigInteger21299 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21300;
		public BigInteger(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._BigInteger21300.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._BigInteger21300 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21301;
		public BigInteger(int arg0, java.util.Random arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._BigInteger21301.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._BigInteger21301 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(ILjava/util/Random;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21302;
		public BigInteger(int arg0, int arg1, java.util.Random arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._BigInteger21302.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._BigInteger21302 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(IILjava/util/Random;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO21303;
		public static global::java.math.BigInteger ZERO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _ZERO21303)) as java.math.BigInteger;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE21304;
		public static global::java.math.BigInteger ONE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _ONE21304)) as java.math.BigInteger;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN21305;
		public static global::java.math.BigInteger TEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _TEN21305)) as java.math.BigInteger;
			}
		}
		static BigInteger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.BigInteger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/BigInteger"));
			global::java.math.BigInteger._ZERO21303 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "ZERO", "Ljava/math/BigInteger;");
			global::java.math.BigInteger._ONE21304 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "ONE", "Ljava/math/BigInteger;");
			global::java.math.BigInteger._TEN21305 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "TEN", "Ljava/math/BigInteger;");
		}
		internal static void InitJNI()
		{
		}
	}
}
