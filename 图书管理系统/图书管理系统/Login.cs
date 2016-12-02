using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace 图书管理系统
{
    class Login
    {
        public static int userid;
        public static bool Login_charge(string user, string password,int logintype)
        {
            string sql,sql1,sql2;
            if (logintype == 0)
            {
                sql="select * from Admin where Username=@user and Password=@password";
                sql1="update Admin set LoginTime=@time where Username=@user";
                sql2 = "select ID from [Admin] where Username=@username";
            }
            else
            {
                //屏蔽掉和系统一样的关键词
                sql = "select * from [User] where Username=@user and Password=@password";
                sql1="update  [User] set LoginTime=@time where Username=@user";
                sql2 = "select ID from [User] where Username=@username";
            }
            //获取数据库连接字符串
                string connectionstring = Connectionsql.getconstring();
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlCommand sqlcmd = new SqlCommand(sql, conn);
                sqlcmd.CommandTimeout = 1500;
                conn.Open();
                sqlcmd.Parameters.AddWithValue("@user", user);
                sqlcmd.Parameters.AddWithValue("@password", password);
                //如过查询结果没有,返回空Convert.ToInt32不会导致异常
                if (Convert.ToInt32(sqlcmd.ExecuteScalar()) > 0)
                {
                    sqlcmd.CommandText = sql1;
                    sqlcmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.CommandText = sql2;
                    sqlcmd.Parameters.AddWithValue("@username", user);
                    userid = Convert.ToInt32(sqlcmd.ExecuteScalar());
                    conn.Close();
                    return true;
                }
                else
                    return false;

            
        }
        
    }
}
