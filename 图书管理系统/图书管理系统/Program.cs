using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 图书管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 f1 = new Form1();
            f1.ShowDialog();
            if (f1.logintype == 0)
            {

               // Application.Run(new Admin_Form(f1.getLoginname()));
                Application.Run(new Book_Category());
            }
            else if (f1.logintype == 1)
            {
                Application.Run(new User_Form(f1.getLoginname()));

            }
            else
            {
                return;
            }
        }
    }
}
