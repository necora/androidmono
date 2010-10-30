namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.AclEntry_))]
	public partial interface AclEntry : java.lang.Cloneable
	{
		global::java.lang.String toString();
		global::java.lang.Object clone();
		bool checkPermission(java.security.acl.Permission arg0);
		global::java.util.Enumeration permissions();
		bool isNegative();
		bool addPermission(java.security.acl.Permission arg0);
		bool removePermission(java.security.acl.Permission arg0);
		global::java.security.Principal getPrincipal();
		bool setPrincipal(java.security.Principal arg0);
		void setNegativePermissions();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.AclEntry))]
	internal sealed partial class AclEntry_ : java.lang.Object, AclEntry
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AclEntry_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23441;
		global::java.lang.String java.security.acl.AclEntry.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.acl.AclEntry_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.acl.AclEntry_._toString23441) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23442;
		global::java.lang.Object java.security.acl.AclEntry.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.acl.AclEntry_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.acl.AclEntry_._clone23442) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission23443;
		bool java.security.acl.AclEntry.checkPermission(java.security.acl.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "checkPermission", "(Ljava/security/acl/Permission;)Z", ref global::java.security.acl.AclEntry_._checkPermission23443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _permissions23444;
		global::java.util.Enumeration java.security.acl.AclEntry.permissions()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.acl.AclEntry_.staticClass, "permissions", "()Ljava/util/Enumeration;", ref global::java.security.acl.AclEntry_._permissions23444) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _isNegative23445;
		bool java.security.acl.AclEntry.isNegative()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "isNegative", "()Z", ref global::java.security.acl.AclEntry_._isNegative23445);
		}
		internal static global::MonoJavaBridge.MethodId _addPermission23446;
		bool java.security.acl.AclEntry.addPermission(java.security.acl.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "addPermission", "(Ljava/security/acl/Permission;)Z", ref global::java.security.acl.AclEntry_._addPermission23446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePermission23447;
		bool java.security.acl.AclEntry.removePermission(java.security.acl.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "removePermission", "(Ljava/security/acl/Permission;)Z", ref global::java.security.acl.AclEntry_._removePermission23447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipal23448;
		global::java.security.Principal java.security.acl.AclEntry.getPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::java.security.acl.AclEntry_.staticClass, "getPrincipal", "()Ljava/security/Principal;", ref global::java.security.acl.AclEntry_._getPrincipal23448) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _setPrincipal23449;
		bool java.security.acl.AclEntry.setPrincipal(java.security.Principal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.acl.AclEntry_.staticClass, "setPrincipal", "(Ljava/security/Principal;)Z", ref global::java.security.acl.AclEntry_._setPrincipal23449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNegativePermissions23450;
		void java.security.acl.AclEntry.setNegativePermissions()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.acl.AclEntry_.staticClass, "setNegativePermissions", "()V", ref global::java.security.acl.AclEntry_._setNegativePermissions23450);
		}
		static AclEntry_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.AclEntry_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/AclEntry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
