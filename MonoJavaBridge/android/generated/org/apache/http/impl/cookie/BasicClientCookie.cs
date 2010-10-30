namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicClientCookie : java.lang.Object, org.apache.http.cookie.SetCookie, org.apache.http.cookie.ClientCookie, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicClientCookie(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33217;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._toString33217) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone33218;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.impl.cookie.BasicClientCookie._clone33218) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName33219;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._getName33219) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
			set
			{
				setValue(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue33220;
		public virtual global::java.lang.String getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._getValue33220) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setValue33221;
		public virtual void setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setValue", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._setValue33221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
			set
			{
				setPath(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath33222;
		public virtual global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._getPath33222) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setComment33223;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._setComment33223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			get
			{
				return getComment();
			}
			set
			{
				setComment(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComment33224;
		public virtual global::java.lang.String getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getComment", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._getComment33224) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute33225;
		public virtual global::java.lang.String getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._getAttribute33225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
			set
			{
				setVersion(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33226;
		public virtual int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getVersion", "()I", ref global::org.apache.http.impl.cookie.BasicClientCookie._getVersion33226);
		}
		internal static global::MonoJavaBridge.MethodId _setVersion33227;
		public virtual void setVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setVersion", "(I)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._setVersion33227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Domain
		{
			get
			{
				return getDomain();
			}
			set
			{
				setDomain(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDomain33228;
		public virtual global::java.lang.String getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._getDomain33228) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent33229;
		public virtual bool isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isPersistent", "()Z", ref global::org.apache.http.impl.cookie.BasicClientCookie._isPersistent33229);
		}
		internal static global::MonoJavaBridge.MethodId _setPath33230;
		public virtual void setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setPath", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._setPath33230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute33231;
		public virtual void setAttribute(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._setAttribute33231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSecure33232;
		public virtual bool isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isSecure", "()Z", ref global::org.apache.http.impl.cookie.BasicClientCookie._isSecure33232);
		}
		public new global::java.lang.String CommentURL
		{
			get
			{
				return getCommentURL();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL33233;
		public virtual global::java.lang.String getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie._getCommentURL33233) as java.lang.String;
		}
		public new global::java.util.Date ExpiryDate
		{
			get
			{
				return getExpiryDate();
			}
			set
			{
				setExpiryDate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate33234;
		public virtual global::java.util.Date getExpiryDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getExpiryDate", "()Ljava/util/Date;", ref global::org.apache.http.impl.cookie.BasicClientCookie._getExpiryDate33234) as java.util.Date;
		}
		public new int[] Ports
		{
			get
			{
				return getPorts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPorts33235;
		public virtual int[] getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "getPorts", "()[I", ref global::org.apache.http.impl.cookie.BasicClientCookie._getPorts33235) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired33236;
		public virtual bool isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.impl.cookie.BasicClientCookie._isExpired33236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAttribute33237;
		public virtual bool containsAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "containsAttribute", "(Ljava/lang/String;)Z", ref global::org.apache.http.impl.cookie.BasicClientCookie._containsAttribute33237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate33238;
		public virtual void setExpiryDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setExpiryDate", "(Ljava/util/Date;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._setExpiryDate33238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain33239;
		public virtual void setDomain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setDomain", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._setDomain33239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Secure
		{
			set
			{
				setSecure(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSecure33240;
		public virtual void setSecure(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "setSecure", "(Z)V", ref global::org.apache.http.impl.cookie.BasicClientCookie._setSecure33240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicClientCookie33241;
		public BasicClientCookie(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.BasicClientCookie._BasicClientCookie33241.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.BasicClientCookie._BasicClientCookie33241 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicClientCookie.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie._BasicClientCookie33241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicClientCookie()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicClientCookie.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicClientCookie"));
		}
		internal static void InitJNI()
		{
		}
	}
}
