namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecurityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecurityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkPackageAccess20464;
		public virtual void checkPackageAccess(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPackageAccess", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkPackageAccess20464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMemberAccess20465;
		public virtual void checkMemberAccess(java.lang.Class arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkMemberAccess", "(Ljava/lang/Class;I)V", ref global::java.lang.SecurityManager._checkMemberAccess20465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission20466;
		public virtual void checkPermission(java.security.Permission arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;Ljava/lang/Object;)V", ref global::java.lang.SecurityManager._checkPermission20466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission20467;
		public virtual void checkPermission(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;)V", ref global::java.lang.SecurityManager._checkPermission20467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCreateClassLoader20468;
		public virtual void checkCreateClassLoader()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkCreateClassLoader", "()V", ref global::java.lang.SecurityManager._checkCreateClassLoader20468);
		}
		internal static global::MonoJavaBridge.MethodId _checkPropertiesAccess20469;
		public virtual void checkPropertiesAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPropertiesAccess", "()V", ref global::java.lang.SecurityManager._checkPropertiesAccess20469);
		}
		internal static global::MonoJavaBridge.MethodId _checkPropertyAccess20470;
		public virtual void checkPropertyAccess(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPropertyAccess", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkPropertyAccess20470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGroup20471;
		public virtual global::java.lang.ThreadGroup getThreadGroup()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.SecurityManager.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;", ref global::java.lang.SecurityManager._getThreadGroup20471) as java.lang.ThreadGroup;
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20472;
		public virtual void checkAccess(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/Thread;)V", ref global::java.lang.SecurityManager._checkAccess20472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20473;
		public virtual void checkAccess(java.lang.ThreadGroup arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/ThreadGroup;)V", ref global::java.lang.SecurityManager._checkAccess20473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkExit20474;
		public virtual void checkExit(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkExit", "(I)V", ref global::java.lang.SecurityManager._checkExit20474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkLink20475;
		public virtual void checkLink(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkLink", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkLink20475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20476;
		public virtual void checkRead(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/io/FileDescriptor;)V", ref global::java.lang.SecurityManager._checkRead20476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20477;
		public virtual void checkRead(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.lang.SecurityManager._checkRead20477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20478;
		public virtual void checkRead(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkRead20478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkWrite20479;
		public virtual void checkWrite(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/io/FileDescriptor;)V", ref global::java.lang.SecurityManager._checkWrite20479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkWrite20480;
		public virtual void checkWrite(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkWrite20480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkDelete20481;
		public virtual void checkDelete(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkDelete", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkDelete20481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkExec20482;
		public virtual void checkExec(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkExec", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkExec20482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkConnect20483;
		public virtual void checkConnect(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;I)V", ref global::java.lang.SecurityManager._checkConnect20483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkConnect20484;
		public virtual void checkConnect(java.lang.String arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V", ref global::java.lang.SecurityManager._checkConnect20484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _checkSetFactory20485;
		public virtual void checkSetFactory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkSetFactory", "()V", ref global::java.lang.SecurityManager._checkSetFactory20485);
		}
		internal static global::MonoJavaBridge.MethodId _checkSecurityAccess20486;
		public virtual void checkSecurityAccess(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkSecurityAccess", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkSecurityAccess20486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool InCheck
		{
			get
			{
				return getInCheck();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInCheck20487;
		public virtual bool getInCheck()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SecurityManager.staticClass, "getInCheck", "()Z", ref global::java.lang.SecurityManager._getInCheck20487);
		}
		protected new global::java.lang.Class[] ClassContext
		{
			get
			{
				return getClassContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassContext20488;
		protected virtual global::java.lang.Class[] getClassContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.SecurityManager.staticClass, "getClassContext", "()[Ljava/lang/Class;", ref global::java.lang.SecurityManager._getClassContext20488) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _currentClassLoader20489;
		protected virtual global::java.lang.ClassLoader currentClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.SecurityManager.staticClass, "currentClassLoader", "()Ljava/lang/ClassLoader;", ref global::java.lang.SecurityManager._currentClassLoader20489) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _currentLoadedClass20490;
		protected virtual global::java.lang.Class currentLoadedClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.SecurityManager.staticClass, "currentLoadedClass", "()Ljava/lang/Class;", ref global::java.lang.SecurityManager._currentLoadedClass20490) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _classDepth20491;
		protected virtual int classDepth(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.SecurityManager.staticClass, "classDepth", "(Ljava/lang/String;)I", ref global::java.lang.SecurityManager._classDepth20491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _classLoaderDepth20492;
		protected virtual int classLoaderDepth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.SecurityManager.staticClass, "classLoaderDepth", "()I", ref global::java.lang.SecurityManager._classLoaderDepth20492);
		}
		internal static global::MonoJavaBridge.MethodId _inClass20493;
		protected virtual bool inClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SecurityManager.staticClass, "inClass", "(Ljava/lang/String;)Z", ref global::java.lang.SecurityManager._inClass20493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inClassLoader20494;
		protected virtual bool inClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SecurityManager.staticClass, "inClassLoader", "()Z", ref global::java.lang.SecurityManager._inClassLoader20494);
		}
		public new global::java.lang.Object SecurityContext
		{
			get
			{
				return getSecurityContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSecurityContext20495;
		public virtual global::java.lang.Object getSecurityContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.SecurityManager.staticClass, "getSecurityContext", "()Ljava/lang/Object;", ref global::java.lang.SecurityManager._getSecurityContext20495) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkListen20496;
		public virtual void checkListen(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkListen", "(I)V", ref global::java.lang.SecurityManager._checkListen20496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkAccept20497;
		public virtual void checkAccept(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkAccept", "(Ljava/lang/String;I)V", ref global::java.lang.SecurityManager._checkAccept20497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkMulticast20498;
		public virtual void checkMulticast(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;)V", ref global::java.lang.SecurityManager._checkMulticast20498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMulticast20499;
		public virtual void checkMulticast(java.net.InetAddress arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;B)V", ref global::java.lang.SecurityManager._checkMulticast20499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkTopLevelWindow20500;
		public virtual bool checkTopLevelWindow(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SecurityManager.staticClass, "checkTopLevelWindow", "(Ljava/lang/Object;)Z", ref global::java.lang.SecurityManager._checkTopLevelWindow20500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkPrintJobAccess20501;
		public virtual void checkPrintJobAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPrintJobAccess", "()V", ref global::java.lang.SecurityManager._checkPrintJobAccess20501);
		}
		internal static global::MonoJavaBridge.MethodId _checkSystemClipboardAccess20502;
		public virtual void checkSystemClipboardAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkSystemClipboardAccess", "()V", ref global::java.lang.SecurityManager._checkSystemClipboardAccess20502);
		}
		internal static global::MonoJavaBridge.MethodId _checkAwtEventQueueAccess20503;
		public virtual void checkAwtEventQueueAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkAwtEventQueueAccess", "()V", ref global::java.lang.SecurityManager._checkAwtEventQueueAccess20503);
		}
		internal static global::MonoJavaBridge.MethodId _checkPackageDefinition20504;
		public virtual void checkPackageDefinition(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPackageDefinition", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._checkPackageDefinition20504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SecurityManager20505;
		public SecurityManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.SecurityManager._SecurityManager20505.native == global::System.IntPtr.Zero)
				global::java.lang.SecurityManager._SecurityManager20505 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._SecurityManager20505);
			Init(@__env, handle);
		}
		static SecurityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SecurityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SecurityManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
