using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 图书管理系统
{
    class Connectionsql
    {
        private static string connectionstring = "Database=BookManage;Data Source=192.168.101.128;User Id=sa;Password=hackerxiaoke;";
        public static String getconstring()
        {
            return connectionstring;
        }
    }
}
