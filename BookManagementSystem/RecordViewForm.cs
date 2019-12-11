using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace BookManagementSystem
{
    public partial class RecordViewForm : Form
    {
        public IDbConnection db = null;

        public RecordViewForm(IDbConnection _db)
        {
            db = _db;
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

        private void renewRecord(List<Record> rlist)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = rlist;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "借出时间";
            dataGridView1.Columns[4].HeaderText = "应归还时间";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns.Add("re_bookname", "书名");
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add("re_user", "借者");
            dataGridView1.Columns.Add("re_status", "状态");
            for (int i = 0; i < rlist.Count; i++)
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

        private void RecordViewForm_Load(object sender, EventArgs e)
        {
            var sqlstr = "SELECT * FROM record ORDER BY r_id DESC;";
            var getlist = db.Query<Record>(sqlstr).ToList();
            renewRecord(getlist);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var searchtype = comboBox1.Text;
                if (searchtype == "书名")
                {
                    var searchtext = textBox1.Text;
                    var sqlstr =
                        String.Format(
                            "select distinct r_id, r_book, r_user, r_begin, r_end, r_isreturn from record, book where book.bk_title like '%{0}%' and book.bk_id=record.r_book order by r_id desc ;",
                            searchtext);
                    var getlist = db.Query<Record>(sqlstr).ToList();
                    Console.WriteLine(sqlstr);
                    renewRecord(getlist);
                    textBox1.Text = "";
                }
                else if (searchtype == "借者")
                {
                    var searchtext = textBox1.Text;
                    var sqlstr =
                        String.Format(
                            "select distinct r_id, r_book, r_user, r_begin, r_end, r_isreturn from record, user where user.u_name like '%{0}%' and user.u_id=record.r_user order by r_id desc ;",
                            searchtext);
                    var getlist = db.Query<Record>(sqlstr).ToList();
                    Console.WriteLine(sqlstr);
                    renewRecord(getlist);
                    textBox1.Text = "";
                }
                else
                {
                    var searchtext = textBox1.Text;
                    var sqlstr =
                        String.Format(
                            "select distinct r_id, r_book, r_user, r_begin, r_end, r_isreturn from record, book where book.bk_title like '%{0}%' and book.bk_id=record.r_book order by r_id desc ;",
                            searchtext);
                    var getlist = db.Query<Record>(sqlstr).ToList();
                    Console.WriteLine(sqlstr);
                    renewRecord(getlist);
                    textBox1.Text = "";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var bookid = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            var infoForm = new BookInfo(db, Convert.ToInt32(bookid));
            infoForm.ShowDialog();
        }
    }
}