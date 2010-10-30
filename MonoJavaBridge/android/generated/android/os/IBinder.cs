namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.IBinder_))]
	public partial interface IBinder  : global::MonoJavaBridge.IJavaObject 
	{
		void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1);
		global::java.lang.String getInterfaceDescriptor();
		bool pingBinder();
		bool isBinderAlive();
		global::android.os.IInterface queryLocalInterface(java.lang.String arg0);
		bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3);
		void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1);
		bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.IBinder))]
	internal sealed partial class IBinder_ : java.lang.Object, IBinder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IBinder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dump9897;
		void android.os.IBinder.dump(java.io.FileDescriptor arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.IBinder_.staticClass, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", ref global::android.os.IBinder_._dump9897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceDescriptor9898;
		global::java.lang.String android.os.IBinder.getInterfaceDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.IBinder_.staticClass, "getInterfaceDescriptor", "()Ljava/lang/String;", ref global::android.os.IBinder_._getInterfaceDescriptor9898) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pingBinder9899;
		bool android.os.IBinder.pingBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.IBinder_.staticClass, "pingBinder", "()Z", ref global::android.os.IBinder_._pingBinder9899);
		}
		internal static global::MonoJavaBridge.MethodId _isBinderAlive9900;
		bool android.os.IBinder.isBinderAlive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.IBinder_.staticClass, "isBinderAlive", "()Z", ref global::android.os.IBinder_._isBinderAlive9900);
		}
		internal static global::MonoJavaBridge.MethodId _queryLocalInterface9901;
		global::android.os.IInterface android.os.IBinder.queryLocalInterface(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IInterface>(this, global::android.os.IBinder_.staticClass, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;", ref global::android.os.IBinder_._queryLocalInterface9901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IInterface;
		}
		internal static global::MonoJavaBridge.MethodId _transact9902;
		bool android.os.IBinder.transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.IBinder_.staticClass, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", ref global::android.os.IBinder_._transact9902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _linkToDeath9903;
		void android.os.IBinder.linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.IBinder_.staticClass, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V", ref global::android.os.IBinder_._linkToDeath9903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unlinkToDeath9904;
		bool android.os.IBinder.unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.IBinder_.staticClass, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z", ref global::android.os.IBinder_._unlinkToDeath9904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static IBinder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IBinder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
