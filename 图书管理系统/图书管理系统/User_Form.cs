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
        ComboBox combox;
        SqlDataAdapter dataadapter;
        private string LoginName="";
        int logintype = 0;
        public User_Form(string Loginname)
        {
            InitializeComponent();
            //保存登陆的用户名
            combox = new ComboBox();
            this.LoginName = Loginname;
            this.Text = "欢迎您读者 " + Loginname;
            if (LoginedInfo.Logintype == 0)
            {
                myrebookbutton.Visible = false;
                borrowbook_button.Visible = false;
            }
            this.combox.SelectedIndexChanged += new System.EventHandler(this.combox_SelectedIndexChanged);
            this.dataGridView1.Controls.AddRange(new System.Windows.Forms.Control[] { combox });
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            BindDateGrdView();
        }
        private void BindDateGrdView()
        {

            string sql = "select Book.ID,Book_name,Book_ISBN,Book_Price,Book_Publish,Book_Publist_Time,Book_Status,Book_category.Book_Category from [Book] join Book_category on Book.Book_Category_id=Book_category.ID";
                SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
                conn.Open();
                dataadapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder sqlcmdbuilder = new SqlCommandBuilder(dataadapter);
                //dataadapter.InsertCommand = sqlcmdbuilder.GetInsertCommand();
                //dataadapter.UpdateCommand = sqlcmdbuilder.GetUpdateCommand();
                //dataadapter.DeleteCommand = sqlcmdbuilder.GetDeleteCommand();
                Book = new DataSet();
                dataadapter.Fill(Book, "Book");
                this.dataGridView1.DataSource = Book.Tables["Book"];
                DataGridViewRow t = this.dataGridView1.Rows[0];
                //this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;
                this.dataGridView1.Columns[0].ReadOnly = true;
                this.dataGridView1.Columns[1].HeaderText = "书名";
                this.dataGridView1.Columns[2].HeaderText = "ISBN号";
                this.dataGridView1.Columns[3].HeaderText = "价格";
                this.dataGridView1.Columns[4].HeaderText = "出版社";
                this.dataGridView1.Columns[5].HeaderText = "出版日期";
                this.dataGridView1.Columns[6].HeaderText = "是否已借";
                this.dataGridView1.Columns[7].HeaderText = "类目";
                
                //this.dataGridView1.Columns[7].CellTemplate = new DataGridViewComboBoxCell();
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
                            sqlcmd.Parameters.AddWithValue("userid", LoginedInfo.Userid);
                            sqlcmd.ExecuteNonQuery();
                            dataadapter.Update(Book.Tables[0]);
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("存在别人已经借阅的图书，请重新选择");
                        }
                    }
                }
                BindDateGrdView();


            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("请选择要借的书");
            }
        }

        private void myrebookbutton_Click(object sender, EventArgs e)
        {
            string sql = "select ID,Book_name,Book_ISBN,Book_Price,Book_Publish,Book_Publist_Time from [Book] where User_id='" + LoginedInfo.Userid + "'";
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
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].HeaderText = "书名";
            this.dataGridView1.Columns[2].HeaderText = "ISBN号";
            this.dataGridView1.Columns[3].HeaderText = "价格";
            this.dataGridView1.Columns[4].HeaderText = "出版社";
            this.dataGridView1.Columns[5].HeaderText = "出版日期";

            conn.Close();
        }
        private void combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = combox.SelectedValue;
            for (int j = 0; j < this.dataGridView1.RowCount-1; j++)
            {
                int x=0 ;
                
                if (int.TryParse(this.dataGridView1.Rows[j].Cells[7].Value.ToString(), out x) == true)
                {
                    
                    string updatesql = "update [Book] set Book_name=@bookname,Book_ISBN=@bookisbn,Book_Price=@bookprice,Book_Publish=@bookpublish,Book_Publist_Time=@bookpublictime,Book_Category_id=@bookcategoryid where ID=@ID";
                    SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand(updatesql, conn);
                    sqlcmd.Parameters.AddWithValue("@ID", this.dataGridView1.Rows[j].Cells[0].Value);
                    sqlcmd.Parameters.AddWithValue("@bookname", this.dataGridView1.Rows[j].Cells[1].Value);
                    sqlcmd.Parameters.AddWithValue("@bookisbn", this.dataGridView1.Rows[j].Cells[2].Value);
                    sqlcmd.Parameters.AddWithValue("@bookprice", this.dataGridView1.Rows[j].Cells[3].Value);
                    sqlcmd.Parameters.AddWithValue("@bookpublish", this.dataGridView1.Rows[j].Cells[4].Value);
                    sqlcmd.Parameters.AddWithValue("@bookpublictime", this.dataGridView1.Rows[j].Cells[5].Value);
                    sqlcmd.Parameters.AddWithValue("@bookcategoryid", this.dataGridView1.Rows[j].Cells[7].Value);
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            MessageBox.Show("更新成功");
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(col.ToString());
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int col = this.dataGridView1.CurrentCell.ColumnIndex;
                if (col == 7)
                {
                    DataSet ds;
                    //绘制combox
                    System.Drawing.Rectangle rect = dataGridView1.GetCellDisplayRectangle(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex, false);
                    combox = new ComboBox();
                    combox.DropDownStyle = ComboBoxStyle.DropDownList;
                    string sql = "select * from Book_category";
                    SqlConnection conn = new SqlConnection(Connectionsql.getconstring());
                    conn.Open();
                    SqlDataAdapter sqladapter = new SqlDataAdapter(sql, conn);
                    ds = new DataSet();
                    this.combox.SelectedIndexChanged -= new System.EventHandler(this.combox_SelectedIndexChanged);
                    sqladapter.Fill(ds, "Book_category");
                    combox.DataSource = ds.Tables["Book_category"];
                    //需要显示的字段名这是text值
                    combox.DisplayMember = ds.Tables["Book_category"].Columns[1].ColumnName.ToString();
                    //选项ID的字段名这是value值
                    combox.ValueMember = ds.Tables["Book_category"].Columns[0].ColumnName.ToString();
                    combox.Left = rect.Left;
                    combox.Top = rect.Top;
                    combox.Width = rect.Width;
                    combox.Height = rect.Height;
                    combox.Visible = true;

                    this.dataGridView1.Controls.Add(combox);
                    combox.SelectedIndex = -1;
                    //combox.SelectedIndex = combox.Items.IndexOf("计算机");     
                    dataGridView1.CurrentCell.Value = combox.SelectedValue;
                    this.combox.SelectedIndexChanged += new System.EventHandler(this.combox_SelectedIndexChanged);
                    
                }
                else
                {
                    combox.Visible = false;
                    
                }
            }
            catch
            { }
        }


        }

    }
        


