namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class InputMethodInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputMethodInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals15928;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.inputmethod.InputMethodInfo._equals15928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15929;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._toString15929) as java.lang.String;
		}
		public new global::java.lang.String Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId15930;
		public global::java.lang.String getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getId", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._getId15930) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName15931;
		public global::java.lang.String getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._getPackageName15931) as java.lang.String;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponent15932;
		public global::android.content.ComponentName getComponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;", ref global::android.view.inputmethod.InputMethodInfo._getComponent15932) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _dump15933;
		public void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.view.inputmethod.InputMethodInfo._dump15933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15934;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.inputmethod.InputMethodInfo._writeToParcel15934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15935;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "describeContents", "()I", ref global::android.view.inputmethod.InputMethodInfo._describeContents15935);
		}
		public new global::android.content.pm.ServiceInfo ServiceInfo
		{
			get
			{
				return getServiceInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo15936;
		public global::android.content.pm.ServiceInfo getServiceInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;", ref global::android.view.inputmethod.InputMethodInfo._getServiceInfo15936) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel15937;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.InputMethodInfo._loadLabel15937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon15938;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", ref global::android.view.inputmethod.InputMethodInfo._loadIcon15938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String ServiceName
		{
			get
			{
				return getServiceName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceName15939;
		public global::java.lang.String getServiceName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getServiceName", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._getServiceName15939) as java.lang.String;
		}
		public new global::java.lang.String SettingsActivity
		{
			get
			{
				return getSettingsActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettingsActivity15940;
		public global::java.lang.String getSettingsActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputMethodInfo._getSettingsActivity15940) as java.lang.String;
		}
		public new int IsDefaultResourceId
		{
			get
			{
				return getIsDefaultResourceId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIsDefaultResourceId15941;
		public int getIsDefaultResourceId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputMethodInfo.staticClass, "getIsDefaultResourceId", "()I", ref global::android.view.inputmethod.InputMethodInfo._getIsDefaultResourceId15941);
		}
		internal static global::MonoJavaBridge.MethodId _InputMethodInfo15942;
		public InputMethodInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15942.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15942 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputMethodInfo15943;
		public InputMethodInfo(java.lang.String arg0, java.lang.String arg1, java.lang.CharSequence arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15943.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15943 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputMethodInfo.staticClass, global::android.view.inputmethod.InputMethodInfo._InputMethodInfo15943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15944;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.InputMethodInfo.staticClass, _CREATOR15944)) as android.os.Parcelable_Creator;
			}
		}
		static InputMethodInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputMethodInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputMethodInfo"));
			global::android.view.inputmethod.InputMethodInfo._CREATOR15944 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.InputMethodInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
