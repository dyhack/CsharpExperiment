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
    public partial class Form1 : Form
    {
        public int logintype = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                                panel1.ClientRectangle,
                                Color.Red,
                                3,
                                ButtonBorderStyle.Solid,
                                Color.Red,
                                3,
                                ButtonBorderStyle.Solid,
                                Color.Red,
                                3,
                                ButtonBorderStyle.Solid,
                                Color.Red,
                                3,
                                ButtonBorderStyle.Solid); 
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            //如果用户名和密码都有值,并且使用管理员登陆
            if (username_textBox.Text != "" && password_textBox.Text != ""&&Admin_radioButton.Checked)
            {
                if (Login.Login_charge(username_textBox.Text, password_textBox.Text, 0))
                {
                    MessageBox.Show("登陆成功");
                    this.logintype = 0;
                    this.Close();    //关闭登录窗口
                }
                else
                {
                    MessageBox.Show("登陆失败");
                }

 
            }
            //判断读者登陆
            else if (username_textBox.Text != "" && password_textBox.Text != "" && User_radioButton.Checked)
            {
                if(Login.Login_charge(username_textBox.Text,password_textBox.Text,1))
                {
                    MessageBox.Show("登陆成功");
                    
                   // User_Form uf = new User_Form(username_textBox.Text);
                   //uf.ShowDialog();
                    this.logintype = 1;
                    this.Close();    //关闭登录窗口
                    
                }
                else
                {
                    MessageBox.Show("登陆失败");
                }
            }
            else 
            {
                MessageBox.Show("请检查输入是否正确");
 
            }
        }
        public string getLoginname()
        {
            return this.username_textBox.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
