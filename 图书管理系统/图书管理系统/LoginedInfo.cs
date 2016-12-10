using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 图书管理系统
{
    class LoginedInfo
    {
        private static int logintype;

        public static int Logintype
        {
            get { return LoginedInfo.logintype; }
            set { LoginedInfo.logintype = value; }
        }
        private static int userid;

        public static int Userid
        {
            get { return LoginedInfo.userid; }
            set { LoginedInfo.userid = value; }
        }
        private static string logintime;

        public static string Logintime
        {
            get { return LoginedInfo.logintime; }
            set { LoginedInfo.logintime = value; }
        }
        private static string loginname;

        public static string Loginname
        {
            get { return LoginedInfo.loginname; }
            set { LoginedInfo.loginname = value; }
        }

        

       
    }
}
