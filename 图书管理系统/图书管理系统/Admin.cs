using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 图书管理系统
{
    class Admin
    {
        private int ID;
        private string UserName;
        private string PassWord;
        private string LoginTime;


        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Username
        {
            get { return UserName; }
            set { UserName = value; }
        }
       

        public string Password
        {
            get { return PassWord; }
            set { PassWord = value; }
        }
        

        public string Logintime
        {
            get { return LoginTime; }
            set { LoginTime = value; }
        }
 
    }
}
