namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothSocket : java.lang.Object, java.io.Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BluetoothSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close2553;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, "close", "()V", ref global::android.bluetooth.BluetoothSocket._close2553);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream2554;
		public global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.bluetooth.BluetoothSocket._getInputStream2554) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _connect2555;
		public void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, "connect", "()V", ref global::android.bluetooth.BluetoothSocket._connect2555);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream2556;
		public global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::android.bluetooth.BluetoothSocket._getOutputStream2556) as java.io.OutputStream;
		}
		public new global::android.bluetooth.BluetoothDevice RemoteDevice
		{
			get
			{
				return getRemoteDevice();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteDevice2557;
		public global::android.bluetooth.BluetoothDevice getRemoteDevice()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothDevice>(this, global::android.bluetooth.BluetoothSocket.staticClass, "getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;", ref global::android.bluetooth.BluetoothSocket._getRemoteDevice2557) as android.bluetooth.BluetoothDevice;
		}
		static BluetoothSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
