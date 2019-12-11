using System.ComponentModel;

namespace BookManagementSystem
{
    partial class ManagerForm
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
                new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("借出未超时");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("借出已超时");
            System.Windows.Forms.TreeNode treeNode3 =
                new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {treeNode1, treeNode2});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息更改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addBookBtn = new System.Windows.Forms.ToolStripButton();
            this.userManaBtn = new System.Windows.Forms.ToolStripButton();
            this.recordManaBtn = new System.Windows.Forms.ToolStripButton();
            this.renewBtn = new System.Windows.Forms.ToolStripButton();
            this.bookInBtn = new System.Windows.Forms.ToolStripButton();
            this.bookOutBtn = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.文件ToolStripMenuItem, this.设置ToolStripMenuItem, this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(890, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.注销ToolStripMenuItem, this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.信息更改ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 信息更改ToolStripMenuItem
            // 
            this.信息更改ToolStripMenuItem.Name = "信息更改ToolStripMenuItem";
            this.信息更改ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.信息更改ToolStripMenuItem.Text = "个人信息更改";
            this.信息更改ToolStripMenuItem.Click += new System.EventHandler(this.信息更改ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.使用说明ToolStripMenuItem, this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.addBookBtn, this.userManaBtn, this.recordManaBtn, this.renewBtn, this.bookInBtn, this.bookOutBtn
            });
            this.toolStrip1.Location = new System.Drawing.Point(10, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addBookBtn
            // 
            this.addBookBtn.Image = ((System.Drawing.Image) (resources.GetObject("addBookBtn.Image")));
            this.addBookBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(105, 36);
            this.addBookBtn.Text = "添加书籍";
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // userManaBtn
            // 
            this.userManaBtn.Image = ((System.Drawing.Image) (resources.GetObject("userManaBtn.Image")));
            this.userManaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userManaBtn.Name = "userManaBtn";
            this.userManaBtn.Size = new System.Drawing.Size(105, 36);
            this.userManaBtn.Text = "用户管理";
            this.userManaBtn.Click += new System.EventHandler(this.userManaBtn_Click);
            // 
            // recordManaBtn
            // 
            this.recordManaBtn.Image = ((System.Drawing.Image) (resources.GetObject("recordManaBtn.Image")));
            this.recordManaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recordManaBtn.Name = "recordManaBtn";
            this.recordManaBtn.Size = new System.Drawing.Size(105, 36);
            this.recordManaBtn.Text = "记录管理";
            this.recordManaBtn.Click += new System.EventHandler(this.recordManaBtn_Click);
            // 
            // renewBtn
            // 
            this.renewBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.renewBtn.Image = ((System.Drawing.Image) (resources.GetObject("renewBtn.Image")));
            this.renewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.renewBtn.Name = "renewBtn";
            this.renewBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.renewBtn.Size = new System.Drawing.Size(95, 36);
            this.renewBtn.Text = "刷新";
            this.renewBtn.Click += new System.EventHandler(this.renewBtn_Click);
            // 
            // bookInBtn
            // 
            this.bookInBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bookInBtn.Image = ((System.Drawing.Image) (resources.GetObject("bookInBtn.Image")));
            this.bookInBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookInBtn.Name = "bookInBtn";
            this.bookInBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bookInBtn.Size = new System.Drawing.Size(95, 36);
            this.bookInBtn.Text = "归还";
            this.bookInBtn.Click += new System.EventHandler(this.bookInBtn_Click);
            // 
            // bookOutBtn
            // 
            this.bookOutBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bookOutBtn.Image = ((System.Drawing.Image) (resources.GetObject("bookOutBtn.Image")));
            this.bookOutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookOutBtn.Name = "bookOutBtn";
            this.bookOutBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bookOutBtn.Size = new System.Drawing.Size(95, 36);
            this.bookOutBtn.Text = "借出";
            this.bookOutBtn.Click += new System.EventHandler(this.bookOutBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(10, 72);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "借出未超时";
            treeNode1.ToolTipText = "借出未超时的书籍";
            treeNode2.Name = "节点2";
            treeNode2.Text = "借出已超时";
            treeNode2.ToolTipText = "已超过借书时限但仍未归还的书籍";
            treeNode3.Name = "节点0";
            treeNode3.Text = "全部";
            treeNode3.ToolTipText = "全部书籍";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {treeNode3});
            this.treeView1.Size = new System.Drawing.Size(213, 527);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseClick +=
                new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(670, 492);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(381, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"书名", "ISBN", "书名|作者|简介"});
            this.comboBox1.Location = new System.Drawing.Point(227, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addBookBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton userManaBtn;
        private System.Windows.Forms.ToolStripButton recordManaBtn;
        private System.Windows.Forms.ToolStripButton bookOutBtn;
        private System.Windows.Forms.ToolStripButton bookInBtn;
        private System.Windows.Forms.ToolStripMenuItem 信息更改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton renewBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}