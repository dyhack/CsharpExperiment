using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 图书管理系统
{
    public partial class Admin_Form : Form
    {
        DataSet User;
        SqlDataAdapter dataadapter;
        private string LoginName = "";
        public Admin_Form(string Loginname)
        {

            InitializeComponent();
            //保存登陆的用户名
            this.LoginName = Loginname;
            this.Text = "欢迎您管理员  " + Loginname;
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            BindDateGrdView();
        }
        private void BindDateGrdView()
        {
            string sql = "select * from [User]";
            SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
            conn.Open();
            dataadapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder sqlcmdbuilder = new SqlCommandBuilder(dataadapter);
            dataadapter.InsertCommand = sqlcmdbuilder.GetInsertCommand();
            dataadapter.UpdateCommand = sqlcmdbuilder.GetUpdateCommand();
            dataadapter.DeleteCommand = sqlcmdbuilder.GetDeleteCommand();
            User = new DataSet();
            dataadapter.Fill(User,"User");
            this.dataGridView1.DataSource = User.Tables[0];
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].HeaderText = "读者名";
            this.dataGridView1.Columns[2].HeaderText = "密码";
            this.dataGridView1.Columns[3].HeaderText = "登陆时间";
            conn.Close();
        }

        private void adduser_butto_Click(object sender, EventArgs e)
        {
            if (this.username_textBox.Text != "")
            {
                if (this.password_textBox.Text != "")
                {
                    //添加用户名和密码
                    string username, password;
                    username = this.username_textBox.Text;
                    password = this.password_textBox.Text;
                    SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
                    string sql="insert into [User](Username,Password) values(@user,@password)";
                    conn.Open();
                    SqlCommand sqlcmd=new SqlCommand(sql,conn);
                    sqlcmd.Parameters.AddWithValue("@user",username);
                    sqlcmd.Parameters.AddWithValue("@password",password);
                    if(sqlcmd.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("添加成功");
                        //重新显示数据
                        BindDateGrdView();
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                else
                {
                    MessageBox.Show("请输入读者密码");
                }
            }
            else if (this.username_textBox.Text == "" && this.password_textBox.Text != "")
            {
                MessageBox.Show("请输入读者名");

            }
            else
            {
                MessageBox.Show("请输入要添加的读者名和密码");
            }
        }

        private void Admin_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (User.HasChanges())
            {
                if (DialogResult.OK == MessageBox.Show("你确定保存并退出应用程序吗？", "保存数据提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    dataadapter.Update(User.Tables[0]);
                    MessageBox.Show("更新数据成功");
                    BindDateGrdView();
                }
            }
        }

        private void deluser_button_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow t in this.dataGridView1.SelectedRows)
                    {
                   
                    if (t.Index != -1)
                    {
                        this.dataGridView1.Rows.RemoveAt(t.Index);
                        dataadapter.Update(User.Tables[0]);
                        BindDateGrdView();
                        BindDateGrdView();
                    }
                    }
                
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("请选择要删除的行");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBox.Show("您确定要删除本条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    this.dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                dataadapter.Update(User.Tables[0]);
                BindDateGrdView();
            }
        }







    }
}
