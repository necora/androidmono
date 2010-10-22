namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServerSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServerSocket()
		{
			InitJNI();
		}
		protected ServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString21579;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._toString21579)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._toString21579)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close21580;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._close21580);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._close21580);
		}
		internal static global::MonoJavaBridge.MethodId _accept21581;
		public virtual global::java.net.Socket accept() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._accept21581)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._accept21581)) as java.net.Socket;
		}
		public new global::java.nio.channels.ServerSocketChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel21582;
		public virtual global::java.nio.channels.ServerSocketChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getChannel21582)) as java.nio.channels.ServerSocketChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getChannel21582)) as java.nio.channels.ServerSocketChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isClosed21583;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._isClosed21583);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._isClosed21583);
		}
		internal static global::MonoJavaBridge.MethodId _bind21584;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._bind21584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._bind21584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind21585;
		public virtual void bind(java.net.SocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._bind21585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._bind21585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress21586;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getLocalSocketAddress21586)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getLocalSocketAddress21586)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize21587;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setReceiveBufferSize21587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setReceiveBufferSize21587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ReceiveBufferSize
		{
			get
			{
				return getReceiveBufferSize();
			}
			set
			{
				setReceiveBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize21588;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getReceiveBufferSize21588);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getReceiveBufferSize21588);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout21589;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setSoTimeout21589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setSoTimeout21589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SoTimeout
		{
			get
			{
				return getSoTimeout();
			}
			set
			{
				setSoTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout21590;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getSoTimeout21590);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getSoTimeout21590);
		}
		internal static global::MonoJavaBridge.MethodId _isBound21591;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._isBound21591);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._isBound21591);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21592;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ServerSocket._getInetAddress21592)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getInetAddress21592)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21593;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.ServerSocket._getLocalPort21593);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getLocalPort21593);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress21594;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setReuseAddress21594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setReuseAddress21594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ReuseAddress
		{
			get
			{
				return getReuseAddress();
			}
			set
			{
				setReuseAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReuseAddress21595;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.ServerSocket._getReuseAddress21595);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._getReuseAddress21595);
		}
		internal static global::MonoJavaBridge.MethodId _setPerformancePreferences21596;
		public virtual void setPerformancePreferences(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._setPerformancePreferences21596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setPerformancePreferences21596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _implAccept21597;
		protected virtual void implAccept(java.net.Socket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.ServerSocket._implAccept21597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.ServerSocket.staticClass, global::java.net.ServerSocket._implAccept21597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketFactory21598;
		public static void setSocketFactory(java.net.SocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._setSocketFactory21598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket21599;
		public ServerSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket21599);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket21600;
		public ServerSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket21600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket21601;
		public ServerSocket(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket21601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServerSocket21602;
		public ServerSocket(int arg0, int arg1, java.net.InetAddress arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ServerSocket.staticClass, global::java.net.ServerSocket._ServerSocket21602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ServerSocket"));
			global::java.net.ServerSocket._toString21579 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.ServerSocket._close21580 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "close", "()V");
			global::java.net.ServerSocket._accept21581 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "accept", "()Ljava/net/Socket;");
			global::java.net.ServerSocket._getChannel21582 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getChannel", "()Ljava/nio/channels/ServerSocketChannel;");
			global::java.net.ServerSocket._isClosed21583 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "isClosed", "()Z");
			global::java.net.ServerSocket._bind21584 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.ServerSocket._bind21585 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "bind", "(Ljava/net/SocketAddress;I)V");
			global::java.net.ServerSocket._getLocalSocketAddress21586 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.ServerSocket._setReceiveBufferSize21587 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.ServerSocket._getReceiveBufferSize21588 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.ServerSocket._setSoTimeout21589 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.ServerSocket._getSoTimeout21590 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getSoTimeout", "()I");
			global::java.net.ServerSocket._isBound21591 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "isBound", "()Z");
			global::java.net.ServerSocket._getInetAddress21592 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.ServerSocket._getLocalPort21593 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getLocalPort", "()I");
			global::java.net.ServerSocket._setReuseAddress21594 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.ServerSocket._getReuseAddress21595 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "getReuseAddress", "()Z");
			global::java.net.ServerSocket._setPerformancePreferences21596 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setPerformancePreferences", "(III)V");
			global::java.net.ServerSocket._implAccept21597 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "implAccept", "(Ljava/net/Socket;)V");
			global::java.net.ServerSocket._setSocketFactory21598 = @__env.GetStaticMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "setSocketFactory", "(Ljava/net/SocketImplFactory;)V");
			global::java.net.ServerSocket._ServerSocket21599 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "()V");
			global::java.net.ServerSocket._ServerSocket21600 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(I)V");
			global::java.net.ServerSocket._ServerSocket21601 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(II)V");
			global::java.net.ServerSocket._ServerSocket21602 = @__env.GetMethodIDNoThrow(global::java.net.ServerSocket.staticClass, "<init>", "(IILjava/net/InetAddress;)V");
		}
	}
}