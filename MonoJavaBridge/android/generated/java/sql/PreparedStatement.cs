namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.PreparedStatement_))]
	public partial interface PreparedStatement : Statement
	{
		void setBoolean(int arg0, bool arg1);
		void setByte(int arg0, byte arg1);
		void setShort(int arg0, short arg1);
		void setInt(int arg0, int arg1);
		void setLong(int arg0, long arg1);
		void setFloat(int arg0, float arg1);
		void setDouble(int arg0, double arg1);
		void setTimestamp(int arg0, java.sql.Timestamp arg1);
		void setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setURL(int arg0, java.net.URL arg1);
		void setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2);
		void setTime(int arg0, java.sql.Time arg1);
		void setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2);
		void setDate(int arg0, java.sql.Date arg1);
		bool execute();
		void addBatch();
		void setString(int arg0, java.lang.String arg1);
		void setObject(int arg0, java.lang.Object arg1, int arg2);
		void setObject(int arg0, java.lang.Object arg1, int arg2, int arg3);
		void setObject(int arg0, java.lang.Object arg1);
		global::java.sql.ResultSetMetaData getMetaData();
		void setBytes(int arg0, byte[] arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(int arg0, java.io.InputStream arg1, long arg2);
		void setNull(int arg0, int arg1, java.lang.String arg2);
		void setNull(int arg0, int arg1);
		void setBigDecimal(int arg0, java.math.BigDecimal arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(int arg0, java.io.InputStream arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, long arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1);
		void setNString(int arg0, java.lang.String arg1);
		void setNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setNCharacterStream(int arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.sql.Clob arg1);
		void setClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.io.Reader arg1);
		void setBlob(int arg0, java.sql.Blob arg1);
		void setBlob(int arg0, java.io.InputStream arg1, long arg2);
		void setBlob(int arg0, java.io.InputStream arg1);
		global::java.sql.ResultSet executeQuery();
		int executeUpdate();
		void setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2);
		void clearParameters();
		void setRef(int arg0, java.sql.Ref arg1);
		void setArray(int arg0, java.sql.Array arg1);
		global::java.sql.ParameterMetaData getParameterMetaData();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.PreparedStatement))]
	internal sealed partial class PreparedStatement_ : java.lang.Object, PreparedStatement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PreparedStatement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean24662;
		void java.sql.PreparedStatement.setBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBoolean", "(IZ)V", ref global::java.sql.PreparedStatement_._setBoolean24662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte24663;
		void java.sql.PreparedStatement.setByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setByte", "(IB)V", ref global::java.sql.PreparedStatement_._setByte24663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort24664;
		void java.sql.PreparedStatement.setShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setShort", "(IS)V", ref global::java.sql.PreparedStatement_._setShort24664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt24665;
		void java.sql.PreparedStatement.setInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setInt", "(II)V", ref global::java.sql.PreparedStatement_._setInt24665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong24666;
		void java.sql.PreparedStatement.setLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setLong", "(IJ)V", ref global::java.sql.PreparedStatement_._setLong24666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat24667;
		void java.sql.PreparedStatement.setFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setFloat", "(IF)V", ref global::java.sql.PreparedStatement_._setFloat24667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble24668;
		void java.sql.PreparedStatement.setDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setDouble", "(ID)V", ref global::java.sql.PreparedStatement_._setDouble24668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24669;
		void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V", ref global::java.sql.PreparedStatement_._setTimestamp24669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24670;
		void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", ref global::java.sql.PreparedStatement_._setTimestamp24670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setURL24671;
		void java.sql.PreparedStatement.setURL(int arg0, java.net.URL arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setURL", "(ILjava/net/URL;)V", ref global::java.sql.PreparedStatement_._setURL24671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24672;
		void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V", ref global::java.sql.PreparedStatement_._setTime24672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24673;
		void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setTime", "(ILjava/sql/Time;)V", ref global::java.sql.PreparedStatement_._setTime24673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24674;
		void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V", ref global::java.sql.PreparedStatement_._setDate24674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24675;
		void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setDate", "(ILjava/sql/Date;)V", ref global::java.sql.PreparedStatement_._setDate24675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24676;
		bool java.sql.PreparedStatement.execute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "()Z", ref global::java.sql.PreparedStatement_._execute24676);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24677;
		void java.sql.PreparedStatement.addBatch()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "addBatch", "()V", ref global::java.sql.PreparedStatement_._addBatch24677);
		}
		internal static global::MonoJavaBridge.MethodId _setString24678;
		void java.sql.PreparedStatement.setString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setString", "(ILjava/lang/String;)V", ref global::java.sql.PreparedStatement_._setString24678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24679;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;I)V", ref global::java.sql.PreparedStatement_._setObject24679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24680;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;II)V", ref global::java.sql.PreparedStatement_._setObject24680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24681;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;)V", ref global::java.sql.PreparedStatement_._setObject24681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData24682;
		global::java.sql.ResultSetMetaData java.sql.PreparedStatement.getMetaData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSetMetaData>(this, global::java.sql.PreparedStatement_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;", ref global::java.sql.PreparedStatement_._getMetaData24682) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24683;
		void java.sql.PreparedStatement.setBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBytes", "(I[B)V", ref global::java.sql.PreparedStatement_._setBytes24683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24684;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V", ref global::java.sql.PreparedStatement_._setBinaryStream24684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24685;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V", ref global::java.sql.PreparedStatement_._setBinaryStream24685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24686;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;J)V", ref global::java.sql.PreparedStatement_._setBinaryStream24686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24687;
		void java.sql.PreparedStatement.setNull(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNull", "(IILjava/lang/String;)V", ref global::java.sql.PreparedStatement_._setNull24687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24688;
		void java.sql.PreparedStatement.setNull(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNull", "(II)V", ref global::java.sql.PreparedStatement_._setNull24688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal24689;
		void java.sql.PreparedStatement.setBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V", ref global::java.sql.PreparedStatement_._setBigDecimal24689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24690;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V", ref global::java.sql.PreparedStatement_._setAsciiStream24690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24691;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V", ref global::java.sql.PreparedStatement_._setAsciiStream24691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24692;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;J)V", ref global::java.sql.PreparedStatement_._setAsciiStream24692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24693;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V", ref global::java.sql.PreparedStatement_._setCharacterStream24693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24694;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;J)V", ref global::java.sql.PreparedStatement_._setCharacterStream24694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24695;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V", ref global::java.sql.PreparedStatement_._setCharacterStream24695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNString24696;
		void java.sql.PreparedStatement.setNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNString", "(ILjava/lang/String;)V", ref global::java.sql.PreparedStatement_._setNString24696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24697;
		void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V", ref global::java.sql.PreparedStatement_._setNCharacterStream24697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24698;
		void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V", ref global::java.sql.PreparedStatement_._setNCharacterStream24698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24699;
		void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNClob", "(ILjava/io/Reader;)V", ref global::java.sql.PreparedStatement_._setNClob24699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24700;
		void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNClob", "(ILjava/io/Reader;J)V", ref global::java.sql.PreparedStatement_._setNClob24700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24701;
		void java.sql.PreparedStatement.setClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/sql/Clob;)V", ref global::java.sql.PreparedStatement_._setClob24701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24702;
		void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/io/Reader;J)V", ref global::java.sql.PreparedStatement_._setClob24702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24703;
		void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/io/Reader;)V", ref global::java.sql.PreparedStatement_._setClob24703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24704;
		void java.sql.PreparedStatement.setBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/sql/Blob;)V", ref global::java.sql.PreparedStatement_._setBlob24704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24705;
		void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V", ref global::java.sql.PreparedStatement_._setBlob24705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24706;
		void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;)V", ref global::java.sql.PreparedStatement_._setBlob24706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24707;
		global::java.sql.ResultSet java.sql.PreparedStatement.executeQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.PreparedStatement_.staticClass, "executeQuery", "()Ljava/sql/ResultSet;", ref global::java.sql.PreparedStatement_._executeQuery24707) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24708;
		int java.sql.PreparedStatement.executeUpdate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "()I", ref global::java.sql.PreparedStatement_._executeUpdate24708);
		}
		internal static global::MonoJavaBridge.MethodId _setUnicodeStream24709;
		void java.sql.PreparedStatement.setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setUnicodeStream", "(ILjava/io/InputStream;I)V", ref global::java.sql.PreparedStatement_._setUnicodeStream24709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters24710;
		void java.sql.PreparedStatement.clearParameters()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "clearParameters", "()V", ref global::java.sql.PreparedStatement_._clearParameters24710);
		}
		internal static global::MonoJavaBridge.MethodId _setRef24711;
		void java.sql.PreparedStatement.setRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setRef", "(ILjava/sql/Ref;)V", ref global::java.sql.PreparedStatement_._setRef24711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setArray24712;
		void java.sql.PreparedStatement.setArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setArray", "(ILjava/sql/Array;)V", ref global::java.sql.PreparedStatement_._setArray24712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMetaData24713;
		global::java.sql.ParameterMetaData java.sql.PreparedStatement.getParameterMetaData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ParameterMetaData>(this, global::java.sql.PreparedStatement_.staticClass, "getParameterMetaData", "()Ljava/sql/ParameterMetaData;", ref global::java.sql.PreparedStatement_._getParameterMetaData24713) as java.sql.ParameterMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _close24714;
		void java.sql.Statement.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "close", "()V", ref global::java.sql.PreparedStatement_._close24714);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed24715;
		bool java.sql.Statement.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "isClosed", "()Z", ref global::java.sql.PreparedStatement_._isClosed24715);
		}
		internal static global::MonoJavaBridge.MethodId _execute24716;
		bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;[I)Z", ref global::java.sql.PreparedStatement_._execute24716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24717;
		bool java.sql.Statement.execute(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;I)Z", ref global::java.sql.PreparedStatement_._execute24717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24718;
		bool java.sql.Statement.execute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;)Z", ref global::java.sql.PreparedStatement_._execute24718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute24719;
		bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z", ref global::java.sql.PreparedStatement_._execute24719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel24720;
		void java.sql.Statement.cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "cancel", "()V", ref global::java.sql.PreparedStatement_._cancel24720);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24721;
		void java.sql.Statement.addBatch(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "addBatch", "(Ljava/lang/String;)V", ref global::java.sql.PreparedStatement_._addBatch24721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24722;
		global::java.sql.Connection java.sql.Statement.getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::java.sql.PreparedStatement_.staticClass, "getConnection", "()Ljava/sql/Connection;", ref global::java.sql.PreparedStatement_._getConnection24722) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24723;
		global::java.sql.ResultSet java.sql.Statement.getResultSet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.PreparedStatement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;", ref global::java.sql.PreparedStatement_._getResultSet24723) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings24724;
		global::java.sql.SQLWarning java.sql.Statement.getWarnings()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.PreparedStatement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;", ref global::java.sql.PreparedStatement_._getWarnings24724) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings24725;
		void java.sql.Statement.clearWarnings()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "clearWarnings", "()V", ref global::java.sql.PreparedStatement_._clearWarnings24725);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection24726;
		void java.sql.Statement.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setFetchDirection", "(I)V", ref global::java.sql.PreparedStatement_._setFetchDirection24726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection24727;
		int java.sql.Statement.getFetchDirection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getFetchDirection", "()I", ref global::java.sql.PreparedStatement_._getFetchDirection24727);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize24728;
		void java.sql.Statement.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setFetchSize", "(I)V", ref global::java.sql.PreparedStatement_._setFetchSize24728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize24729;
		int java.sql.Statement.getFetchSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getFetchSize", "()I", ref global::java.sql.PreparedStatement_._getFetchSize24729);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24730;
		global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.PreparedStatement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.PreparedStatement_._executeQuery24730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24731;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I", ref global::java.sql.PreparedStatement_._executeUpdate24731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24732;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I", ref global::java.sql.PreparedStatement_._executeUpdate24732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24733;
		int java.sql.Statement.executeUpdate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I", ref global::java.sql.PreparedStatement_._executeUpdate24733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24734;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I", ref global::java.sql.PreparedStatement_._executeUpdate24734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize24735;
		int java.sql.Statement.getMaxFieldSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getMaxFieldSize", "()I", ref global::java.sql.PreparedStatement_._getMaxFieldSize24735);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize24736;
		void java.sql.Statement.setMaxFieldSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setMaxFieldSize", "(I)V", ref global::java.sql.PreparedStatement_._setMaxFieldSize24736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows24737;
		int java.sql.Statement.getMaxRows()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getMaxRows", "()I", ref global::java.sql.PreparedStatement_._getMaxRows24737);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows24738;
		void java.sql.Statement.setMaxRows(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setMaxRows", "(I)V", ref global::java.sql.PreparedStatement_._setMaxRows24738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing24739;
		void java.sql.Statement.setEscapeProcessing(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setEscapeProcessing", "(Z)V", ref global::java.sql.PreparedStatement_._setEscapeProcessing24739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout24740;
		int java.sql.Statement.getQueryTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getQueryTimeout", "()I", ref global::java.sql.PreparedStatement_._getQueryTimeout24740);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout24741;
		void java.sql.Statement.setQueryTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setQueryTimeout", "(I)V", ref global::java.sql.PreparedStatement_._setQueryTimeout24741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName24742;
		void java.sql.Statement.setCursorName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setCursorName", "(Ljava/lang/String;)V", ref global::java.sql.PreparedStatement_._setCursorName24742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount24743;
		int java.sql.Statement.getUpdateCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getUpdateCount", "()I", ref global::java.sql.PreparedStatement_._getUpdateCount24743);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24744;
		bool java.sql.Statement.getMoreResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "getMoreResults", "()Z", ref global::java.sql.PreparedStatement_._getMoreResults24744);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24745;
		bool java.sql.Statement.getMoreResults(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "getMoreResults", "(I)Z", ref global::java.sql.PreparedStatement_._getMoreResults24745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency24746;
		int java.sql.Statement.getResultSetConcurrency()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getResultSetConcurrency", "()I", ref global::java.sql.PreparedStatement_._getResultSetConcurrency24746);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType24747;
		int java.sql.Statement.getResultSetType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getResultSetType", "()I", ref global::java.sql.PreparedStatement_._getResultSetType24747);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch24748;
		void java.sql.Statement.clearBatch()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "clearBatch", "()V", ref global::java.sql.PreparedStatement_._clearBatch24748);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch24749;
		int[] java.sql.Statement.executeBatch()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::java.sql.PreparedStatement_.staticClass, "executeBatch", "()[I", ref global::java.sql.PreparedStatement_._executeBatch24749) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys24750;
		global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.PreparedStatement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;", ref global::java.sql.PreparedStatement_._getGeneratedKeys24750) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability24751;
		int java.sql.Statement.getResultSetHoldability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getResultSetHoldability", "()I", ref global::java.sql.PreparedStatement_._getResultSetHoldability24751);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable24752;
		void java.sql.Statement.setPoolable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setPoolable", "(Z)V", ref global::java.sql.PreparedStatement_._setPoolable24752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable24753;
		bool java.sql.Statement.isPoolable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "isPoolable", "()Z", ref global::java.sql.PreparedStatement_._isPoolable24753);
		}
		static PreparedStatement_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.PreparedStatement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/PreparedStatement"));
		}
		internal static void InitJNI()
		{
		}
	}
}
