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
    public partial class User_Form : Form
    {
        DataSet Book;
        SqlDataAdapter dataadapter;
        public int Userid;
        private string LoginName="";
        public User_Form(string Loginname,int userid)
        {
            InitializeComponent();
            //保存登陆的用户名
            this.LoginName = Loginname;
            this.Text = "欢迎您读者 " + Loginname;
            Userid = userid;
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            BindDateGrdView();
        }
        private void BindDateGrdView()
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
            this.dataGridView1.DataSource = Book.Tables[0];
            DataGridViewRow t = this.dataGridView1.Rows[0];
            //this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].HeaderText = "书名";
            this.dataGridView1.Columns[2].HeaderText = "ISBN号";
            this.dataGridView1.Columns[3].HeaderText = "价格";
            this.dataGridView1.Columns[4].HeaderText = "出版社";
            this.dataGridView1.Columns[5].HeaderText = "出版日期";
            this.dataGridView1.Columns[6].HeaderText = "是否已借";

            conn.Close();
        }

        private void borrowbook_button_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow t in this.dataGridView1.SelectedRows)
                {

                    if (t.Index != -1)
                    {
                        if ((bool)t.Cells[6].Value == false)
                        {
                            int id = (int)t.Cells[0].Value;
                            string updatesql = "update [Book] set Book_Status='true',User_id=@userid where ID=@ID";
                            SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
                            conn.Open();
                            SqlCommand sqlcmd = new SqlCommand(updatesql, conn);
                            sqlcmd.Parameters.AddWithValue("@ID", id);
                            sqlcmd.Parameters.AddWithValue("@userid",Userid);
                            sqlcmd.ExecuteNonQuery();
                            dataadapter.Update(Book.Tables[0]);
                            
                        }
                        else
                        {
                            MessageBox.Show("存在别人已经借阅的图书，请重新选择");
                            break;
                        }
                        MessageBox.Show("借书成功");
                    }
                }
                BindDateGrdView();


            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("请选择要借的书");
            }
        }

    }
}
