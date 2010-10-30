namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.sqlite.SQLiteClosable_))]
	public abstract partial class SQLiteClosable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteClosable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased4706;
		protected abstract void onAllReferencesReleased();
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleasedFromContainer4707;
		protected virtual void onAllReferencesReleasedFromContainer()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleasedFromContainer", "()V", ref global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer4707);
		}
		internal static global::MonoJavaBridge.MethodId _acquireReference4708;
		public virtual void acquireReference()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, "acquireReference", "()V", ref global::android.database.sqlite.SQLiteClosable._acquireReference4708);
		}
		internal static global::MonoJavaBridge.MethodId _releaseReference4709;
		public virtual void releaseReference()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReference", "()V", ref global::android.database.sqlite.SQLiteClosable._releaseReference4709);
		}
		internal static global::MonoJavaBridge.MethodId _releaseReferenceFromContainer4710;
		public virtual void releaseReferenceFromContainer()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReferenceFromContainer", "()V", ref global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer4710);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteClosable4711;
		public SQLiteClosable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteClosable._SQLiteClosable4711.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteClosable._SQLiteClosable4711 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteClosable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._SQLiteClosable4711);
			Init(@__env, handle);
		}
		static SQLiteClosable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteClosable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteClosable"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteClosable))]
	internal sealed partial class SQLiteClosable_ : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLiteClosable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased4712;
		protected override void onAllReferencesReleased()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable_.staticClass, "onAllReferencesReleased", "()V", ref global::android.database.sqlite.SQLiteClosable_._onAllReferencesReleased4712);
		}
		static SQLiteClosable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteClosable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteClosable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
