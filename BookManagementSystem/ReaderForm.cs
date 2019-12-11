using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace BookManagementSystem
{
    public partial class ReaderForm : Form
    {
        public IDbConnection db = null;
        public Form loginForm = null;
        public User loginUser = null;

        public ReaderForm(Form _form, User _user, IDbConnection _db)
        {
            InitializeComponent();
            loginForm = _form;
            loginUser = _user;
            db = _db;
        }

        private void ReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
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

        private string getBookName(int bkid)
        {
            try
            {
                var sqlstr = "SELECT * FROM book WHERE bk_id=" + bkid.ToString() + ";";
                var getbook = db.Query<Book>(sqlstr).ToList()[0];
                return getbook.bk_title;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "此书已删除";
            }
        }

        private string getUserName(int uid)
        {
            try
            {
                var sqlstr = "SELECT * FROM user WHERE u_id=" + uid.ToString() + ";";
                var getuser = db.Query<User>(sqlstr).ToList()[0];
                return getuser.u_name;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "此用户已删除";
            }
        }

        private void renewRecord(string sqlstr)
        {
            dataGridView1.Columns.Clear();
            var getlist = db.Query<Record>(sqlstr).ToList();
            dataGridView1.DataSource = getlist;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "借出时间";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].HeaderText = "应归还时间";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns.Add("re_bookname", "书名");
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add("re_user", "借者");
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns.Add("re_status", "状态");
            for (int i = 0; i < getlist.Count; i++)
            {
                var isreturn = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                dataGridView1.Rows[i].Cells[6].Value =
                    getBookName(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
                Console.WriteLine(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
                dataGridView1.Rows[i].Cells[7].Value =
                    getUserName(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
                if (isreturn == 0)
                {
                    dataGridView1.Rows[i].Cells[8].Value = "未归还";
                    dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Red;
                }
                else if (isreturn == 1)
                {
                    dataGridView1.Rows[i].Cells[8].Value = "已归还";
                    dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Green;
                }
            }
        }

        private void 个人信息更改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changeForm = new EditUserForm(db, loginUser.u_id, 1);
            changeForm.ShowDialog();
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            var all_sql = "SELECT * FROM book ORDER BY bk_id DESC ;";
            var getlist = db.Query<Book>(all_sql).ToList();
            renewBook(getlist);
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var all_sql = "SELECT * FROM book ORDER BY bk_id DESC ;";
            var getlist = db.Query<Book>(all_sql).ToList();
            renewBook(getlist);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            var stype = comboBox1.Text;
            var stext = textBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (stype == "书名")
                {
                    var sqlstr = String.Format("SELECT * FROM book WHERE bk_title like '%{0}%' ORDER BY bk_id DESC;",
                        stext);
                    var getlist = db.Query<Book>(sqlstr).ToList();
                    renewBook(getlist);
                }
                else if (stype == "作者")
                {
                    var sqlstr = String.Format("SELECT * FROM book WHERE bk_author like '%{0}%' ORDER BY bk_id DESC;",
                        stext);
                    var getlist = db.Query<Book>(sqlstr).ToList();
                    renewBook(getlist);
                }
                else if (stype == "书名|作者|简介")
                {
                    var sqlstr = String.Format(
                        "SELECT * FROM book WHERE bk_author like '%{0}%' OR bk_title like '%{0}%' OR bk_intro like '%{0}%' ORDER BY bk_id DESC;",
                        stext);
                    var getlist = db.Query<Book>(sqlstr).ToList();
                    renewBook(getlist);
                }
                else if (stype == "ISBN")
                {
                    var sqlstr = String.Format("SELECT * FROM book WHERE bk_isbn like '%{0}%' ORDER BY bk_id DESC;",
                        stext);
                    var getlist = db.Query<Book>(sqlstr).ToList();
                    renewBook(getlist);
                }
                else
                {
                    var sqlstr = String.Format("SELECT * FROM book WHERE bk_title like '%{0}%' ORDER BY bk_id DESC;",
                        stext);
                    var getlist = db.Query<Book>(sqlstr).ToList();
                    renewBook(getlist);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var firstrow = dataGridView1.Columns[0].Name.ToString();
            if (firstrow == "bk_id")
            {
                var bookid = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                var infoForm = new BookInfo(db, Convert.ToInt32(bookid));
                infoForm.ShowDialog();
            }
            else if (firstrow == "r_id")
            {
                var bookid = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                var infoForm = new BookInfo(db, Convert.ToInt32(bookid));
                infoForm.ShowDialog();
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var choose = e.Node.Text;
            if (choose == "已归还")
            {
                var sqlstr = String.Format(
                    "select r_id, r_book, r_user, r_begin, r_end, r_isreturn from record,book where r_user={0} and r_book=bk_id and r_isreturn=1;",
                    loginUser.u_id.ToString());
                Console.WriteLine(sqlstr);
                renewRecord(sqlstr);
            }
            else if (choose == "未归还")
            {
                var sqlstr = String.Format(
                    "select r_id, r_book, r_user, r_begin, r_end, r_isreturn from record,book where r_user={0} and r_book=bk_id and r_isreturn=0;",
                    loginUser.u_id.ToString());
                Console.WriteLine(sqlstr);
                renewRecord(sqlstr);
            }
            else
            {
                var sqlstr = String.Format(
                    "select r_id, r_book, r_user, r_begin, r_end, r_isreturn from record,book where r_user={0} and r_book=bk_id;",
                    loginUser.u_id.ToString());
                Console.WriteLine(sqlstr);
                renewRecord(sqlstr);
            }
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var all_sql = "SELECT * FROM book ORDER BY bk_id DESC ;";
            var getlist = db.Query<Book>(all_sql).ToList();
            renewBook(getlist);
        }
    }
}