using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace BookManagementSystem
{
    public partial class BookInfo : Form
    {
        public IDbConnection db = null;
        public int bookid = 0;

        public BookInfo(IDbConnection _db, int bkid)
        {
            db = _db;
            bookid = bkid;
            InitializeComponent();
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

        private void newRList(List<Record> rlist)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = rlist;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "借出时间";
            dataGridView1.Columns[4].HeaderText = "应归还时间";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns.Add("re_bookname", "书名");
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns.Add("re_user", "借者");
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add("re_status", "状态");
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i < rlist.Count; i++)
            {
                var isreturn = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                dataGridView1.Rows[i].Cells[6].Value =
                    getBookName(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
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


        private void BookInfo_Load(object sender, EventArgs e)
        {
            var getsql = "SELECT * FROM book WHERE bk_id=" + bookid.ToString() + ";";
            var getbook = db.Query<Book>(getsql).ToList()[0];
            bookNameLabel.Text = getbook.bk_title;
            authorLabel.Text = getbook.bk_author;
            pressLabel.Text = getbook.bk_press;
            timeLabel.Text = getbook.bk_time.Year.ToString();
            catLabel.Text = getbook.bk_category;
            localLabel.Text = getbook.bk_location;
            lendLabel.Text = getbook.bk_lent == 1 ? "已借出" : "可借书";
            isbnLabel.Text = getbook.bk_isbn;
            introLabel.Text = getbook.bk_intro;
            var rsql = "SELECT * FROM record WHERE r_book=" + bookid.ToString() + " order by r_id desc;";
            var getr = db.Query<Record>(rsql).ToList();
            newRList(getr);
        }
    }
}