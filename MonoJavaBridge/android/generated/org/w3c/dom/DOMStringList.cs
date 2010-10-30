namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DOMStringList_))]
	public partial interface DOMStringList  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		bool contains(java.lang.String arg0);
		global::java.lang.String item(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DOMStringList))]
	internal sealed partial class DOMStringList_ : java.lang.Object, DOMStringList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMStringList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34383;
		int org.w3c.dom.DOMStringList.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.DOMStringList_.staticClass, "getLength", "()I", ref global::org.w3c.dom.DOMStringList_._getLength34383);
		}
		internal static global::MonoJavaBridge.MethodId _contains34384;
		bool org.w3c.dom.DOMStringList.contains(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DOMStringList_.staticClass, "contains", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.DOMStringList_._contains34384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _item34385;
		global::java.lang.String org.w3c.dom.DOMStringList.item(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DOMStringList_.staticClass, "item", "(I)Ljava/lang/String;", ref global::org.w3c.dom.DOMStringList_._item34385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static DOMStringList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMStringList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMStringList"));
		}
		internal static void InitJNI()
		{
		}
	}
}
