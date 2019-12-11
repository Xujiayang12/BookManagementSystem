using System.ComponentModel;

namespace BookManagementSystem
{
    partial class BookInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(BookInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pressLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.catLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.localLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.introLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lendLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "书籍名称";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.Location = new System.Drawing.Point(151, 33);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(368, 37);
            this.bookNameLabel.TabIndex = 1;
            this.bookNameLabel.Text = "label2";
            // 
            // authorLabel
            // 
            this.authorLabel.Location = new System.Drawing.Point(151, 71);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(230, 37);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "书籍作者";
            // 
            // pressLabel
            // 
            this.pressLabel.Location = new System.Drawing.Point(151, 109);
            this.pressLabel.Name = "pressLabel";
            this.pressLabel.Size = new System.Drawing.Size(230, 37);
            this.pressLabel.TabIndex = 5;
            this.pressLabel.Text = "label2";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(64, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "出版社";
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(151, 147);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(230, 37);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "label2";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(64, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "出版时间";
            // 
            // catLabel
            // 
            this.catLabel.Location = new System.Drawing.Point(151, 185);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(230, 37);
            this.catLabel.TabIndex = 9;
            this.catLabel.Text = "label2";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(64, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "分类号";
            // 
            // isbnLabel
            // 
            this.isbnLabel.Location = new System.Drawing.Point(151, 223);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(230, 37);
            this.isbnLabel.TabIndex = 11;
            this.isbnLabel.Text = "label2";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(64, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 37);
            this.label11.TabIndex = 10;
            this.label11.Text = "ISBN";
            // 
            // localLabel
            // 
            this.localLabel.Location = new System.Drawing.Point(151, 261);
            this.localLabel.Name = "localLabel";
            this.localLabel.Size = new System.Drawing.Size(230, 37);
            this.localLabel.TabIndex = 13;
            this.localLabel.Text = "label2";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(64, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 37);
            this.label13.TabIndex = 12;
            this.label13.Text = "存放地点";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(544, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "简介";
            // 
            // introLabel
            // 
            this.introLabel.Location = new System.Drawing.Point(544, 69);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(321, 160);
            this.introLabel.TabIndex = 15;
            this.introLabel.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(876, 285);
            this.dataGridView1.TabIndex = 16;
            // 
            // lendLabel
            // 
            this.lendLabel.Location = new System.Drawing.Point(631, 261);
            this.lendLabel.Name = "lendLabel";
            this.lendLabel.Size = new System.Drawing.Size(230, 37);
            this.lendLabel.TabIndex = 18;
            this.lendLabel.Text = "label2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(544, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "借书状态";
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lendLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.localLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pressLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书籍详情";
            this.Load += new System.EventHandler(this.BookInfo_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label localLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pressLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lendLabel;
    }
}