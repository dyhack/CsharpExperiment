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
        private string LoginName="";
        public User_Form(string Loginname)
        {
            InitializeComponent();
            //保存登陆的用户名
            this.LoginName = Loginname;
            this.Text = "欢迎您读者 " + Loginname;
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            BindDateGrdView();
        }
        private void BindDateGrdView()
        {
            string sql = "select ID,Book_name,Book_ISBN,Book_Price,Book_Price,Book_Publish,Book_Publist_Time,Book_Status from [Book]";
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
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].HeaderText = "书名";
            this.dataGridView1.Columns[2].HeaderText = "ISBN号";
            this.dataGridView1.Columns[3].HeaderText = "价格";
            this.dataGridView1.Columns[4].HeaderText = "出版社";
            this.dataGridView1.Columns[5].HeaderText = "出版日期";
            this.dataGridView1.Columns[6].HeaderText = "是否已借";
            this.dataGridView1.Columns[7].HeaderText = "借书用户";

            conn.Close();
        }

    }
}
