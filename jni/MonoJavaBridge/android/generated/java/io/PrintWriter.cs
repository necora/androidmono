namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrintWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrintWriter()
		{
			InitJNI();
		}
		protected PrintWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println12660;
		public virtual void println(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println12661;
		public virtual void println() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12661);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12661);
		}
		internal static global::MonoJavaBridge.MethodId _println12662;
		public virtual void println(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println12663;
		public virtual void println(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println12664;
		public virtual void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println12665;
		public virtual void println(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println12666;
		public virtual void println(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println12667;
		public virtual void println(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println12668;
		public virtual void println(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println12669;
		public virtual void println(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println12669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append12670;
		public virtual new global::java.io.PrintWriter append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append12670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append12670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
		}
		public java.io.PrintWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append12671;
		public virtual new global::java.io.PrintWriter append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append12671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append12671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		public java.io.PrintWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append12672;
		public virtual new global::java.io.PrintWriter append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append12672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append12672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _format12673;
		public virtual global::java.io.PrintWriter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._format12673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format12673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _format12674;
		public virtual global::java.io.PrintWriter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._format12674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format12674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _write12675;
		public override void write(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write12675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12676;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write12676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write12677;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write12677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12678;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write12678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write12679;
		public override void write(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write12679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12680;
		public virtual void print(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12681;
		public virtual void print(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12682;
		public virtual void print(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12683;
		public virtual void print(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12684;
		public virtual void print(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12685;
		public virtual void print(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12686;
		public virtual void print(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12687;
		public virtual void print(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print12688;
		public virtual void print(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print12688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush12689;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._flush12689);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._flush12689);
		}
		internal static global::MonoJavaBridge.MethodId _close12690;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._close12690);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._close12690);
		}
		internal static global::MonoJavaBridge.MethodId _checkError12691;
		public virtual bool checkError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PrintWriter._checkError12691);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._checkError12691);
		}
		internal static global::MonoJavaBridge.MethodId _setError12692;
		protected virtual void setError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._setError12692);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._setError12692);
		}
		internal static global::MonoJavaBridge.MethodId _clearError12693;
		protected virtual void clearError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._clearError12693);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._clearError12693);
		}
		internal static global::MonoJavaBridge.MethodId _printf12694;
		public virtual global::java.io.PrintWriter printf(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._printf12694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf12694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _printf12695;
		public virtual global::java.io.PrintWriter printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._printf12695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf12695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter12696;
		public PrintWriter(java.io.Writer arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter12697;
		public PrintWriter(java.io.OutputStream arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter12698;
		public PrintWriter(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter12699;
		public PrintWriter(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter12700;
		public PrintWriter(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter12701;
		public PrintWriter(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter12702;
		public PrintWriter(java.io.Writer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter12703;
		public PrintWriter(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PrintWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PrintWriter"));
			global::java.io.PrintWriter._println12660 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(C)V");
			global::java.io.PrintWriter._println12661 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "()V");
			global::java.io.PrintWriter._println12662 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Z)V");
			global::java.io.PrintWriter._println12663 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._println12664 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._println12665 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "([C)V");
			global::java.io.PrintWriter._println12666 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(D)V");
			global::java.io.PrintWriter._println12667 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(F)V");
			global::java.io.PrintWriter._println12668 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(J)V");
			global::java.io.PrintWriter._println12669 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(I)V");
			global::java.io.PrintWriter._append12670 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append12671 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append12672 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(C)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format12673 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format12674 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._write12675 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "([C)V");
			global::java.io.PrintWriter._write12676 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "([CII)V");
			global::java.io.PrintWriter._write12677 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(I)V");
			global::java.io.PrintWriter._write12678 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.PrintWriter._write12679 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print12680 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print12681 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._print12682 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Z)V");
			global::java.io.PrintWriter._print12683 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(C)V");
			global::java.io.PrintWriter._print12684 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(I)V");
			global::java.io.PrintWriter._print12685 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(J)V");
			global::java.io.PrintWriter._print12686 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(F)V");
			global::java.io.PrintWriter._print12687 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(D)V");
			global::java.io.PrintWriter._print12688 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "([C)V");
			global::java.io.PrintWriter._flush12689 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "flush", "()V");
			global::java.io.PrintWriter._close12690 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "close", "()V");
			global::java.io.PrintWriter._checkError12691 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "checkError", "()Z");
			global::java.io.PrintWriter._setError12692 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "setError", "()V");
			global::java.io.PrintWriter._clearError12693 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "clearError", "()V");
			global::java.io.PrintWriter._printf12694 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._printf12695 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._PrintWriter12696 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;Z)V");
			global::java.io.PrintWriter._PrintWriter12697 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::java.io.PrintWriter._PrintWriter12698 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter12699 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter12700 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.PrintWriter._PrintWriter12701 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter12702 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::java.io.PrintWriter._PrintWriter12703 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
