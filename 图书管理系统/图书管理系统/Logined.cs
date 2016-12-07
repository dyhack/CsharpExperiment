using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Logined : Form
    {
        string LoginName;
        public Logined(string Loginname, int logintype)
        {
            InitializeComponent();
            this.LoginName = Loginname;
            if (logintype == 0)//管理员
            {

            }
            else//读者
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Left = 10;
            }
        }

        private void Logined_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Form ad = new Admin_Form(LoginName);
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book_Category bk = new Book_Category();
            bk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Form us = new User_Form(LoginName);
            us.Show();

        }
    }
}
