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
    public partial class Book_Category : Form
    {
        DataSet Book_category;
        SqlDataAdapter dataadapter;
        private string LoginName = "";
        public Book_Category()
        {
            InitializeComponent();
            BindDateGrdView();
        }

        private void Book_Category_Load(object sender, EventArgs e)
        {

        }
        private void BindDateGrdView()
        {
            string sql = "select * from Book_Category";
            SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
            conn.Open();
            dataadapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder sqlcmdbuilder = new SqlCommandBuilder(dataadapter);
            dataadapter.InsertCommand = sqlcmdbuilder.GetInsertCommand();
            dataadapter.UpdateCommand = sqlcmdbuilder.GetUpdateCommand();
            dataadapter.DeleteCommand = sqlcmdbuilder.GetDeleteCommand();
            Book_category = new DataSet();
            dataadapter.Fill(Book_category, "Book_category");
            this.dataGridView1.DataSource = Book_category.Tables[0];
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].HeaderText = "类名";

            conn.Close();
        }

        private void Book_Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Book_category.HasChanges())
            {
                if (DialogResult.OK == MessageBox.Show("你确定保存并退出应用程序吗？", "保存数据提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    dataadapter.Update(Book_category.Tables[0]);
                    MessageBox.Show("更新数据成功");
                    BindDateGrdView();
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try{
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBox.Show("您确定要删除本条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    this.dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                dataadapter.Update(Book_category.Tables[0]);
                BindDateGrdView();
            }


            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("请选择要删除的行");
            }
        }
    }
}
