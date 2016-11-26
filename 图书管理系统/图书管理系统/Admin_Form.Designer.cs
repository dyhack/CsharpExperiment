namespace 图书管理系统
{
    partial class Admin_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_groupbox = new System.Windows.Forms.GroupBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.adduser_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.deluser_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.add_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(715, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // add_groupbox
            // 
            this.add_groupbox.Controls.Add(this.cancel_button);
            this.add_groupbox.Controls.Add(this.adduser_button);
            this.add_groupbox.Controls.Add(this.password_textBox);
            this.add_groupbox.Controls.Add(this.username_textBox);
            this.add_groupbox.Controls.Add(this.password_label);
            this.add_groupbox.Controls.Add(this.Username_label);
            this.add_groupbox.Location = new System.Drawing.Point(127, 173);
            this.add_groupbox.Name = "add_groupbox";
            this.add_groupbox.Size = new System.Drawing.Size(422, 122);
            this.add_groupbox.TabIndex = 1;
            this.add_groupbox.TabStop = false;
            this.add_groupbox.Text = "添加读者";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(302, 80);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(90, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // adduser_button
            // 
            this.adduser_button.Location = new System.Drawing.Point(302, 34);
            this.adduser_button.Name = "adduser_button";
            this.adduser_button.Size = new System.Drawing.Size(90, 23);
            this.adduser_button.TabIndex = 4;
            this.adduser_button.Text = "添加";
            this.adduser_button.UseVisualStyleBackColor = true;
            this.adduser_button.Click += new System.EventHandler(this.adduser_butto_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(93, 82);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(158, 21);
            this.password_textBox.TabIndex = 3;
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(93, 34);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(158, 21);
            this.username_textBox.TabIndex = 2;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("宋体", 9F);
            this.password_label.Location = new System.Drawing.Point(50, 85);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(29, 12);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "密码";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("宋体", 9F);
            this.Username_label.Location = new System.Drawing.Point(38, 37);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(41, 12);
            this.Username_label.TabIndex = 0;
            this.Username_label.Text = "用户名";
            // 
            // deluser_button
            // 
            this.deluser_button.Location = new System.Drawing.Point(630, 207);
            this.deluser_button.Name = "deluser_button";
            this.deluser_button.Size = new System.Drawing.Size(75, 23);
            this.deluser_button.TabIndex = 2;
            this.deluser_button.Text = "删除";
            this.deluser_button.UseVisualStyleBackColor = true;
            this.deluser_button.Click += new System.EventHandler(this.deluser_button_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 307);
            this.Controls.Add(this.deluser_button);
            this.Controls.Add(this.add_groupbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.add_groupbox.ResumeLayout(false);
            this.add_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox add_groupbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Button adduser_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button deluser_button;
    }
}