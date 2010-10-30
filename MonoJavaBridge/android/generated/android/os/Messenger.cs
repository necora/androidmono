namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Messenger : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Messenger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals9966;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Messenger.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.os.Messenger._equals9966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode9967;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Messenger.staticClass, "hashCode", "()I", ref global::android.os.Messenger._hashCode9967);
		}
		internal static global::MonoJavaBridge.MethodId _send9968;
		public void send(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Messenger.staticClass, "send", "(Landroid/os/Message;)V", ref global::android.os.Messenger._send9968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9969;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Messenger.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.Messenger._writeToParcel9969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9970;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Messenger.staticClass, "describeContents", "()I", ref global::android.os.Messenger._describeContents9970);
		}
		public new global::android.os.IBinder Binder
		{
			get
			{
				return getBinder();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinder9971;
		public global::android.os.IBinder getBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.os.Messenger.staticClass, "getBinder", "()Landroid/os/IBinder;", ref global::android.os.Messenger._getBinder9971) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _writeMessengerOrNullToParcel9972;
		public static void writeMessengerOrNullToParcel(android.os.Messenger arg0, android.os.Parcel arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Messenger._writeMessengerOrNullToParcel9972.native == global::System.IntPtr.Zero)
				global::android.os.Messenger._writeMessengerOrNullToParcel9972 = @__env.GetStaticMethodIDNoThrow(global::android.os.Messenger.staticClass, "writeMessengerOrNullToParcel", "(Landroid/os/Messenger;Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.os.Messenger.staticClass, global::android.os.Messenger._writeMessengerOrNullToParcel9972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readMessengerOrNullFromParcel9973;
		public static global::android.os.Messenger readMessengerOrNullFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Messenger._readMessengerOrNullFromParcel9973.native == global::System.IntPtr.Zero)
				global::android.os.Messenger._readMessengerOrNullFromParcel9973 = @__env.GetStaticMethodIDNoThrow(global::android.os.Messenger.staticClass, "readMessengerOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/os/Messenger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Messenger>(@__env.CallStaticObjectMethod(android.os.Messenger.staticClass, global::android.os.Messenger._readMessengerOrNullFromParcel9973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Messenger;
		}
		internal static global::MonoJavaBridge.MethodId _Messenger9974;
		public Messenger(android.os.Handler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Messenger._Messenger9974.native == global::System.IntPtr.Zero)
				global::android.os.Messenger._Messenger9974 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "<init>", "(Landroid/os/Handler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Messenger.staticClass, global::android.os.Messenger._Messenger9974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Messenger9975;
		public Messenger(android.os.IBinder arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Messenger._Messenger9975.native == global::System.IntPtr.Zero)
				global::android.os.Messenger._Messenger9975 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "<init>", "(Landroid/os/IBinder;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Messenger.staticClass, global::android.os.Messenger._Messenger9975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR9976;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Messenger.staticClass, _CREATOR9976)) as android.os.Parcelable_Creator;
			}
		}
		static Messenger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Messenger.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Messenger"));
			global::android.os.Messenger._CREATOR9976 = @__env.GetStaticFieldIDNoThrow(global::android.os.Messenger.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
