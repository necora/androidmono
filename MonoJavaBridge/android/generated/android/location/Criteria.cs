namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Criteria : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Criteria(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6840;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.location.Criteria._writeToParcel6840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6841;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Criteria.staticClass, "describeContents", "()I", ref global::android.location.Criteria._describeContents6841);
		}
		internal static global::MonoJavaBridge.MethodId _setAccuracy6842;
		public virtual void setAccuracy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setAccuracy", "(I)V", ref global::android.location.Criteria._setAccuracy6842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Accuracy
		{
			get
			{
				return getAccuracy();
			}
			set
			{
				setAccuracy(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAccuracy6843;
		public virtual int getAccuracy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Criteria.staticClass, "getAccuracy", "()I", ref global::android.location.Criteria._getAccuracy6843);
		}
		internal static global::MonoJavaBridge.MethodId _setPowerRequirement6844;
		public virtual void setPowerRequirement(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setPowerRequirement", "(I)V", ref global::android.location.Criteria._setPowerRequirement6844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int PowerRequirement
		{
			get
			{
				return getPowerRequirement();
			}
			set
			{
				setPowerRequirement(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement6845;
		public virtual int getPowerRequirement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Criteria.staticClass, "getPowerRequirement", "()I", ref global::android.location.Criteria._getPowerRequirement6845);
		}
		public new bool CostAllowed
		{
			set
			{
				setCostAllowed(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCostAllowed6846;
		public virtual void setCostAllowed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setCostAllowed", "(Z)V", ref global::android.location.Criteria._setCostAllowed6846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCostAllowed6847;
		public virtual bool isCostAllowed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Criteria.staticClass, "isCostAllowed", "()Z", ref global::android.location.Criteria._isCostAllowed6847);
		}
		public new bool AltitudeRequired
		{
			set
			{
				setAltitudeRequired(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAltitudeRequired6848;
		public virtual void setAltitudeRequired(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setAltitudeRequired", "(Z)V", ref global::android.location.Criteria._setAltitudeRequired6848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAltitudeRequired6849;
		public virtual bool isAltitudeRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Criteria.staticClass, "isAltitudeRequired", "()Z", ref global::android.location.Criteria._isAltitudeRequired6849);
		}
		public new bool SpeedRequired
		{
			set
			{
				setSpeedRequired(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSpeedRequired6850;
		public virtual void setSpeedRequired(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setSpeedRequired", "(Z)V", ref global::android.location.Criteria._setSpeedRequired6850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpeedRequired6851;
		public virtual bool isSpeedRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Criteria.staticClass, "isSpeedRequired", "()Z", ref global::android.location.Criteria._isSpeedRequired6851);
		}
		public new bool BearingRequired
		{
			set
			{
				setBearingRequired(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBearingRequired6852;
		public virtual void setBearingRequired(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setBearingRequired", "(Z)V", ref global::android.location.Criteria._setBearingRequired6852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBearingRequired6853;
		public virtual bool isBearingRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Criteria.staticClass, "isBearingRequired", "()Z", ref global::android.location.Criteria._isBearingRequired6853);
		}
		internal static global::MonoJavaBridge.MethodId _Criteria6854;
		public Criteria() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Criteria._Criteria6854.native == global::System.IntPtr.Zero)
				global::android.location.Criteria._Criteria6854 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria6854);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Criteria6855;
		public Criteria(android.location.Criteria arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Criteria._Criteria6855.native == global::System.IntPtr.Zero)
				global::android.location.Criteria._Criteria6855 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "<init>", "(Landroid/location/Criteria;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria6855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int NO_REQUIREMENT
		{
			get
			{
				return 0;
			}
		}
		public static int POWER_LOW
		{
			get
			{
				return 1;
			}
		}
		public static int POWER_MEDIUM
		{
			get
			{
				return 2;
			}
		}
		public static int POWER_HIGH
		{
			get
			{
				return 3;
			}
		}
		public static int ACCURACY_FINE
		{
			get
			{
				return 1;
			}
		}
		public static int ACCURACY_COARSE
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR6862;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Criteria.staticClass, _CREATOR6862)) as android.os.Parcelable_Creator;
			}
		}
		static Criteria()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Criteria.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Criteria"));
			global::android.location.Criteria._CREATOR6862 = @__env.GetStaticFieldIDNoThrow(global::android.location.Criteria.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
