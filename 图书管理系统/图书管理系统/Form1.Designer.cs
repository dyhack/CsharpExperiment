namespace 图书管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.User_radioButton = new System.Windows.Forms.RadioButton();
            this.Admin_radioButton = new System.Windows.Forms.RadioButton();
            this.Username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginLabel.Location = new System.Drawing.Point(91, 35);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(283, 29);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "图书馆管理信息系统";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.User_radioButton);
            this.panel1.Controls.Add(this.Admin_radioButton);
            this.panel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(96, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 52);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // User_radioButton
            // 
            this.User_radioButton.AutoSize = true;
            this.User_radioButton.Location = new System.Drawing.Point(198, 20);
            this.User_radioButton.Name = "User_radioButton";
            this.User_radioButton.Size = new System.Drawing.Size(53, 18);
            this.User_radioButton.TabIndex = 1;
            this.User_radioButton.TabStop = true;
            this.User_radioButton.Text = "读者";
            this.User_radioButton.UseVisualStyleBackColor = true;
            // 
            // Admin_radioButton
            // 
            this.Admin_radioButton.AutoSize = true;
            this.Admin_radioButton.Location = new System.Drawing.Point(26, 20);
            this.Admin_radioButton.Name = "Admin_radioButton";
            this.Admin_radioButton.Size = new System.Drawing.Size(67, 18);
            this.Admin_radioButton.TabIndex = 0;
            this.Admin_radioButton.TabStop = true;
            this.Admin_radioButton.Text = "管理员";
            this.Admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(96, 160);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(41, 12);
            this.Username_label.TabIndex = 2;
            this.Username_label.Text = "用户名";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(98, 205);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(29, 12);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "密码";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(165, 157);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(145, 21);
            this.username_textBox.TabIndex = 4;
            this.username_textBox.Tag = "";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(165, 202);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(145, 21);
            this.password_textBox.TabIndex = 5;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(114, 239);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 6;
            this.submit_button.Text = "确定";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(272, 239);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 281);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "登陆窗口";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton User_radioButton;
        private System.Windows.Forms.RadioButton Admin_radioButton;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button cancel_button;
    }
}

