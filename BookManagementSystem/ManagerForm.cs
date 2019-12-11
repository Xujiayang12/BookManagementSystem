using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace BookManagementSystem
{
    public partial class ManagerForm : Form
    {
        public IDbConnection db = null;
        public Form loginForm = null;
        public User loginUser = null;

        public ManagerForm(Form _form, User _user, IDbConnection _db)
        {
            InitializeComponent();
            loginForm = _form;
            loginUser = _user;
            db = _db;
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var modiForm = new BookModificationForm(db, 0);
            modiForm.ShowDialog();
        }

        private void allnewBookList(string sqlstr)
        {
            var booklist = db.Query<Book>(sqlstr).ToList();
            dataGridView1.DataSource = booklist;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "书名";
            dataGridView1.Columns[2].HeaderText = "作者";
            dataGridView1.Columns[3].HeaderText = "出版社";
            dataGridView1.Columns[4].HeaderText = "出版时间";
            dataGridView1.Columns[5].HeaderText = "分类号";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "ISBN";
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].HeaderText = "存放地点";
            dataGridView1.Columns[8].Width = 280;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[9].HeaderText = "lent";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns.Add("bk_status", "状态");
            dataGridView1.Columns[10].Width = 70;
            DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
            btncol.HeaderText = "编辑";
            btncol.Width = 50;
            dataGridView1.Columns.Add(btncol);
            DataGridViewButtonColumn btncol2 = new DataGridViewButtonColumn();
            btncol2.HeaderText = "删除";
            btncol2.Width = 50;
            dataGridView1.Columns.Add(btncol2);
            for (int i = 0; i < booklist.Count; i++)
            {
                var status = booklist[i].bk_lent;
                if (status == 0)
                {
                    dataGridView1.Rows[i].Cells[10].Value = "可借";
                    dataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Green;
                }
                else if (status == 1)
                {
                    dataGridView1.Rows[i].Cells[10].Value = "借出";
                    dataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Blue;
                }
            }
        }

        private void renewBook(List<Book> booklist)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = booklist;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "书名";
            dataGridView1.Columns[2].HeaderText = "作者";
            dataGridView1.Columns[3].HeaderText = "出版社";
            dataGridView1.Columns[4].HeaderText = "出版时间";
            dataGridView1.Columns[5].HeaderText = "分类号";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "ISBN";
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].HeaderText = "存放地点";
            dataGridView1.Columns[8].Width = 280;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[9].HeaderText = "lent";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns.Add("bk_status", "状态");
            dataGridView1.Columns[10].Width = 70;
            DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
            btncol.HeaderText = "编辑";
            btncol.Width = 50;
            dataGridView1.Columns.Add(btncol);
            DataGridViewButtonColumn btncol2 = new DataGridViewButtonColumn();
            btncol2.HeaderText = "删除";
            btncol2.Width = 50;
            dataGridView1.Columns.Add(btncol2);
            for (int i = 0; i < booklist.Count; i++)
            {
                var status = booklist[i].bk_lent;
                if (status == 0)
                {
                    dataGridView1.Rows[i].Cells[10].Value = "可借";
                    dataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Green;
                }
                else if (status == 1)
                {
                    dataGridView1.Rows[i].Cells[10].Value = "借出";
                    dataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Blue;
                }
            }
        }

        private void renewBookList(string sqlstr)
        {
            var booklist = db.Query<Book>(sqlstr).ToList();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = booklist;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "书名";
            dataGridView1.Columns[2].HeaderText = "作者";
            dataGridView1.Columns[3].HeaderText = "出版社";
            dataGridView1.Columns[4].HeaderText = "出版时间";
            dataGridView1.Columns[5].HeaderText = "分类号";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "ISBN";
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].HeaderText = "存放地点";
            dataGridView1.Columns[8].Width = 280;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[9].HeaderText = "lent";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns.Add("bk_status", "状态");
            dataGridView1.Columns[10].Width = 70;
            DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
            btncol.HeaderText = "编辑";
            btncol.Width = 50;
            dataGridView1.Columns.Add(btncol);
            DataGridViewButtonColumn btncol2 = new DataGridViewButtonColumn();
            btncol2.HeaderText = "删除";
            btncol2.Width = 50;
            dataGridView1.Columns.Add(btncol2);
            for (int i = 0; i < booklist.Count; i++)
            {
                var status = booklist[i].bk_lent;
                if (status == 0)
                {
                    dataGridView1.Rows[i].Cells[10].Value = "可借";
                    dataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Green;
                }
                else if (status == 1)
                {
                    dataGridView1.Rows[i].Cells[10].Value = "借出";
                    dataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Blue;
                }
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            var all_sql = "SELECT * FROM book ORDER BY bk_id DESC ;";
            allnewBookList(all_sql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 11)
            {
                var bookid = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                var modiForm = new BookModificationForm(db, Convert.ToInt32(bookid));
                modiForm.ShowDialog();
            }
            else if (e.ColumnIndex == 12)
            {
                var bookname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var ok = MessageBox.Show("确定删除" + bookname + "?", "确认删除", MessageBoxButtons.OKCancel);
                if (ok == DialogResult.OK)
                {
                    var bookid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    var deletesql = "DELETE FROM book WHERE bk_id=" + bookid.ToString() + ";";
                    try
                    {
                        db.Execute(deletesql);
                        MessageBox.Show("删除成功，刷新看到结果", "删除成功");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        MessageBox.Show("删除失败，有可能是数据库出错", "删除失败");
                    }
                }
            }
            else
            {
                var bookid = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                var infoForm = new BookInfo(db, Convert.ToInt32(bookid));
                infoForm.ShowDialog();
            }
        }

        private void renewBtn_Click(object sender, EventArgs e)
        {
            var all_sql = "SELECT * FROM book ORDER BY bk_id DESC ;";
            renewBookList(all_sql);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var bookid = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var infoForm = new BookInfo(db, Convert.ToInt32(bookid));
            infoForm.ShowDialog();
        }

        private void userManaBtn_Click(object sender, EventArgs e)
        {
            var usermanaForm = new UserManageForm(db);
            usermanaForm.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var searchstr = textBox1.Text;
                var srhtype = comboBox1.Text;
                if (srhtype == "书名")
                {
                    var srhsql = String.Format("SELECT * FROM book WHERE bk_title like '%{0}%'", searchstr);
                    renewBookList(srhsql);
                }
                else if (srhtype == "ISBN")
                {
                    var srhsql = String.Format("SELECT * FROM book WHERE bk_isbn like '%{0}%'", searchstr);
                    renewBookList(srhsql);
                }
                else
                {
                    var srhsql =
                        String.Format(
                            "SELECT * FROM book WHERE bk_title like '%{0}%' or bk_author like '%{0}%' or bk_intro like '%{0}%'",
                            searchstr);
                    renewBookList(srhsql);
                }
            }
        }

        private void bookOutBtn_Click(object sender, EventArgs e)
        {
            var lentoutForm = new LendForm(db, 0);
            lentoutForm.ShowDialog();
        }

        private void bookInBtn_Click(object sender, EventArgs e)
        {
            var backForm = new LendForm(db, 1);
            backForm.ShowDialog();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var ntx = e.Node.Text;
            if (ntx == "全部")
            {
                var all_sql = "SELECT * FROM book ORDER BY bk_id DESC ;";
                renewBookList(all_sql);
            }
            else if (ntx == "借出未超时")
            {
                var nr = new Record();
                nr.r_end = DateTime.Now;
                var booklist =
                    db.Query<Book>(
                        "SELECT * FROM book WHERE bk_id in (SELECT record.r_book from record WHERE r_isreturn=0 and r_end>=@r_end);",
                        nr).ToList();
                renewBook(booklist);
            }
            else if (ntx == "借出已超时")
            {
                var nr = new Record();
                nr.r_end = DateTime.Now;
                var booklist =
                    db.Query<Book>(
                        "SELECT * FROM book WHERE bk_id in (SELECT record.r_book from record WHERE r_isreturn=0 and r_end<@r_end);",
                        nr).ToList();
                renewBook(booklist);
            }
        }

        private void recordManaBtn_Click(object sender, EventArgs e)
        {
            var recordForm = new RecordViewForm(db);
            recordForm.Show();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm.Close();
            this.Close();
        }

        private void 信息更改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changeForm = new EditUserForm(db, loginUser.u_id);
            changeForm.ShowDialog();
        }
    }
}