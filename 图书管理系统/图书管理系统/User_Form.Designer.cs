﻿namespace 图书管理系统
{
    partial class User_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrowbook_button = new System.Windows.Forms.Button();
            this.myrebookbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(934, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // borrowbook_button
            // 
            this.borrowbook_button.Location = new System.Drawing.Point(313, 253);
            this.borrowbook_button.Name = "borrowbook_button";
            this.borrowbook_button.Size = new System.Drawing.Size(75, 23);
            this.borrowbook_button.TabIndex = 1;
            this.borrowbook_button.Text = "借书";
            this.borrowbook_button.UseVisualStyleBackColor = true;
            this.borrowbook_button.Click += new System.EventHandler(this.borrowbook_button_Click);
            // 
            // myrebookbutton
            // 
            this.myrebookbutton.Location = new System.Drawing.Point(617, 253);
            this.myrebookbutton.Name = "myrebookbutton";
            this.myrebookbutton.Size = new System.Drawing.Size(75, 23);
            this.myrebookbutton.TabIndex = 2;
            this.myrebookbutton.Text = "我的已借";
            this.myrebookbutton.UseVisualStyleBackColor = true;
            this.myrebookbutton.Click += new System.EventHandler(this.myrebookbutton_Click);
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 314);
            this.Controls.Add(this.myrebookbutton);
            this.Controls.Add(this.borrowbook_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User_Form";
            this.Text = "读者公共查询";
            this.Load += new System.EventHandler(this.User_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button borrowbook_button;
        private System.Windows.Forms.Button myrebookbutton;
    }
}