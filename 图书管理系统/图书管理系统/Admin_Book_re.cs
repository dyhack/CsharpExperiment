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
    public partial class Admin_Book_re : Form
    {
        DataSet Book;
        SqlDataAdapter dataadapter;
        private string LoginName="";
        int logintype = 0;
        public Admin_Book_re(string Loginname,int logintype)
        {
            InitializeComponent();
            //保存登陆的用户名
            this.LoginName = Loginname;
            this.Text = "欢迎您管理员 " + Loginname;
            this.logintype = logintype;
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            BindDateGrdView();
        }
        private void BindDateGrdView()
        {
            if (logintype == 0)
            {
                string sql = "select ID,Book_name,Book_ISBN,Book_Price,Book_Publish,Book_Publist_Time,Book_Status from [Book]";
                SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
                conn.Open();
                dataadapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder sqlcmdbuilder = new SqlCommandBuilder(dataadapter);
                dataadapter.InsertCommand = sqlcmdbuilder.GetInsertCommand();
                dataadapter.UpdateCommand = sqlcmdbuilder.GetUpdateCommand();
                dataadapter.DeleteCommand = sqlcmdbuilder.GetDeleteCommand();
                Book = new DataSet();
                dataadapter.Fill(Book, "Book");
                this.dataGridView2.DataSource = Book.Tables[0];
                DataGridViewRow t = this.dataGridView2.Rows[0];
                //this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;
                this.dataGridView2.Columns[0].ReadOnly = true;
                this.dataGridView2.Columns[1].HeaderText = "书名";
                this.dataGridView2.Columns[2].HeaderText = "ISBN号";
                this.dataGridView2.Columns[3].HeaderText = "价格";
                this.dataGridView2.Columns[4].HeaderText = "出版社";
                this.dataGridView2.Columns[5].HeaderText = "出版日期";
                this.dataGridView2.Columns[6].HeaderText = "是否已借";
                

                conn.Close();
            }
            else
            {
                string sql = "select Book.ID,Book_name,Book_ISBN,Book_Price,Book_Publish,Book_Publist_Time,Book_Status,[User].Username from [Book] join [User] on [Book].User_id=[User].ID";
                SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
                conn.Open();
                dataadapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder sqlcmdbuilder = new SqlCommandBuilder(dataadapter);
                //dataadapter.InsertCommand = sqlcmdbuilder.GetInsertCommand();
                //dataadapter.UpdateCommand = sqlcmdbuilder.GetUpdateCommand();
                //dataadapter.DeleteCommand = sqlcmdbuilder.GetDeleteCommand();
                Book = new DataSet();
                dataadapter.Fill(Book, "Book");
                this.dataGridView2.DataSource = Book.Tables[0];
                DataGridViewRow t = this.dataGridView2.Rows[0];
                //this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;
                this.dataGridView2.Columns[0].ReadOnly = true;
                this.dataGridView2.Columns[1].HeaderText = "书名";
                this.dataGridView2.Columns[2].HeaderText = "ISBN号";
                this.dataGridView2.Columns[3].HeaderText = "价格";
                this.dataGridView2.Columns[4].HeaderText = "出版社";
                this.dataGridView2.Columns[5].HeaderText = "出版日期";
                this.dataGridView2.Columns[6].HeaderText = "是否已借";
                this.dataGridView2.Columns[7].HeaderText = "借书用户";
                conn.Close();
 
            }
        }

        private void borrowbook_button_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow t in this.dataGridView2.SelectedRows)
                {

                    if (t.Index != -1)
                    {
                        if ((bool)t.Cells[6].Value == true)
                        {
                            int id = (int)t.Cells[0].Value;
                            string updatesql = "update [Book] set Book_Status='false',User_id=null where ID=@ID";
                            SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
                            conn.Open();
                            SqlCommand sqlcmd = new SqlCommand(updatesql, conn);
                            sqlcmd.Parameters.AddWithValue("@ID", id);
                            sqlcmd.ExecuteNonQuery();
                            dataadapter.Update(Book.Tables[0]);
                            
                        }
                        else
                        {
                            MessageBox.Show("存在已经还的图书，请重新选择");
                        }
                    }
                }
                BindDateGrdView();


            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("请选择要还的书");
            }
        }

    }
}
