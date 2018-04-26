using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Data.OleDb;
using System.Data.Common;
using System.Security.Cryptography;

namespace ProCCommon
{
    /// <summary>
    /// PLFMSSQL:平台MSSQL操作;
    /// PLFORACLE：平台Oracle操作;
    /// PLFMYSQL：平台MySql操作;
    /// HOSMSSQL：医院Oracle操作;
    /// HOSORACLE：医院Oracle操作;
    /// HOSMYSQL：医院Oracle操作;
    /// </summary>
    public enum TargetTypes { PLFMSSQL, PLFORACLE, PLFMYSQL, HOSMSSQL, HOSORACLE, HOSMYSQL };
    
    /// <summary>
    /// 数据库操作类,通过TargetTypes参数来指定要操作的数据库服务器类型
    /// </summary>
	public class DBHelper
	{
        /// <summary>
        /// 平台数据库连接字符串
        /// </summary>
        public static string platformConStr = GetPlatformConStr();

        /// <summary>
        /// 医院数据库连接字符串
        /// </summary>
        public static string hospitalConStr = GetHospitalConStr();

        /// <summary>
        /// 从配置文件中读取医院数据库连接字符串
        /// </summary>
        /// <returns>string</returns>
        private static string GetHospitalConStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["conStr"].ToString().Trim();
        }

        /// <summary>
        /// 从配置文件中读取平台数据库连接字符串
        /// </summary>
        /// <returns>string</returns>
        private static string GetPlatformConStr()
        {
            return System.Configuration.ConfigurationManager.AppSettings["PlatformConnection"].Trim();
        }


        //返回datatable
        #region ExecuteDataTable
        
        ///<summary>
        ///执行sql语句，返回datatable
        ///</summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="commandText"> 传入执行sql语句</param>
        ///<returns>DataTable：受影响datatable集</returns>
        public static DataTable ExecuteDataTable(TargetTypes ttype, string commandText)
        {
            DataTable dt = null;
            switch(ttype)
            {
                case TargetTypes.HOSMSSQL:
                    dt = SqlHelper.ExecuteDataset(hospitalConStr, CommandType.Text, commandText).Tables[0];
                    break;
                case TargetTypes.HOSORACLE:
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = hospitalConStr;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = commandText;
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        // Fill the DataSet using default values for DataTable names, etc
                        da.Fill(ds);
                        // Detach the SqlParameters from the command object, so they can be used again
                        cmd.Parameters.Clear();
                        con.Close();
                        // Return the dataset
                        dt = ds.Tables[0];
                    }                    
                    break;
                case TargetTypes.PLFMSSQL:
                    dt = SqlHelper.ExecuteDataset(platformConStr, CommandType.Text, commandText).Tables[0];
                    break;
                default:                 
                    break;
            }
            return dt;
        }

        ///<summary>
        ///执行带参数的sql语句，返回datatable
        ///</summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="commandText"> 执行sql语句</param>
        ///<param name="commandParameters"> 参数集</param>
        ///<returns>DataTable：受影响datatable集</returns>
        public static DataTable ExecuteDataTable(TargetTypes ttype, string commandText, params SqlParameter[] commandParameters)
        {
            DataTable dt = null;
            switch (ttype)
            {
                case TargetTypes.HOSMSSQL:
                    dt = SqlHelper.ExecuteDataset(hospitalConStr, CommandType.Text, commandText, commandParameters).Tables[0];
                    break;
                case TargetTypes.HOSORACLE:
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = hospitalConStr;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = commandText;
                    cmd.Parameters.AddRange(commandParameters);

                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        // Fill the DataSet using default values for DataTable names, etc
                        da.Fill(ds);
                        // Detach the SqlParameters from the command object, so they can be used again
                        cmd.Parameters.Clear();
                        con.Close();
                        // Return the dataset
                        dt = ds.Tables[0];
                    }
                    break;
                case TargetTypes.PLFMSSQL:
                    dt = SqlHelper.ExecuteDataset(platformConStr, CommandType.Text, commandText, commandParameters).Tables[0];
                    break;
                default:
                    break;
            }
            return dt;
        }
        
        ///<summary>
        ///执行带事务的sql语句，返回datatable
        ///</summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="transaction"> 事务</param>
        ///<param name="commandText"> 执行sql语句</param>
        ///<returns>DataTable：受影响datatable集</returns>
        public static DataTable ExecuteDataTable(TargetTypes ttype, DbTransaction transaction, string commandText)
        {
            DataTable dt = null;
            switch (ttype)
            {
                case TargetTypes.HOSORACLE:
                    //需要完成的
                    OleDbTransaction oleDbTrans = (OleDbTransaction)transaction;
                    OleDbConnection con = oleDbTrans.Connection;                   
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    //con.Open();   //不需要再次打开
                    cmd.Transaction = oleDbTrans;
                    cmd.CommandText = commandText;
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        // Fill the DataSet using default values for DataTable names, etc
                        da.Fill(ds);
                        // Detach the SqlParameters from the command object, so they can be used again
                        cmd.Parameters.Clear();
                        //con.Close();
                        // Return the dataset
                        dt = ds.Tables[0];
                    }
                    break;
                case TargetTypes.HOSMSSQL:
                case TargetTypes.PLFMSSQL:
                    SqlTransaction Sqltrans = (SqlTransaction)transaction;
                    dt = SqlHelper.ExecuteDataset(Sqltrans, CommandType.Text, commandText).Tables[0];
                    break;
                default:
                    break;
            }
            return dt;
        }
        
        ///<summary>
        ///执行带事务和参数的sql语句，返回datatable
        ///</summary>
        ///<param name="transaction"> 事务</param>
        ///<param name="commandText"> 执行sql语句</param>
        ///<param name="commandParameters"> 参数集</param>
        ///<returns>DataTable：受影响datatable集</returns>
        public static DataTable ExecuteDataTable(TargetTypes ttype, DbTransaction transaction, string commandText, params SqlParameter[] commandParameters)
        {
            DataTable dt = null;
            switch (ttype)
            {
                case TargetTypes.HOSORACLE:
                    //需要完成的
                    OleDbTransaction oleDbTrans = (OleDbTransaction)transaction;
                    OleDbConnection con = oleDbTrans.Connection;                   
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    //con.Open();
                    cmd.Transaction = oleDbTrans;
                    cmd.CommandText = commandText;
                    cmd.Parameters.AddRange(commandParameters);
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        // Fill the DataSet using default values for DataTable names, etc
                        da.Fill(ds);
                        // Detach the SqlParameters from the command object, so they can be used again
                        cmd.Parameters.Clear();
                        //con.Close();
                        // Return the dataset
                        dt = ds.Tables[0];
                    }
                    break;
                case TargetTypes.HOSMSSQL:
                case TargetTypes.PLFMSSQL:
                    SqlTransaction Sqltrans = (SqlTransaction)transaction;
                    dt = SqlHelper.ExecuteDataset(Sqltrans, CommandType.Text, commandText, commandParameters).Tables[0];
                    break;
                default:
                    break;
            }
            return dt;
        }


        #endregion ExecuteDataTable

        //返回第一行的第一列数据

        #region ExecuteScalar

        ///<summary>
        ///执行sql语句，返回单个数据结果

        ///</summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="commandText"> sql语句</param>
        ///<returns>object：第一行第一列的结果</returns>
        public static object ExecuteScalar(TargetTypes ttype, string commandText)
        {
            object obj = null;
            switch (ttype)
            {
                case TargetTypes.HOSMSSQL:
                    obj = SqlHelper.ExecuteScalar(hospitalConStr, CommandType.Text, commandText);
                    break;
                case TargetTypes.HOSORACLE:
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = hospitalConStr;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = commandText;
                    obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    con.Close();
                    break;
                case TargetTypes.PLFMSSQL:
                    obj = SqlHelper.ExecuteScalar(platformConStr, CommandType.Text, commandText);
                    break;
                default:
                    break;
            }
            return obj;
        }

        ///<summary>
        ///执行带参数sql语句，返回单个数据结果

        ///</summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="commandText"> sql语句</param>
        ///<param name="commandParameters"> sql语句参数</param>
        ///<returns>object：第一行第一列的结果</returns>
        public static object ExecuteScalar(TargetTypes ttype, string commandText, params SqlParameter[] commandParameters)
        {
            object obj = null;
            switch (ttype)
            {
                case TargetTypes.HOSMSSQL:
                    obj = SqlHelper.ExecuteScalar(hospitalConStr, CommandType.Text, commandText, commandParameters);
                    break;
                case TargetTypes.HOSORACLE:
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = hospitalConStr;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = commandText;
                    cmd.Parameters.AddRange(commandParameters);
                    obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    con.Close();
                    break;
                case TargetTypes.PLFMSSQL:
                    obj = SqlHelper.ExecuteScalar(platformConStr, CommandType.Text, commandText, commandParameters);
                    break;
                default:
                    break;
            }
            return obj;
        }

        ///<summary>
        ///执行带事务的sql语句，返回单个数据结果

        ///</summary>
        ///<param name="ttype"> 数据库对象类型</param>
        ///<param name="transaction"> 事务</param>
        ///<param name="commandText"> sql语句</param>
        ///<returns>object：第一行第一列的结果</returns>
        public static object ExecuteScalar(TargetTypes ttype, DbTransaction transaction, string commandText)
        {
            object obj = null;
            switch (ttype)
            {
                case TargetTypes.HOSORACLE:
                    //需要完成的
                    OleDbTransaction oleDbTrans = (OleDbTransaction)transaction;
                    OleDbConnection con = oleDbTrans.Connection;                   
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    //con.Open();
                    cmd.Transaction = oleDbTrans;
                    cmd.CommandText = commandText;                 
                    obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    //con.Close();
                    break;
                case TargetTypes.HOSMSSQL:
                case TargetTypes.PLFMSSQL:
                    SqlTransaction Sqltrans = (SqlTransaction)transaction;
                    obj = SqlHelper.ExecuteScalar(Sqltrans, CommandType.Text, commandText);
                    break;
                default:
                    break;
            }
            return obj;
        }

        ///<summary>
        ///执行带事务和参数的sql语句，返回单个数据结果

        ///</summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="transaction"> 事务</param>
        ///<param name="commandText"> sql语句</param>
        ///<param name="parameterValues"> sql语句参数</param>
        ///<returns>object：第一行第一列的结果</returns>
        public static object ExecuteScalar(TargetTypes ttype, DbTransaction transaction, string commandText, params SqlParameter[] commandParameters)
        {
            object obj = null;
            switch (ttype)
            {
                case TargetTypes.HOSORACLE:
                    //需要完成的
                    OleDbTransaction oleDbTrans = (OleDbTransaction)transaction;
                    OleDbConnection con = oleDbTrans.Connection;                   
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    //con.Open();
                    cmd.Transaction = oleDbTrans;
                    cmd.CommandText = commandText;
                    cmd.Parameters.AddRange(commandParameters);
                    obj = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    //con.Close();
                    break;
                case TargetTypes.HOSMSSQL:
                case TargetTypes.PLFMSSQL:
                    SqlTransaction Sqltrans = (SqlTransaction)transaction;
                    obj = SqlHelper.ExecuteScalar(Sqltrans, CommandType.Text, commandText, commandParameters);
                    break;
                default:
                    break;
            }
            return obj;
        }
        #endregion ExecuteScalar

        //返回任何值受影响的行数

        #region ExecuteNonQuery

        /// <summary>
        /// 执行sql语句,返回受影响的行数
        /// </summary>
        /// <param name="ttype"> 数据库对象类型</param> 
        /// <param name="commandText">sql语句</param>
        /// <returns>int:受影响的行数</returns>
        public static int ExecuteNonQuery(TargetTypes ttype, string commandText)
        {
            int result = -1;
            switch (ttype)
            {
                case TargetTypes.HOSMSSQL:
                    result = SqlHelper.ExecuteNonQuery(hospitalConStr, CommandType.Text, commandText);
                    break;
                case TargetTypes.HOSORACLE:
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = hospitalConStr;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = commandText;
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                    break;
                case TargetTypes.PLFMSSQL:
                    result = SqlHelper.ExecuteNonQuery(platformConStr, CommandType.Text, commandText);
                    break;
                default:
                    break;
            }
            return result;
        }

        /// <summary>
        /// 执行带参数sql语句,返回受影响的行数
        /// </summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="commandText"> sql语句</param>
        ///<param name="parameterValues"> sql语句参数</param>
        /// <returns>int:受影响的行数</returns>
        public static int ExecuteNonQuery(TargetTypes ttype, string commandText, params SqlParameter[] commandParameters)
        {
            int result = -1;
            switch (ttype)
            {
                case TargetTypes.HOSMSSQL:
                    result = SqlHelper.ExecuteNonQuery(hospitalConStr, CommandType.Text, commandText, commandParameters);
                    break;
                case TargetTypes.HOSORACLE:
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = hospitalConStr;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = commandText;
                    cmd.Parameters.AddRange(commandParameters);
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                    break;
                case TargetTypes.PLFMSSQL:
                    result = SqlHelper.ExecuteNonQuery(platformConStr, CommandType.Text, commandText, commandParameters);
                    break;
                default:
                    break;
            }
            return result;            
        }

        /// <summary>
        /// 执行带参数sql语句,返回受影响的行数
        /// </summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="transaction"> 事务</param>
        ///<param name="commandText"> sql语句</param>
        /// <returns>int:受影响的行数</returns>
        public static int ExecuteNonQuery(TargetTypes ttype, DbTransaction transaction, string commandText)
        {
            int result = -1;
            switch (ttype)
            {
                case TargetTypes.HOSORACLE:
                    //需要完成的
                    OleDbTransaction oleDbTrans = (OleDbTransaction)transaction;
                    OleDbConnection con = oleDbTrans.Connection;                   
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                   // con.Open();
                    cmd.Transaction = oleDbTrans;
                    cmd.CommandText = commandText;                  
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                  //  con.Close();
                    break;
                case TargetTypes.HOSMSSQL:
                case TargetTypes.PLFMSSQL:
                    SqlTransaction Sqltrans = (SqlTransaction)transaction;
                    result = SqlHelper.ExecuteNonQuery(Sqltrans, CommandType.Text, commandText);
                    break;
                default:
                    break;
            }
            return result;
        }

        /// <summary>
        /// 执行带参数sql语句,返回受影响的行数
        /// </summary>
        ///<param name="ttype"> 数据库对象类型</param> 
        ///<param name="transaction"> 事务</param>
        ///<param name="commandText"> sql语句</param>
        ///<param name="parameterValues"> sql语句参数</param>
        /// <returns>int:受影响的行数</returns>
        public static int ExecuteNonQuery(TargetTypes ttype, DbTransaction transaction, string commandText, params SqlParameter[] commandParameters)
        {
            int result = -1;
            switch (ttype)
            {
                case TargetTypes.HOSORACLE:
                    //需要完成的
                    OleDbTransaction oleDbTrans = (OleDbTransaction)transaction;
                    OleDbConnection con = oleDbTrans.Connection;                   
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    //con.Open();
                    cmd.Transaction = oleDbTrans;
                    cmd.CommandText = commandText;
                    cmd.Parameters.AddRange(commandParameters);
                    result = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    //con.Close();
                    break;
                case TargetTypes.HOSMSSQL:
                case TargetTypes.PLFMSSQL:
                    SqlTransaction Sqltrans = (SqlTransaction)transaction;
                    result = SqlHelper.ExecuteNonQuery(Sqltrans, CommandType.Text, commandText, commandParameters);
                    break;
                default:
                    break;
            }
            return result;
        }

        #endregion ExecuteNonQuery


        /// <summary>
        /// MD5加密取值

        /// </summary>
        /// <param name="AText">输入文本</param>
        /// <returns></returns>
        public static string MD5(string AText)
        {
            byte[] result = Encoding.Default.GetBytes(AText);    //AText为输入密码的文本框

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");  //tbMd5pass
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="logtype"></param>
        /// <param name="user"></param>
        /// <param name="memo"></param>
        public static void WriteLog(string logtype,string user,string memo)
        {
            IPHostEntry ipe = Dns.GetHostEntry(Dns.GetHostName()); 
            IPAddress ipa = ipe.AddressList[0];
            string sql = "insert into sys_loginfo(logtime, logtype, operator, ipaddress, memo) " +
                         "values('" + DateTime.Now + "','" + logtype + "','" + user + "','" + ipa + "','" + memo + "')";
            ExecuteNonQuery(TargetTypes.PLFMSSQL, sql);
        }
    
	}
}
