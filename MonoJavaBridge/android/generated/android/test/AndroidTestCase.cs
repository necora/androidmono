namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidTestCase : junit.framework.TestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AndroidTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
			set
			{
				setContext(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext12140;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.AndroidTestCase.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.test.AndroidTestCase._getContext12140) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12141;
		protected override void setUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestCase.staticClass, "setUp", "()V", ref global::android.test.AndroidTestCase._setUp12141);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12142;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestCase.staticClass, "tearDown", "()V", ref global::android.test.AndroidTestCase._tearDown12142);
		}
		internal static global::MonoJavaBridge.MethodId _scrubClass12143;
		protected virtual void scrubClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestCase.staticClass, "scrubClass", "(Ljava/lang/Class;)V", ref global::android.test.AndroidTestCase._scrubClass12143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testAndroidTestCaseSetupProperly12144;
		public virtual void testAndroidTestCaseSetupProperly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestCase.staticClass, "testAndroidTestCaseSetupProperly", "()V", ref global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly12144);
		}
		internal static global::MonoJavaBridge.MethodId _setContext12145;
		public virtual void setContext(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestCase.staticClass, "setContext", "(Landroid/content/Context;)V", ref global::android.test.AndroidTestCase._setContext12145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertActivityRequiresPermission12146;
		public virtual void assertActivityRequiresPermission(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestCase.staticClass, "assertActivityRequiresPermission", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.test.AndroidTestCase._assertActivityRequiresPermission12146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertReadingContentUriRequiresPermission12147;
		public virtual void assertReadingContentUriRequiresPermission(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestCase.staticClass, "assertReadingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V", ref global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission12147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertWritingContentUriRequiresPermission12148;
		public virtual void assertWritingContentUriRequiresPermission(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.AndroidTestCase.staticClass, "assertWritingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V", ref global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission12148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AndroidTestCase12149;
		public AndroidTestCase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.AndroidTestCase._AndroidTestCase12149.native == global::System.IntPtr.Zero)
				global::android.test.AndroidTestCase._AndroidTestCase12149 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._AndroidTestCase12149);
			Init(@__env, handle);
		}
		static AndroidTestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.AndroidTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/AndroidTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
