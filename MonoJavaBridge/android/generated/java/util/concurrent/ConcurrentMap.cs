namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ConcurrentMap_))]
	public partial interface ConcurrentMap : Map
	{
		bool replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		global::java.lang.Object replace(java.lang.Object arg0, java.lang.Object arg1);
		bool remove(java.lang.Object arg0, java.lang.Object arg1);
		global::java.lang.Object putIfAbsent(java.lang.Object arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ConcurrentMap))]
	internal sealed partial class ConcurrentMap_ : java.lang.Object, ConcurrentMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConcurrentMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _replace27147;
		bool java.util.concurrent.ConcurrentMap.replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._replace27147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _replace27148;
		global::java.lang.Object java.util.concurrent.ConcurrentMap.replace(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._replace27148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove27149;
		bool java.util.concurrent.ConcurrentMap.remove(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._remove27149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putIfAbsent27150;
		global::java.lang.Object java.util.concurrent.ConcurrentMap.putIfAbsent(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._putIfAbsent27150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get27151;
		global::java.lang.Object java.util.Map.get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._get27151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put27152;
		global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._put27152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals27153;
		bool java.util.Map.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._equals27153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values27154;
		global::java.util.Collection java.util.Map.values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.concurrent.ConcurrentMap_._values27154) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27155;
		int java.util.Map.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "hashCode", "()I", ref global::java.util.concurrent.ConcurrentMap_._hashCode27155);
		}
		internal static global::MonoJavaBridge.MethodId _clear27156;
		void java.util.Map.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "clear", "()V", ref global::java.util.concurrent.ConcurrentMap_._clear27156);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27157;
		bool java.util.Map.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.ConcurrentMap_._isEmpty27157);
		}
		internal static global::MonoJavaBridge.MethodId _size27158;
		int java.util.Map.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "size", "()I", ref global::java.util.concurrent.ConcurrentMap_._size27158);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet27159;
		global::java.util.Set java.util.Map.entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.concurrent.ConcurrentMap_._entrySet27159) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll27160;
		void java.util.Map.putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.concurrent.ConcurrentMap_._putAll27160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove27161;
		global::java.lang.Object java.util.Map.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentMap_._remove27161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet27162;
		global::java.util.Set java.util.Map.keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.concurrent.ConcurrentMap_._keySet27162) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue27163;
		bool java.util.Map.containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._containsValue27163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey27164;
		bool java.util.Map.containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentMap_._containsKey27164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ConcurrentMap_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}
