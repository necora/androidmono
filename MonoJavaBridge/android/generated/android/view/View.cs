namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class View : java.lang.Object, android.graphics.drawable.Drawable.Callback, android.view.KeyEvent.Callback, android.view.accessibility.AccessibilityEventSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected View(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class BaseSavedState : android.view.AbsSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected BaseSavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState14618;
			public BaseSavedState(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.BaseSavedState._BaseSavedState14618.native == global::System.IntPtr.Zero)
					global::android.view.View.BaseSavedState._BaseSavedState14618 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState14618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _BaseSavedState14619;
			public BaseSavedState(android.os.Parcelable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.BaseSavedState._BaseSavedState14619.native == global::System.IntPtr.Zero)
					global::android.view.View.BaseSavedState._BaseSavedState14619 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._BaseSavedState14619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR14620;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.View.BaseSavedState.staticClass, _CREATOR14620)) as android.os.Parcelable_Creator;
				}
			}
			static BaseSavedState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$BaseSavedState"));
				global::android.view.View.BaseSavedState._CREATOR14620 = @__env.GetStaticFieldIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MeasureSpec : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MeasureSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString14621;
			public static global::java.lang.String toString(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._toString14621.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._toString14621 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "toString", "(I)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._toString14621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getSize14622;
			public static int getSize(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._getSize14622.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._getSize14622 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getSize", "(I)I");
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getSize14622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getMode14623;
			public static int getMode(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._getMode14623.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._getMode14623 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getMode", "(I)I");
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._getMode14623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _makeMeasureSpec14624;
			public static int makeMeasureSpec(int arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._makeMeasureSpec14624.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._makeMeasureSpec14624 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "makeMeasureSpec", "(II)I");
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._makeMeasureSpec14624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _MeasureSpec14625;
			public MeasureSpec() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._MeasureSpec14625.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._MeasureSpec14625 = @__env.GetMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._MeasureSpec14625);
				Init(@__env, handle);
			}
			public static int UNSPECIFIED
			{
				get
				{
					return 0;
				}
			}
			public static int EXACTLY
			{
				get
				{
					return 1073741824;
				}
			}
			public static int AT_MOST
			{
				get
				{
					return -2147483648;
				}
			}
			static MeasureSpec()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.MeasureSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$MeasureSpec"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnClickListener_))]
		public partial interface OnClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onClick(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnClickListener))]
		internal sealed partial class OnClickListener_ : java.lang.Object, OnClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onClick14629;
			void android.view.View.OnClickListener.onClick(android.view.View arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.OnClickListener_.staticClass, "onClick", "(Landroid/view/View;)V", ref global::android.view.View.OnClickListener_._onClick14629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnClickListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnClickListenerDelegate(android.view.View arg0);

		internal partial class OnClickListenerDelegateWrapper : java.lang.Object, OnClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnClickListenerDelegateWrapper14630;
			public OnClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnClickListenerDelegateWrapper._OnClickListenerDelegateWrapper14630.native == global::System.IntPtr.Zero)
					global::android.view.View.OnClickListenerDelegateWrapper._OnClickListenerDelegateWrapper14630 = @__env.GetMethodIDNoThrow(global::android.view.View.OnClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnClickListenerDelegateWrapper.staticClass, global::android.view.View.OnClickListenerDelegateWrapper._OnClickListenerDelegateWrapper14630);
				Init(@__env, handle);
			}
			static OnClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnClickListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnClickListenerDelegateWrapper
		{
			private OnClickListenerDelegate myDelegate;
			public void onClick(android.view.View arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnClickListenerDelegateWrapper(OnClickListenerDelegate d)
			{
				global::android.view.View.OnClickListenerDelegateWrapper ret = new global::android.view.View.OnClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnCreateContextMenuListener_))]
		public partial interface OnCreateContextMenuListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnCreateContextMenuListener))]
		internal sealed partial class OnCreateContextMenuListener_ : java.lang.Object, OnCreateContextMenuListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnCreateContextMenuListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCreateContextMenu14631;
			void android.view.View.OnCreateContextMenuListener.onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.OnCreateContextMenuListener_.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", ref global::android.view.View.OnCreateContextMenuListener_._onCreateContextMenu14631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnCreateContextMenuListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnCreateContextMenuListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnCreateContextMenuListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnCreateContextMenuListenerDelegate(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2);

		internal partial class OnCreateContextMenuListenerDelegateWrapper : java.lang.Object, OnCreateContextMenuListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCreateContextMenuListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnCreateContextMenuListenerDelegateWrapper14632;
			public OnCreateContextMenuListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnCreateContextMenuListenerDelegateWrapper._OnCreateContextMenuListenerDelegateWrapper14632.native == global::System.IntPtr.Zero)
					global::android.view.View.OnCreateContextMenuListenerDelegateWrapper._OnCreateContextMenuListenerDelegateWrapper14632 = @__env.GetMethodIDNoThrow(global::android.view.View.OnCreateContextMenuListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnCreateContextMenuListenerDelegateWrapper.staticClass, global::android.view.View.OnCreateContextMenuListenerDelegateWrapper._OnCreateContextMenuListenerDelegateWrapper14632);
				Init(@__env, handle);
			}
			static OnCreateContextMenuListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnCreateContextMenuListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnCreateContextMenuListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnCreateContextMenuListenerDelegateWrapper
		{
			private OnCreateContextMenuListenerDelegate myDelegate;
			public void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnCreateContextMenuListenerDelegateWrapper(OnCreateContextMenuListenerDelegate d)
			{
				global::android.view.View.OnCreateContextMenuListenerDelegateWrapper ret = new global::android.view.View.OnCreateContextMenuListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnFocusChangeListener_))]
		public partial interface OnFocusChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onFocusChange(android.view.View arg0, bool arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnFocusChangeListener))]
		internal sealed partial class OnFocusChangeListener_ : java.lang.Object, OnFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnFocusChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onFocusChange14633;
			void android.view.View.OnFocusChangeListener.onFocusChange(android.view.View arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.OnFocusChangeListener_.staticClass, "onFocusChange", "(Landroid/view/View;Z)V", ref global::android.view.View.OnFocusChangeListener_._onFocusChange14633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnFocusChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnFocusChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnFocusChangeListenerDelegate(android.view.View arg0, bool arg1);

		internal partial class OnFocusChangeListenerDelegateWrapper : java.lang.Object, OnFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnFocusChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnFocusChangeListenerDelegateWrapper14634;
			public OnFocusChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnFocusChangeListenerDelegateWrapper._OnFocusChangeListenerDelegateWrapper14634.native == global::System.IntPtr.Zero)
					global::android.view.View.OnFocusChangeListenerDelegateWrapper._OnFocusChangeListenerDelegateWrapper14634 = @__env.GetMethodIDNoThrow(global::android.view.View.OnFocusChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnFocusChangeListenerDelegateWrapper.staticClass, global::android.view.View.OnFocusChangeListenerDelegateWrapper._OnFocusChangeListenerDelegateWrapper14634);
				Init(@__env, handle);
			}
			static OnFocusChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnFocusChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnFocusChangeListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnFocusChangeListenerDelegateWrapper
		{
			private OnFocusChangeListenerDelegate myDelegate;
			public void onFocusChange(android.view.View arg0, bool arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnFocusChangeListenerDelegateWrapper(OnFocusChangeListenerDelegate d)
			{
				global::android.view.View.OnFocusChangeListenerDelegateWrapper ret = new global::android.view.View.OnFocusChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnKeyListener_))]
		public partial interface OnKeyListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnKeyListener))]
		internal sealed partial class OnKeyListener_ : java.lang.Object, OnKeyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onKey14635;
			bool android.view.View.OnKeyListener.onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.OnKeyListener_.staticClass, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z", ref global::android.view.View.OnKeyListener_._onKey14635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnKeyListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnKeyListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnKeyListenerDelegate(android.view.View arg0, int arg1, android.view.KeyEvent arg2);

		internal partial class OnKeyListenerDelegateWrapper : java.lang.Object, OnKeyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnKeyListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnKeyListenerDelegateWrapper14636;
			public OnKeyListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnKeyListenerDelegateWrapper._OnKeyListenerDelegateWrapper14636.native == global::System.IntPtr.Zero)
					global::android.view.View.OnKeyListenerDelegateWrapper._OnKeyListenerDelegateWrapper14636 = @__env.GetMethodIDNoThrow(global::android.view.View.OnKeyListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnKeyListenerDelegateWrapper.staticClass, global::android.view.View.OnKeyListenerDelegateWrapper._OnKeyListenerDelegateWrapper14636);
				Init(@__env, handle);
			}
			static OnKeyListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnKeyListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnKeyListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnKeyListenerDelegateWrapper
		{
			private OnKeyListenerDelegate myDelegate;
			public bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnKeyListenerDelegateWrapper(OnKeyListenerDelegate d)
			{
				global::android.view.View.OnKeyListenerDelegateWrapper ret = new global::android.view.View.OnKeyListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnLongClickListener_))]
		public partial interface OnLongClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onLongClick(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnLongClickListener))]
		internal sealed partial class OnLongClickListener_ : java.lang.Object, OnLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnLongClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLongClick14637;
			bool android.view.View.OnLongClickListener.onLongClick(android.view.View arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.OnLongClickListener_.staticClass, "onLongClick", "(Landroid/view/View;)Z", ref global::android.view.View.OnLongClickListener_._onLongClick14637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnLongClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnLongClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnLongClickListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnLongClickListenerDelegate(android.view.View arg0);

		internal partial class OnLongClickListenerDelegateWrapper : java.lang.Object, OnLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnLongClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnLongClickListenerDelegateWrapper14638;
			public OnLongClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnLongClickListenerDelegateWrapper._OnLongClickListenerDelegateWrapper14638.native == global::System.IntPtr.Zero)
					global::android.view.View.OnLongClickListenerDelegateWrapper._OnLongClickListenerDelegateWrapper14638 = @__env.GetMethodIDNoThrow(global::android.view.View.OnLongClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnLongClickListenerDelegateWrapper.staticClass, global::android.view.View.OnLongClickListenerDelegateWrapper._OnLongClickListenerDelegateWrapper14638);
				Init(@__env, handle);
			}
			static OnLongClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnLongClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnLongClickListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnLongClickListenerDelegateWrapper
		{
			private OnLongClickListenerDelegate myDelegate;
			public bool onLongClick(android.view.View arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator OnLongClickListenerDelegateWrapper(OnLongClickListenerDelegate d)
			{
				global::android.view.View.OnLongClickListenerDelegateWrapper ret = new global::android.view.View.OnLongClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnTouchListener_))]
		public partial interface OnTouchListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onTouch(android.view.View arg0, android.view.MotionEvent arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnTouchListener))]
		internal sealed partial class OnTouchListener_ : java.lang.Object, OnTouchListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnTouchListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTouch14639;
			bool android.view.View.OnTouchListener.onTouch(android.view.View arg0, android.view.MotionEvent arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.OnTouchListener_.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", ref global::android.view.View.OnTouchListener_._onTouch14639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnTouchListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnTouchListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnTouchListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnTouchListenerDelegate(android.view.View arg0, android.view.MotionEvent arg1);

		internal partial class OnTouchListenerDelegateWrapper : java.lang.Object, OnTouchListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTouchListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnTouchListenerDelegateWrapper14640;
			public OnTouchListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnTouchListenerDelegateWrapper._OnTouchListenerDelegateWrapper14640.native == global::System.IntPtr.Zero)
					global::android.view.View.OnTouchListenerDelegateWrapper._OnTouchListenerDelegateWrapper14640 = @__env.GetMethodIDNoThrow(global::android.view.View.OnTouchListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnTouchListenerDelegateWrapper.staticClass, global::android.view.View.OnTouchListenerDelegateWrapper._OnTouchListenerDelegateWrapper14640);
				Init(@__env, handle);
			}
			static OnTouchListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnTouchListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnTouchListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnTouchListenerDelegateWrapper
		{
			private OnTouchListenerDelegate myDelegate;
			public bool onTouch(android.view.View arg0, android.view.MotionEvent arg1)
			{
				return myDelegate(arg0, arg1);
			}
			public static implicit operator OnTouchListenerDelegateWrapper(OnTouchListenerDelegate d)
			{
				global::android.view.View.OnTouchListenerDelegateWrapper ret = new global::android.view.View.OnTouchListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources14641;
		public virtual global::android.content.res.Resources getResources()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getResources", "()Landroid/content/res/Resources;", ref global::android.view.View._getResources14641) as android.content.res.Resources;
		}
		public new global::android.view.ViewParent Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent14642;
		public virtual global::android.view.ViewParent getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ViewParent>(this, global::android.view.View.staticClass, "getParent", "()Landroid/view/ViewParent;", ref global::android.view.View._getParent14642) as android.view.ViewParent;
		}
		public new int Id
		{
			get
			{
				return getId();
			}
			set
			{
				setId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId14643;
		public virtual int getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getId", "()I", ref global::android.view.View._getId14643);
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext14644;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.view.View._getContext14644) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque14645;
		public virtual bool isOpaque()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isOpaque", "()Z", ref global::android.view.View._isOpaque14645);
		}
		public new global::android.os.Handler Handler
		{
			get
			{
				return getHandler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandler14646;
		public virtual global::android.os.Handler getHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getHandler", "()Landroid/os/Handler;", ref global::android.view.View._getHandler14646) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _inflate14647;
		public static global::android.view.View inflate(android.content.Context arg0, int arg1, android.view.ViewGroup arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._inflate14647.native == global::System.IntPtr.Zero)
				global::android.view.View._inflate14647 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._inflate14647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getTag14648;
		public virtual global::java.lang.Object getTag(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getTag", "(I)Ljava/lang/Object;", ref global::android.view.View._getTag14648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		public new global::java.lang.Object Tag
		{
			get
			{
				return getTag();
			}
			set
			{
				setTag(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTag14649;
		public virtual global::java.lang.Object getTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getTag", "()Ljava/lang/Object;", ref global::android.view.View._getTag14649) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invalidate14650;
		public virtual void invalidate(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "invalidate", "(Landroid/graphics/Rect;)V", ref global::android.view.View._invalidate14650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidate14651;
		public virtual void invalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "invalidate", "()V", ref global::android.view.View._invalidate14651);
		}
		internal static global::MonoJavaBridge.MethodId _invalidate14652;
		public virtual void invalidate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "invalidate", "(IIII)V", ref global::android.view.View._invalidate14652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _layout14653;
		public virtual void layout(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "layout", "(IIII)V", ref global::android.view.View._layout14653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged14654;
		protected virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.view.View._onConfigurationChanged14654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled14655;
		public virtual bool isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isEnabled", "()Z", ref global::android.view.View._isEnabled14655);
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled14656;
		public virtual void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setEnabled", "(Z)V", ref global::android.view.View._setEnabled14656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new string ContentDescription
		{
			get
			{
				return getContentDescription().toString();
			}
			set
			{
				setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentDescription14657;
		public virtual global::java.lang.CharSequence getContentDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.View.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;", ref global::android.view.View._getContentDescription14657) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setContentDescription14658;
		public virtual void setContentDescription(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V", ref global::android.view.View._setContentDescription14658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setContentDescription(string arg0)
		{
			setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new global::android.view.animation.Animation Animation
		{
			get
			{
				return getAnimation();
			}
			set
			{
				setAnimation(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation14659;
		public virtual global::android.view.animation.Animation getAnimation()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getAnimation", "()Landroid/view/animation/Animation;", ref global::android.view.View._getAnimation14659) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _draw14660;
		public virtual void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.view.View._draw14660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth14661;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getWidth", "()I", ref global::android.view.View._getWidth14661);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight14662;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getHeight", "()I", ref global::android.view.View._getHeight14662);
		}
		internal static global::MonoJavaBridge.MethodId _post14663;
		public virtual bool post(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "post", "(Ljava/lang/Runnable;)Z", ref global::android.view.View._post14663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool post(global::java.lang.RunnableDelegate arg0)
		{
			return post((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _postDelayed14664;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z", ref global::android.view.View._postDelayed14664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool postDelayed(global::java.lang.RunnableDelegate arg0, long arg1)
		{
			return postDelayed((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks14665;
		public virtual bool removeCallbacks(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)Z", ref global::android.view.View._removeCallbacks14665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool removeCallbacks(global::java.lang.RunnableDelegate arg0)
		{
			return removeCallbacks((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState14666;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.view.View._onRestoreInstanceState14666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState14667;
		protected virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.view.View.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.view.View._onSaveInstanceState14667) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _findViewById14668;
		public virtual global::android.view.View findViewById(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "findViewById", "(I)Landroid/view/View;", ref global::android.view.View._findViewById14668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown14669;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._onKeyDown14669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress14670;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._onKeyLongPress14670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp14671;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._onKeyUp14671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple14672;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.view.View._onKeyMultiple14672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent14673;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.View._onTouchEvent14673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent14674;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.View._onTrackballEvent14674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged14675;
		public virtual void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.view.View._onWindowFocusChanged14675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus14676;
		public virtual bool hasFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "hasFocus", "()Z", ref global::android.view.View._hasFocus14676);
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow14677;
		protected virtual void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onAttachedToWindow", "()V", ref global::android.view.View._onAttachedToWindow14677);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow14678;
		protected virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onDetachedFromWindow", "()V", ref global::android.view.View._onDetachedFromWindow14678);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus14679;
		public virtual bool hasWindowFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "hasWindowFocus", "()Z", ref global::android.view.View._hasWindowFocus14679);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent14680;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.View._dispatchKeyEvent14680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent14681;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.View._dispatchTouchEvent14681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent14682;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.View._dispatchTrackballEvent14682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent14683;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.view.View._dispatchPopulateAccessibilityEvent14683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu14684;
		protected virtual void onCreateContextMenu(android.view.ContextMenu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V", ref global::android.view.View._onCreateContextMenu14684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable BackgroundDrawable
		{
			set
			{
				setBackgroundDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable14685;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.view.View._setBackgroundDrawable14685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState14686;
		public virtual void saveHierarchyState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "saveHierarchyState", "(Landroid/util/SparseArray;)V", ref global::android.view.View._saveHierarchyState14686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState14687;
		public virtual void restoreHierarchyState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "restoreHierarchyState", "(Landroid/util/SparseArray;)V", ref global::android.view.View._restoreHierarchyState14687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initializeFadingEdge14688;
		protected virtual void initializeFadingEdge(android.content.res.TypedArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "initializeFadingEdge", "(Landroid/content/res/TypedArray;)V", ref global::android.view.View._initializeFadingEdge14688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VerticalFadingEdgeLength
		{
			get
			{
				return getVerticalFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalFadingEdgeLength14689;
		public virtual int getVerticalFadingEdgeLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getVerticalFadingEdgeLength", "()I", ref global::android.view.View._getVerticalFadingEdgeLength14689);
		}
		public new int FadingEdgeLength
		{
			set
			{
				setFadingEdgeLength(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFadingEdgeLength14690;
		public virtual void setFadingEdgeLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setFadingEdgeLength", "(I)V", ref global::android.view.View._setFadingEdgeLength14690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int HorizontalFadingEdgeLength
		{
			get
			{
				return getHorizontalFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalFadingEdgeLength14691;
		public virtual int getHorizontalFadingEdgeLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getHorizontalFadingEdgeLength", "()I", ref global::android.view.View._getHorizontalFadingEdgeLength14691);
		}
		public new int VerticalScrollbarWidth
		{
			get
			{
				return getVerticalScrollbarWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalScrollbarWidth14692;
		public virtual int getVerticalScrollbarWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getVerticalScrollbarWidth", "()I", ref global::android.view.View._getVerticalScrollbarWidth14692);
		}
		protected new int HorizontalScrollbarHeight
		{
			get
			{
				return getHorizontalScrollbarHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalScrollbarHeight14693;
		protected virtual int getHorizontalScrollbarHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getHorizontalScrollbarHeight", "()I", ref global::android.view.View._getHorizontalScrollbarHeight14693);
		}
		internal static global::MonoJavaBridge.MethodId _initializeScrollbars14694;
		protected virtual void initializeScrollbars(android.content.res.TypedArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "initializeScrollbars", "(Landroid/content/res/TypedArray;)V", ref global::android.view.View._initializeScrollbars14694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnFocusChangeListener14695;
		public virtual void setOnFocusChangeListener(android.view.View.OnFocusChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V", ref global::android.view.View._setOnFocusChangeListener14695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnFocusChangeListener(global::android.view.View.OnFocusChangeListenerDelegate arg0)
		{
			setOnFocusChangeListener((global::android.view.View.OnFocusChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getOnFocusChangeListener14696;
		public virtual global::android.view.View.OnFocusChangeListener getOnFocusChangeListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.View.OnFocusChangeListener>(this, global::android.view.View.staticClass, "getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;", ref global::android.view.View._getOnFocusChangeListener14696) as android.view.View.OnFocusChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickListener14697;
		public virtual void setOnClickListener(android.view.View.OnClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V", ref global::android.view.View._setOnClickListener14697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnLongClickListener14698;
		public virtual void setOnLongClickListener(android.view.View.OnLongClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", ref global::android.view.View._setOnLongClickListener14698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnLongClickListener(global::android.view.View.OnLongClickListenerDelegate arg0)
		{
			setOnLongClickListener((global::android.view.View.OnLongClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnCreateContextMenuListener14699;
		public virtual void setOnCreateContextMenuListener(android.view.View.OnCreateContextMenuListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V", ref global::android.view.View._setOnCreateContextMenuListener14699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCreateContextMenuListener(global::android.view.View.OnCreateContextMenuListenerDelegate arg0)
		{
			setOnCreateContextMenuListener((global::android.view.View.OnCreateContextMenuListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _performClick14700;
		public virtual bool performClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "performClick", "()Z", ref global::android.view.View._performClick14700);
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick14701;
		public virtual bool performLongClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "performLongClick", "()Z", ref global::android.view.View._performLongClick14701);
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenu14702;
		public virtual bool showContextMenu()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "showContextMenu", "()Z", ref global::android.view.View._showContextMenu14702);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyListener14703;
		public virtual void setOnKeyListener(android.view.View.OnKeyListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V", ref global::android.view.View._setOnKeyListener14703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnKeyListener(global::android.view.View.OnKeyListenerDelegate arg0)
		{
			setOnKeyListener((global::android.view.View.OnKeyListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnTouchListener14704;
		public virtual void setOnTouchListener(android.view.View.OnTouchListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V", ref global::android.view.View._setOnTouchListener14704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnTouchListener(global::android.view.View.OnTouchListenerDelegate arg0)
		{
			setOnTouchListener((global::android.view.View.OnTouchListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _requestRectangleOnScreen14705;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z", ref global::android.view.View._requestRectangleOnScreen14705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestRectangleOnScreen14706;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z", ref global::android.view.View._requestRectangleOnScreen14706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearFocus14707;
		public virtual void clearFocus()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "clearFocus", "()V", ref global::android.view.View._clearFocus14707);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocusable14708;
		public virtual bool hasFocusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "hasFocusable", "()Z", ref global::android.view.View._hasFocusable14708);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged14709;
		protected virtual void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.view.View._onFocusChanged14709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent14710;
		public virtual void sendAccessibilityEvent(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "sendAccessibilityEvent", "(I)V", ref global::android.view.View._sendAccessibilityEvent14710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEventUnchecked14711;
		public virtual void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", ref global::android.view.View._sendAccessibilityEventUnchecked14711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocused14712;
		public virtual bool isFocused()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isFocused", "()Z", ref global::android.view.View._isFocused14712);
		}
		internal static global::MonoJavaBridge.MethodId _findFocus14713;
		public virtual global::android.view.View findFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "findFocus", "()Landroid/view/View;", ref global::android.view.View._findFocus14713) as android.view.View;
		}
		public new bool ScrollContainer
		{
			set
			{
				setScrollContainer(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setScrollContainer14714;
		public virtual void setScrollContainer(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setScrollContainer", "(Z)V", ref global::android.view.View._setScrollContainer14714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DrawingCacheQuality
		{
			get
			{
				return getDrawingCacheQuality();
			}
			set
			{
				setDrawingCacheQuality(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCacheQuality14715;
		public virtual int getDrawingCacheQuality()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getDrawingCacheQuality", "()I", ref global::android.view.View._getDrawingCacheQuality14715);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheQuality14716;
		public virtual void setDrawingCacheQuality(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setDrawingCacheQuality", "(I)V", ref global::android.view.View._setDrawingCacheQuality14716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool KeepScreenOn
		{
			get
			{
				return getKeepScreenOn();
			}
			set
			{
				setKeepScreenOn(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeepScreenOn14717;
		public virtual bool getKeepScreenOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "getKeepScreenOn", "()Z", ref global::android.view.View._getKeepScreenOn14717);
		}
		internal static global::MonoJavaBridge.MethodId _setKeepScreenOn14718;
		public virtual void setKeepScreenOn(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setKeepScreenOn", "(Z)V", ref global::android.view.View._setKeepScreenOn14718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusLeftId
		{
			get
			{
				return getNextFocusLeftId();
			}
			set
			{
				setNextFocusLeftId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusLeftId14719;
		public virtual int getNextFocusLeftId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getNextFocusLeftId", "()I", ref global::android.view.View._getNextFocusLeftId14719);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusLeftId14720;
		public virtual void setNextFocusLeftId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setNextFocusLeftId", "(I)V", ref global::android.view.View._setNextFocusLeftId14720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusRightId
		{
			get
			{
				return getNextFocusRightId();
			}
			set
			{
				setNextFocusRightId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusRightId14721;
		public virtual int getNextFocusRightId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getNextFocusRightId", "()I", ref global::android.view.View._getNextFocusRightId14721);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusRightId14722;
		public virtual void setNextFocusRightId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setNextFocusRightId", "(I)V", ref global::android.view.View._setNextFocusRightId14722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusUpId
		{
			get
			{
				return getNextFocusUpId();
			}
			set
			{
				setNextFocusUpId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusUpId14723;
		public virtual int getNextFocusUpId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getNextFocusUpId", "()I", ref global::android.view.View._getNextFocusUpId14723);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusUpId14724;
		public virtual void setNextFocusUpId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setNextFocusUpId", "(I)V", ref global::android.view.View._setNextFocusUpId14724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusDownId
		{
			get
			{
				return getNextFocusDownId();
			}
			set
			{
				setNextFocusDownId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextFocusDownId14725;
		public virtual int getNextFocusDownId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getNextFocusDownId", "()I", ref global::android.view.View._getNextFocusDownId14725);
		}
		internal static global::MonoJavaBridge.MethodId _setNextFocusDownId14726;
		public virtual void setNextFocusDownId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setNextFocusDownId", "(I)V", ref global::android.view.View._setNextFocusDownId14726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShown14727;
		public virtual bool isShown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isShown", "()Z", ref global::android.view.View._isShown14727);
		}
		internal static global::MonoJavaBridge.MethodId _fitSystemWindows14728;
		protected virtual bool fitSystemWindows(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z", ref global::android.view.View._fitSystemWindows14728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Visibility
		{
			get
			{
				return getVisibility();
			}
			set
			{
				setVisibility(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVisibility14729;
		public virtual int getVisibility()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getVisibility", "()I", ref global::android.view.View._getVisibility14729);
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility14730;
		public virtual void setVisibility(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setVisibility", "(I)V", ref global::android.view.View._setVisibility14730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Focusable
		{
			set
			{
				setFocusable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable14731;
		public virtual void setFocusable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setFocusable", "(Z)V", ref global::android.view.View._setFocusable14731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FocusableInTouchMode
		{
			set
			{
				setFocusableInTouchMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFocusableInTouchMode14732;
		public virtual void setFocusableInTouchMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setFocusableInTouchMode", "(Z)V", ref global::android.view.View._setFocusableInTouchMode14732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool SoundEffectsEnabled
		{
			set
			{
				setSoundEffectsEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSoundEffectsEnabled14733;
		public virtual void setSoundEffectsEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setSoundEffectsEnabled", "(Z)V", ref global::android.view.View._setSoundEffectsEnabled14733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSoundEffectsEnabled14734;
		public virtual bool isSoundEffectsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isSoundEffectsEnabled", "()Z", ref global::android.view.View._isSoundEffectsEnabled14734);
		}
		public new bool HapticFeedbackEnabled
		{
			set
			{
				setHapticFeedbackEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHapticFeedbackEnabled14735;
		public virtual void setHapticFeedbackEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setHapticFeedbackEnabled", "(Z)V", ref global::android.view.View._setHapticFeedbackEnabled14735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHapticFeedbackEnabled14736;
		public virtual bool isHapticFeedbackEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isHapticFeedbackEnabled", "()Z", ref global::android.view.View._isHapticFeedbackEnabled14736);
		}
		internal static global::MonoJavaBridge.MethodId _setWillNotDraw14737;
		public virtual void setWillNotDraw(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setWillNotDraw", "(Z)V", ref global::android.view.View._setWillNotDraw14737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willNotDraw14738;
		public virtual bool willNotDraw()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "willNotDraw", "()Z", ref global::android.view.View._willNotDraw14738);
		}
		internal static global::MonoJavaBridge.MethodId _setWillNotCacheDrawing14739;
		public virtual void setWillNotCacheDrawing(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setWillNotCacheDrawing", "(Z)V", ref global::android.view.View._setWillNotCacheDrawing14739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _willNotCacheDrawing14740;
		public virtual bool willNotCacheDrawing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "willNotCacheDrawing", "()Z", ref global::android.view.View._willNotCacheDrawing14740);
		}
		internal static global::MonoJavaBridge.MethodId _isClickable14741;
		public virtual bool isClickable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isClickable", "()Z", ref global::android.view.View._isClickable14741);
		}
		public new bool Clickable
		{
			set
			{
				setClickable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setClickable14742;
		public virtual void setClickable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setClickable", "(Z)V", ref global::android.view.View._setClickable14742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLongClickable14743;
		public virtual bool isLongClickable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isLongClickable", "()Z", ref global::android.view.View._isLongClickable14743);
		}
		public new bool LongClickable
		{
			set
			{
				setLongClickable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLongClickable14744;
		public virtual void setLongClickable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setLongClickable", "(Z)V", ref global::android.view.View._setLongClickable14744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Pressed
		{
			set
			{
				setPressed(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPressed14745;
		public virtual void setPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setPressed", "(Z)V", ref global::android.view.View._setPressed14745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed14746;
		protected virtual void dispatchSetPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchSetPressed", "(Z)V", ref global::android.view.View._dispatchSetPressed14746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPressed14747;
		public virtual bool isPressed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isPressed", "()Z", ref global::android.view.View._isPressed14747);
		}
		internal static global::MonoJavaBridge.MethodId _isSaveEnabled14748;
		public virtual bool isSaveEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isSaveEnabled", "()Z", ref global::android.view.View._isSaveEnabled14748);
		}
		public new bool SaveEnabled
		{
			set
			{
				setSaveEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSaveEnabled14749;
		public virtual void setSaveEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setSaveEnabled", "(Z)V", ref global::android.view.View._setSaveEnabled14749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocusable14750;
		public virtual bool isFocusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isFocusable", "()Z", ref global::android.view.View._isFocusable14750);
		}
		internal static global::MonoJavaBridge.MethodId _isFocusableInTouchMode14751;
		public virtual bool isFocusableInTouchMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isFocusableInTouchMode", "()Z", ref global::android.view.View._isFocusableInTouchMode14751);
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch14752;
		public virtual global::android.view.View focusSearch(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "focusSearch", "(I)Landroid/view/View;", ref global::android.view.View._focusSearch14752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove14753;
		public virtual bool dispatchUnhandledMove(android.view.View arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z", ref global::android.view.View._dispatchUnhandledMove14753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusables14754;
		public virtual global::java.util.ArrayList getFocusables(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getFocusables", "(I)Ljava/util/ArrayList;", ref global::android.view.View._getFocusables14754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables14755;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V", ref global::android.view.View._addFocusables14755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables14756;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V", ref global::android.view.View._addFocusables14756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.ArrayList Touchables
		{
			get
			{
				return getTouchables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTouchables14757;
		public virtual global::java.util.ArrayList getTouchables()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getTouchables", "()Ljava/util/ArrayList;", ref global::android.view.View._getTouchables14757) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables14758;
		public virtual void addTouchables(java.util.ArrayList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V", ref global::android.view.View._addTouchables14758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus14759;
		public virtual bool requestFocus(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestFocus", "(I)Z", ref global::android.view.View._requestFocus14759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus14760;
		public virtual bool requestFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestFocus", "()Z", ref global::android.view.View._requestFocus14760);
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus14761;
		public virtual bool requestFocus(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z", ref global::android.view.View._requestFocus14761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocusFromTouch14762;
		public virtual bool requestFocusFromTouch()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestFocusFromTouch", "()Z", ref global::android.view.View._requestFocusFromTouch14762);
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach14763;
		public virtual void onStartTemporaryDetach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onStartTemporaryDetach", "()V", ref global::android.view.View._onStartTemporaryDetach14763);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach14764;
		public virtual void onFinishTemporaryDetach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onFinishTemporaryDetach", "()V", ref global::android.view.View._onFinishTemporaryDetach14764);
		}
		public new global::android.view.KeyEvent.DispatcherState KeyDispatcherState
		{
			get
			{
				return getKeyDispatcherState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyDispatcherState14765;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", ref global::android.view.View._getKeyDispatcherState14765) as android.view.KeyEvent.DispatcherState;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEventPreIme14766;
		public virtual bool dispatchKeyEventPreIme(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z", ref global::android.view.View._dispatchKeyEventPreIme14766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyShortcutEvent14767;
		public virtual bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.View._dispatchKeyShortcutEvent14767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged14768;
		public virtual void dispatchWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchWindowFocusChanged", "(Z)V", ref global::android.view.View._dispatchWindowFocusChanged14768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchVisibilityChanged14769;
		protected virtual void dispatchVisibilityChanged(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V", ref global::android.view.View._dispatchVisibilityChanged14769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onVisibilityChanged14770;
		protected virtual void onVisibilityChanged(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V", ref global::android.view.View._onVisibilityChanged14770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDisplayHint14771;
		public virtual void dispatchDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchDisplayHint", "(I)V", ref global::android.view.View._dispatchDisplayHint14771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint14772;
		protected virtual void onDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onDisplayHint", "(I)V", ref global::android.view.View._onDisplayHint14772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowVisibilityChanged14773;
		public virtual void dispatchWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchWindowVisibilityChanged", "(I)V", ref global::android.view.View._dispatchWindowVisibilityChanged14773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged14774;
		protected virtual void onWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onWindowVisibilityChanged", "(I)V", ref global::android.view.View._onWindowVisibilityChanged14774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WindowVisibility
		{
			get
			{
				return getWindowVisibility();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowVisibility14775;
		public virtual int getWindowVisibility()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getWindowVisibility", "()I", ref global::android.view.View._getWindowVisibility14775);
		}
		internal static global::MonoJavaBridge.MethodId _getWindowVisibleDisplayFrame14776;
		public virtual void getWindowVisibleDisplayFrame(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V", ref global::android.view.View._getWindowVisibleDisplayFrame14776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchConfigurationChanged14777;
		public virtual void dispatchConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.view.View._dispatchConfigurationChanged14777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInTouchMode14778;
		public virtual bool isInTouchMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isInTouchMode", "()Z", ref global::android.view.View._isInTouchMode14778);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyPreIme14779;
		public virtual bool onKeyPreIme(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._onKeyPreIme14779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut14780;
		public virtual bool onKeyShortcut(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._onKeyShortcut14780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor14781;
		public virtual bool onCheckIsTextEditor()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onCheckIsTextEditor", "()Z", ref global::android.view.View._onCheckIsTextEditor14781);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection14782;
		public virtual global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.view.View.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;", ref global::android.view.View._onCreateInputConnection14782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _checkInputConnectionProxy14783;
		public virtual bool checkInputConnectionProxy(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z", ref global::android.view.View._checkInputConnectionProxy14783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createContextMenu14784;
		public virtual void createContextMenu(android.view.ContextMenu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V", ref global::android.view.View._createContextMenu14784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.ContextMenu_ContextMenuInfo ContextMenuInfo
		{
			get
			{
				return getContextMenuInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo14785;
		protected virtual global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu_ContextMenuInfo>(this, global::android.view.View.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", ref global::android.view.View._getContextMenuInfo14785) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress14786;
		public virtual void cancelLongPress()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "cancelLongPress", "()V", ref global::android.view.View._cancelLongPress14786);
		}
		internal static global::MonoJavaBridge.MethodId _setTouchDelegate14787;
		public virtual void setTouchDelegate(android.view.TouchDelegate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setTouchDelegate", "(Landroid/view/TouchDelegate;)V", ref global::android.view.View._setTouchDelegate14787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.TouchDelegate TouchDelegate
		{
			get
			{
				return getTouchDelegate();
			}
			set
			{
				setTouchDelegate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTouchDelegate14788;
		public virtual global::android.view.TouchDelegate getTouchDelegate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getTouchDelegate", "()Landroid/view/TouchDelegate;", ref global::android.view.View._getTouchDelegate14788) as android.view.TouchDelegate;
		}
		internal static global::MonoJavaBridge.MethodId _bringToFront14789;
		public virtual void bringToFront()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "bringToFront", "()V", ref global::android.view.View._bringToFront14789);
		}
		internal static global::MonoJavaBridge.MethodId _onScrollChanged14790;
		protected virtual void onScrollChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onScrollChanged", "(IIII)V", ref global::android.view.View._onScrollChanged14790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged14791;
		protected virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onSizeChanged", "(IIII)V", ref global::android.view.View._onSizeChanged14791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw14792;
		protected virtual void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.view.View._dispatchDraw14792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ScrollX
		{
			get
			{
				return getScrollX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollX14793;
		public virtual int getScrollX()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getScrollX", "()I", ref global::android.view.View._getScrollX14793);
		}
		public new int ScrollY
		{
			get
			{
				return getScrollY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollY14794;
		public virtual int getScrollY()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getScrollY", "()I", ref global::android.view.View._getScrollY14794);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingRect14795;
		public virtual void getDrawingRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getDrawingRect", "(Landroid/graphics/Rect;)V", ref global::android.view.View._getDrawingRect14795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MeasuredWidth
		{
			get
			{
				return getMeasuredWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMeasuredWidth14796;
		public virtual int getMeasuredWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getMeasuredWidth", "()I", ref global::android.view.View._getMeasuredWidth14796);
		}
		public new int MeasuredHeight
		{
			get
			{
				return getMeasuredHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMeasuredHeight14797;
		public virtual int getMeasuredHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getMeasuredHeight", "()I", ref global::android.view.View._getMeasuredHeight14797);
		}
		public new int Top
		{
			get
			{
				return getTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTop14798;
		public virtual int getTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getTop", "()I", ref global::android.view.View._getTop14798);
		}
		public new int Bottom
		{
			get
			{
				return getBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottom14799;
		public virtual int getBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getBottom", "()I", ref global::android.view.View._getBottom14799);
		}
		public new int Left
		{
			get
			{
				return getLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeft14800;
		public virtual int getLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getLeft", "()I", ref global::android.view.View._getLeft14800);
		}
		public new int Right
		{
			get
			{
				return getRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRight14801;
		public virtual int getRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getRight", "()I", ref global::android.view.View._getRight14801);
		}
		internal static global::MonoJavaBridge.MethodId _getHitRect14802;
		public virtual void getHitRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getHitRect", "(Landroid/graphics/Rect;)V", ref global::android.view.View._getHitRect14802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect14803;
		public virtual void getFocusedRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V", ref global::android.view.View._getFocusedRect14803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalVisibleRect14804;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0, android.graphics.Point arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z", ref global::android.view.View._getGlobalVisibleRect14804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalVisibleRect14805;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z", ref global::android.view.View._getGlobalVisibleRect14805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalVisibleRect14806;
		public virtual bool getLocalVisibleRect(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "getLocalVisibleRect", "(Landroid/graphics/Rect;)Z", ref global::android.view.View._getLocalVisibleRect14806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetTopAndBottom14807;
		public virtual void offsetTopAndBottom(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "offsetTopAndBottom", "(I)V", ref global::android.view.View._offsetTopAndBottom14807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetLeftAndRight14808;
		public virtual void offsetLeftAndRight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "offsetLeftAndRight", "(I)V", ref global::android.view.View._offsetLeftAndRight14808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.ViewGroup.LayoutParams LayoutParams
		{
			get
			{
				return getLayoutParams();
			}
			set
			{
				setLayoutParams(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutParams14809;
		public virtual global::android.view.ViewGroup.LayoutParams getLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.view.View._getLayoutParams14809) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutParams14810;
		public virtual void setLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.View._setLayoutParams14810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo14811;
		public virtual void scrollTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "scrollTo", "(II)V", ref global::android.view.View._scrollTo14811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scrollBy14812;
		public virtual void scrollBy(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "scrollBy", "(II)V", ref global::android.view.View._scrollBy14812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars14813;
		protected virtual bool awakenScrollBars(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "awakenScrollBars", "(IZ)Z", ref global::android.view.View._awakenScrollBars14813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars14814;
		protected virtual bool awakenScrollBars()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "awakenScrollBars", "()Z", ref global::android.view.View._awakenScrollBars14814);
		}
		internal static global::MonoJavaBridge.MethodId _awakenScrollBars14815;
		protected virtual bool awakenScrollBars(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "awakenScrollBars", "(I)Z", ref global::android.view.View._awakenScrollBars14815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate14816;
		public virtual void postInvalidate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "postInvalidate", "(IIII)V", ref global::android.view.View._postInvalidate14816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate14817;
		public virtual void postInvalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "postInvalidate", "()V", ref global::android.view.View._postInvalidate14817);
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidateDelayed14818;
		public virtual void postInvalidateDelayed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "postInvalidateDelayed", "(J)V", ref global::android.view.View._postInvalidateDelayed14818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidateDelayed14819;
		public virtual void postInvalidateDelayed(long arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "postInvalidateDelayed", "(JIIII)V", ref global::android.view.View._postInvalidateDelayed14819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll14820;
		public virtual void computeScroll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "computeScroll", "()V", ref global::android.view.View._computeScroll14820);
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontalFadingEdgeEnabled14821;
		public virtual bool isHorizontalFadingEdgeEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isHorizontalFadingEdgeEnabled", "()Z", ref global::android.view.View._isHorizontalFadingEdgeEnabled14821);
		}
		public new bool HorizontalFadingEdgeEnabled
		{
			set
			{
				setHorizontalFadingEdgeEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalFadingEdgeEnabled14822;
		public virtual void setHorizontalFadingEdgeEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setHorizontalFadingEdgeEnabled", "(Z)V", ref global::android.view.View._setHorizontalFadingEdgeEnabled14822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVerticalFadingEdgeEnabled14823;
		public virtual bool isVerticalFadingEdgeEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isVerticalFadingEdgeEnabled", "()Z", ref global::android.view.View._isVerticalFadingEdgeEnabled14823);
		}
		public new bool VerticalFadingEdgeEnabled
		{
			set
			{
				setVerticalFadingEdgeEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalFadingEdgeEnabled14824;
		public virtual void setVerticalFadingEdgeEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setVerticalFadingEdgeEnabled", "(Z)V", ref global::android.view.View._setVerticalFadingEdgeEnabled14824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new float TopFadingEdgeStrength
		{
			get
			{
				return getTopFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength14825;
		protected virtual float getTopFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.View.staticClass, "getTopFadingEdgeStrength", "()F", ref global::android.view.View._getTopFadingEdgeStrength14825);
		}
		protected new float BottomFadingEdgeStrength
		{
			get
			{
				return getBottomFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength14826;
		protected virtual float getBottomFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.View.staticClass, "getBottomFadingEdgeStrength", "()F", ref global::android.view.View._getBottomFadingEdgeStrength14826);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength14827;
		protected virtual float getLeftFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.View.staticClass, "getLeftFadingEdgeStrength", "()F", ref global::android.view.View._getLeftFadingEdgeStrength14827);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength14828;
		protected virtual float getRightFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.View.staticClass, "getRightFadingEdgeStrength", "()F", ref global::android.view.View._getRightFadingEdgeStrength14828);
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontalScrollBarEnabled14829;
		public virtual bool isHorizontalScrollBarEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isHorizontalScrollBarEnabled", "()Z", ref global::android.view.View._isHorizontalScrollBarEnabled14829);
		}
		public new bool HorizontalScrollBarEnabled
		{
			set
			{
				setHorizontalScrollBarEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalScrollBarEnabled14830;
		public virtual void setHorizontalScrollBarEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setHorizontalScrollBarEnabled", "(Z)V", ref global::android.view.View._setHorizontalScrollBarEnabled14830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVerticalScrollBarEnabled14831;
		public virtual bool isVerticalScrollBarEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isVerticalScrollBarEnabled", "()Z", ref global::android.view.View._isVerticalScrollBarEnabled14831);
		}
		public new bool VerticalScrollBarEnabled
		{
			set
			{
				setVerticalScrollBarEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalScrollBarEnabled14832;
		public virtual void setVerticalScrollBarEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setVerticalScrollBarEnabled", "(Z)V", ref global::android.view.View._setVerticalScrollBarEnabled14832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ScrollbarFadingEnabled
		{
			set
			{
				setScrollbarFadingEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setScrollbarFadingEnabled14833;
		public virtual void setScrollbarFadingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setScrollbarFadingEnabled", "(Z)V", ref global::android.view.View._setScrollbarFadingEnabled14833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScrollbarFadingEnabled14834;
		public virtual bool isScrollbarFadingEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isScrollbarFadingEnabled", "()Z", ref global::android.view.View._isScrollbarFadingEnabled14834);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollBarStyle14835;
		public virtual void setScrollBarStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setScrollBarStyle", "(I)V", ref global::android.view.View._setScrollBarStyle14835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ScrollBarStyle
		{
			get
			{
				return getScrollBarStyle();
			}
			set
			{
				setScrollBarStyle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarStyle14836;
		public virtual int getScrollBarStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getScrollBarStyle", "()I", ref global::android.view.View._getScrollBarStyle14836);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange14837;
		protected virtual int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeHorizontalScrollRange", "()I", ref global::android.view.View._computeHorizontalScrollRange14837);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset14838;
		protected virtual int computeHorizontalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeHorizontalScrollOffset", "()I", ref global::android.view.View._computeHorizontalScrollOffset14838);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollExtent14839;
		protected virtual int computeHorizontalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeHorizontalScrollExtent", "()I", ref global::android.view.View._computeHorizontalScrollExtent14839);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange14840;
		protected virtual int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeVerticalScrollRange", "()I", ref global::android.view.View._computeVerticalScrollRange14840);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset14841;
		protected virtual int computeVerticalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeVerticalScrollOffset", "()I", ref global::android.view.View._computeVerticalScrollOffset14841);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent14842;
		protected virtual int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeVerticalScrollExtent", "()I", ref global::android.view.View._computeVerticalScrollExtent14842);
		}
		internal static global::MonoJavaBridge.MethodId _onDrawScrollBars14843;
		protected virtual void onDrawScrollBars(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onDrawScrollBars", "(Landroid/graphics/Canvas;)V", ref global::android.view.View._onDrawScrollBars14843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw14844;
		protected virtual void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.view.View._onDraw14844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new int WindowAttachCount
		{
			get
			{
				return getWindowAttachCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowAttachCount14845;
		protected virtual int getWindowAttachCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getWindowAttachCount", "()I", ref global::android.view.View._getWindowAttachCount14845);
		}
		public new global::android.os.IBinder WindowToken
		{
			get
			{
				return getWindowToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowToken14846;
		public virtual global::android.os.IBinder getWindowToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.view.View.staticClass, "getWindowToken", "()Landroid/os/IBinder;", ref global::android.view.View._getWindowToken14846) as android.os.IBinder;
		}
		public new global::android.os.IBinder ApplicationWindowToken
		{
			get
			{
				return getApplicationWindowToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationWindowToken14847;
		public virtual global::android.os.IBinder getApplicationWindowToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.view.View.staticClass, "getApplicationWindowToken", "()Landroid/os/IBinder;", ref global::android.view.View._getApplicationWindowToken14847) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState14848;
		protected virtual void dispatchSaveInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.view.View._dispatchSaveInstanceState14848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState14849;
		protected virtual void dispatchRestoreInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.view.View._dispatchRestoreInstanceState14849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long DrawingTime
		{
			get
			{
				return getDrawingTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingTime14850;
		public virtual long getDrawingTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.View.staticClass, "getDrawingTime", "()J", ref global::android.view.View._getDrawingTime14850);
		}
		public new bool DuplicateParentStateEnabled
		{
			set
			{
				setDuplicateParentStateEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDuplicateParentStateEnabled14851;
		public virtual void setDuplicateParentStateEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setDuplicateParentStateEnabled", "(Z)V", ref global::android.view.View._setDuplicateParentStateEnabled14851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDuplicateParentStateEnabled14852;
		public virtual bool isDuplicateParentStateEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isDuplicateParentStateEnabled", "()Z", ref global::android.view.View._isDuplicateParentStateEnabled14852);
		}
		public new bool DrawingCacheEnabled
		{
			set
			{
				setDrawingCacheEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheEnabled14853;
		public virtual void setDrawingCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setDrawingCacheEnabled", "(Z)V", ref global::android.view.View._setDrawingCacheEnabled14853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDrawingCacheEnabled14854;
		public virtual bool isDrawingCacheEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isDrawingCacheEnabled", "()Z", ref global::android.view.View._isDrawingCacheEnabled14854);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCache14855;
		public virtual global::android.graphics.Bitmap getDrawingCache(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.view.View.staticClass, "getDrawingCache", "(Z)Landroid/graphics/Bitmap;", ref global::android.view.View._getDrawingCache14855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Bitmap;
		}
		public new global::android.graphics.Bitmap DrawingCache
		{
			get
			{
				return getDrawingCache();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCache14856;
		public virtual global::android.graphics.Bitmap getDrawingCache()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.view.View.staticClass, "getDrawingCache", "()Landroid/graphics/Bitmap;", ref global::android.view.View._getDrawingCache14856) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _destroyDrawingCache14857;
		public virtual void destroyDrawingCache()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "destroyDrawingCache", "()V", ref global::android.view.View._destroyDrawingCache14857);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawingCacheBackgroundColor14858;
		public virtual void setDrawingCacheBackgroundColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setDrawingCacheBackgroundColor", "(I)V", ref global::android.view.View._setDrawingCacheBackgroundColor14858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DrawingCacheBackgroundColor
		{
			get
			{
				return getDrawingCacheBackgroundColor();
			}
			set
			{
				setDrawingCacheBackgroundColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawingCacheBackgroundColor14859;
		public virtual int getDrawingCacheBackgroundColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getDrawingCacheBackgroundColor", "()I", ref global::android.view.View._getDrawingCacheBackgroundColor14859);
		}
		internal static global::MonoJavaBridge.MethodId _buildDrawingCache14860;
		public virtual void buildDrawingCache()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "buildDrawingCache", "()V", ref global::android.view.View._buildDrawingCache14860);
		}
		internal static global::MonoJavaBridge.MethodId _buildDrawingCache14861;
		public virtual void buildDrawingCache(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "buildDrawingCache", "(Z)V", ref global::android.view.View._buildDrawingCache14861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInEditMode14862;
		public virtual bool isInEditMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isInEditMode", "()Z", ref global::android.view.View._isInEditMode14862);
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired14863;
		protected virtual bool isPaddingOffsetRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isPaddingOffsetRequired", "()Z", ref global::android.view.View._isPaddingOffsetRequired14863);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset14864;
		protected virtual int getLeftPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getLeftPaddingOffset", "()I", ref global::android.view.View._getLeftPaddingOffset14864);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset14865;
		protected virtual int getRightPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getRightPaddingOffset", "()I", ref global::android.view.View._getRightPaddingOffset14865);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset14866;
		protected virtual int getTopPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getTopPaddingOffset", "()I", ref global::android.view.View._getTopPaddingOffset14866);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset14867;
		protected virtual int getBottomPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getBottomPaddingOffset", "()I", ref global::android.view.View._getBottomPaddingOffset14867);
		}
		public new int SolidColor
		{
			get
			{
				return getSolidColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSolidColor14868;
		public virtual int getSolidColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getSolidColor", "()I", ref global::android.view.View._getSolidColor14868);
		}
		internal static global::MonoJavaBridge.MethodId _isLayoutRequested14869;
		public virtual bool isLayoutRequested()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isLayoutRequested", "()Z", ref global::android.view.View._isLayoutRequested14869);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout14870;
		protected virtual void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onLayout", "(ZIIII)V", ref global::android.view.View._onLayout14870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate14871;
		protected virtual void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onFinishInflate", "()V", ref global::android.view.View._onFinishInflate14871);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable14872;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.view.View._invalidateDrawable14872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable14873;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", ref global::android.view.View._scheduleDrawable14873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void scheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1, long arg2)
		{
			scheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable14874;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", ref global::android.view.View._unscheduleDrawable14874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void unscheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1)
		{
			unscheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable14875;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.view.View._unscheduleDrawable14875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable14876;
		protected virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.view.View._verifyDrawable14876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged14877;
		protected virtual void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "drawableStateChanged", "()V", ref global::android.view.View._drawableStateChanged14877);
		}
		internal static global::MonoJavaBridge.MethodId _refreshDrawableState14878;
		public virtual void refreshDrawableState()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "refreshDrawableState", "()V", ref global::android.view.View._refreshDrawableState14878);
		}
		public new int[] DrawableState
		{
			get
			{
				return getDrawableState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawableState14879;
		public virtual int[] getDrawableState()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.view.View.staticClass, "getDrawableState", "()[I", ref global::android.view.View._getDrawableState14879) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState14880;
		protected virtual int[] onCreateDrawableState(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.view.View.staticClass, "onCreateDrawableState", "(I)[I", ref global::android.view.View._onCreateDrawableState14880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _mergeDrawableStates14881;
		protected static int[] mergeDrawableStates(int[] arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._mergeDrawableStates14881.native == global::System.IntPtr.Zero)
				global::android.view.View._mergeDrawableStates14881 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "mergeDrawableStates", "([I[I)[I");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._mergeDrawableStates14881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		public new int BackgroundColor
		{
			set
			{
				setBackgroundColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundColor14882;
		public virtual void setBackgroundColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setBackgroundColor", "(I)V", ref global::android.view.View._setBackgroundColor14882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BackgroundResource
		{
			set
			{
				setBackgroundResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundResource14883;
		public virtual void setBackgroundResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setBackgroundResource", "(I)V", ref global::android.view.View._setBackgroundResource14883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable Background
		{
			get
			{
				return getBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackground14884;
		public virtual global::android.graphics.drawable.Drawable getBackground()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;", ref global::android.view.View._getBackground14884) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setPadding14885;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setPadding", "(IIII)V", ref global::android.view.View._setPadding14885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int PaddingTop
		{
			get
			{
				return getPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingTop14886;
		public virtual int getPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getPaddingTop", "()I", ref global::android.view.View._getPaddingTop14886);
		}
		public new int PaddingBottom
		{
			get
			{
				return getPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingBottom14887;
		public virtual int getPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getPaddingBottom", "()I", ref global::android.view.View._getPaddingBottom14887);
		}
		public new int PaddingLeft
		{
			get
			{
				return getPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingLeft14888;
		public virtual int getPaddingLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getPaddingLeft", "()I", ref global::android.view.View._getPaddingLeft14888);
		}
		public new int PaddingRight
		{
			get
			{
				return getPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaddingRight14889;
		public virtual int getPaddingRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getPaddingRight", "()I", ref global::android.view.View._getPaddingRight14889);
		}
		public new bool Selected
		{
			set
			{
				setSelected(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelected14890;
		public virtual void setSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setSelected", "(Z)V", ref global::android.view.View._setSelected14890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected14891;
		protected virtual void dispatchSetSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchSetSelected", "(Z)V", ref global::android.view.View._dispatchSetSelected14891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSelected14892;
		public virtual bool isSelected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isSelected", "()Z", ref global::android.view.View._isSelected14892);
		}
		public new global::android.view.ViewTreeObserver ViewTreeObserver
		{
			get
			{
				return getViewTreeObserver();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getViewTreeObserver14893;
		public virtual global::android.view.ViewTreeObserver getViewTreeObserver()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.view.ViewTreeObserver>(this, global::android.view.View.staticClass, "getViewTreeObserver", "()Landroid/view/ViewTreeObserver;", ref global::android.view.View._getViewTreeObserver14893) as android.view.ViewTreeObserver;
		}
		public new global::android.view.View RootView
		{
			get
			{
				return getRootView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRootView14894;
		public virtual global::android.view.View getRootView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getRootView", "()Landroid/view/View;", ref global::android.view.View._getRootView14894) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getLocationOnScreen14895;
		public virtual void getLocationOnScreen(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getLocationOnScreen", "([I)V", ref global::android.view.View._getLocationOnScreen14895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocationInWindow14896;
		public virtual void getLocationInWindow(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getLocationInWindow", "([I)V", ref global::android.view.View._getLocationInWindow14896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewWithTag14897;
		public virtual global::android.view.View findViewWithTag(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;", ref global::android.view.View._findViewWithTag14897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setId14898;
		public virtual void setId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setId", "(I)V", ref global::android.view.View._setId14898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTag14899;
		public virtual void setTag(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setTag", "(ILjava/lang/Object;)V", ref global::android.view.View._setTag14899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTag14900;
		public virtual void setTag(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setTag", "(Ljava/lang/Object;)V", ref global::android.view.View._setTag14900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline14901;
		public virtual int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getBaseline", "()I", ref global::android.view.View._getBaseline14901);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout14902;
		public virtual void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "requestLayout", "()V", ref global::android.view.View._requestLayout14902);
		}
		internal static global::MonoJavaBridge.MethodId _forceLayout14903;
		public virtual void forceLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "forceLayout", "()V", ref global::android.view.View._forceLayout14903);
		}
		internal static global::MonoJavaBridge.MethodId _measure14904;
		public virtual void measure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "measure", "(II)V", ref global::android.view.View._measure14904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure14905;
		protected virtual void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onMeasure", "(II)V", ref global::android.view.View._onMeasure14905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMeasuredDimension14906;
		protected virtual void setMeasuredDimension(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setMeasuredDimension", "(II)V", ref global::android.view.View._setMeasuredDimension14906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resolveSize14907;
		public static int resolveSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._resolveSize14907.native == global::System.IntPtr.Zero)
				global::android.view.View._resolveSize14907 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "resolveSize", "(II)I");
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._resolveSize14907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSize14908;
		public static int getDefaultSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._getDefaultSize14908.native == global::System.IntPtr.Zero)
				global::android.view.View._getDefaultSize14908 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "getDefaultSize", "(II)I");
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._getDefaultSize14908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new int SuggestedMinimumHeight
		{
			get
			{
				return getSuggestedMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestedMinimumHeight14909;
		protected virtual int getSuggestedMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getSuggestedMinimumHeight", "()I", ref global::android.view.View._getSuggestedMinimumHeight14909);
		}
		protected new int SuggestedMinimumWidth
		{
			get
			{
				return getSuggestedMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuggestedMinimumWidth14910;
		protected virtual int getSuggestedMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getSuggestedMinimumWidth", "()I", ref global::android.view.View._getSuggestedMinimumWidth14910);
		}
		public new int MinimumHeight
		{
			set
			{
				setMinimumHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumHeight14911;
		public virtual void setMinimumHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setMinimumHeight", "(I)V", ref global::android.view.View._setMinimumHeight14911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinimumWidth
		{
			set
			{
				setMinimumWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumWidth14912;
		public virtual void setMinimumWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setMinimumWidth", "(I)V", ref global::android.view.View._setMinimumWidth14912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startAnimation14913;
		public virtual void startAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "startAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.view.View._startAnimation14913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearAnimation14914;
		public virtual void clearAnimation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "clearAnimation", "()V", ref global::android.view.View._clearAnimation14914);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimation14915;
		public virtual void setAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.view.View._setAnimation14915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationStart14916;
		protected virtual void onAnimationStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onAnimationStart", "()V", ref global::android.view.View._onAnimationStart14916);
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationEnd14917;
		protected virtual void onAnimationEnd()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onAnimationEnd", "()V", ref global::android.view.View._onAnimationEnd14917);
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha14918;
		protected virtual bool onSetAlpha(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onSetAlpha", "(I)Z", ref global::android.view.View._onSetAlpha14918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect14919;
		public virtual void playSoundEffect(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "playSoundEffect", "(I)V", ref global::android.view.View._playSoundEffect14919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performHapticFeedback14920;
		public virtual bool performHapticFeedback(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "performHapticFeedback", "(I)Z", ref global::android.view.View._performHapticFeedback14920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performHapticFeedback14921;
		public virtual bool performHapticFeedback(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "performHapticFeedback", "(II)Z", ref global::android.view.View._performHapticFeedback14921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _View14922;
		public View(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._View14922.native == global::System.IntPtr.Zero)
				global::android.view.View._View14922 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View14922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _View14923;
		public View(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._View14923.native == global::System.IntPtr.Zero)
				global::android.view.View._View14923 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View14923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _View14924;
		public View(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._View14924.native == global::System.IntPtr.Zero)
				global::android.view.View._View14924 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._View14924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int NO_ID
		{
			get
			{
				return -1;
			}
		}
		public static int VISIBLE
		{
			get
			{
				return 0;
			}
		}
		public static int INVISIBLE
		{
			get
			{
				return 4;
			}
		}
		public static int GONE
		{
			get
			{
				return 8;
			}
		}
		public static int DRAWING_CACHE_QUALITY_LOW
		{
			get
			{
				return 524288;
			}
		}
		public static int DRAWING_CACHE_QUALITY_HIGH
		{
			get
			{
				return 1048576;
			}
		}
		public static int DRAWING_CACHE_QUALITY_AUTO
		{
			get
			{
				return 0;
			}
		}
		public static int SCROLLBARS_INSIDE_OVERLAY
		{
			get
			{
				return 0;
			}
		}
		public static int SCROLLBARS_INSIDE_INSET
		{
			get
			{
				return 16777216;
			}
		}
		public static int SCROLLBARS_OUTSIDE_OVERLAY
		{
			get
			{
				return 33554432;
			}
		}
		public static int SCROLLBARS_OUTSIDE_INSET
		{
			get
			{
				return 50331648;
			}
		}
		public static int KEEP_SCREEN_ON
		{
			get
			{
				return 67108864;
			}
		}
		public static int SOUND_EFFECTS_ENABLED
		{
			get
			{
				return 134217728;
			}
		}
		public static int HAPTIC_FEEDBACK_ENABLED
		{
			get
			{
				return 268435456;
			}
		}
		public static int FOCUSABLES_ALL
		{
			get
			{
				return 0;
			}
		}
		public static int FOCUSABLES_TOUCH_MODE
		{
			get
			{
				return 1;
			}
		}
		public static int FOCUS_BACKWARD
		{
			get
			{
				return 1;
			}
		}
		public static int FOCUS_FORWARD
		{
			get
			{
				return 2;
			}
		}
		public static int FOCUS_LEFT
		{
			get
			{
				return 17;
			}
		}
		public static int FOCUS_UP
		{
			get
			{
				return 33;
			}
		}
		public static int FOCUS_RIGHT
		{
			get
			{
				return 66;
			}
		}
		public static int FOCUS_DOWN
		{
			get
			{
				return 130;
			}
		}
		static View()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.View.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View"));
		}
		internal static void InitJNI()
		{
		}
	}
}
