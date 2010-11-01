namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.NamedNodeMap_))]
	public partial interface NamedNodeMap  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::org.w3c.dom.Node item(int arg0);
		global::org.w3c.dom.Node getNamedItem(java.lang.String arg0);
		global::org.w3c.dom.Node setNamedItem(org.w3c.dom.Node arg0);
		global::org.w3c.dom.Node removeNamedItem(java.lang.String arg0);
		global::org.w3c.dom.Node getNamedItemNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Node setNamedItemNS(org.w3c.dom.Node arg0);
		global::org.w3c.dom.Node removeNamedItemNS(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.NamedNodeMap))]
	internal sealed partial class NamedNodeMap_ : java.lang.Object, NamedNodeMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NamedNodeMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int org.w3c.dom.NamedNodeMap.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.NamedNodeMap_.staticClass, "getLength", "()I", ref global::org.w3c.dom.NamedNodeMap_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.item(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.NamedNodeMap_.staticClass, "item", "(I)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.NamedNodeMap_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.getNamedItem(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.NamedNodeMap_.staticClass, "getNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.NamedNodeMap_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.setNamedItem(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.NamedNodeMap_.staticClass, "setNamedItem", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.NamedNodeMap_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.removeNamedItem(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.NamedNodeMap_.staticClass, "removeNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.NamedNodeMap_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.getNamedItemNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.NamedNodeMap_.staticClass, "getNamedItemNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.NamedNodeMap_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.setNamedItemNS(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.NamedNodeMap_.staticClass, "setNamedItemNS", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.NamedNodeMap_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::org.w3c.dom.Node org.w3c.dom.NamedNodeMap.removeNamedItemNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.NamedNodeMap_.staticClass, "removeNamedItemNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.NamedNodeMap_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		static NamedNodeMap_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.NamedNodeMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/NamedNodeMap"));
		}
	}
}