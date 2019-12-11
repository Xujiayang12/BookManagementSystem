using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace BookManagementSystem
{
    public partial class LendForm : Form
    {
        public IDbConnection db = null;
        public int Mode = 0;

        public LendForm(IDbConnection _db, int _mode = 0)
        {
            InitializeComponent();
            db = _db;
            Mode = _mode;
        }

        private void LendForm_Load(object sender, EventArgs e)
        {
            if (Mode == 1)
            {
                button1.Text = "确认还书";
            }
        }

        private int testExist(string stable, string stype, string sval)
        {
            var sqlstr = String.Format("SELECT * FROM {0} WHERE {1}={2}", stable, stype, sval);
            Console.WriteLine(sqlstr);
            var getlist = db.Query(sqlstr).ToList();
            return getlist.Count;
        }

        private int getBookId(string isbn)
        {
            var srhsql = String.Format("SELECT * FROM book WHERE bk_isbn={0}", isbn);
            var getbook = db.Query<Book>(srhsql).ToList()[0];
            return getbook.bk_id;
        }

        private int getBookLent(string isbn)
        {
            var srhsql = String.Format("SELECT * FROM book WHERE bk_isbn={0}", isbn);
            var getbook = db.Query<Book>(srhsql).ToList()[0];
            return getbook.bk_lent;
        }

        private int getUserId(string account)
        {
            var srhsql = String.Format("SELECT * FROM user WHERE u_account='{0}'", account);
            var getuser = db.Query<User>(srhsql).ToList()[0];
            return getuser.u_id;
        }

        private void lendBook()
        {
            var isbn = textBox1.Text;
            var account = textBox2.Text;
            var isbne = testExist("book", "bk_isbn", isbn);
            var accounte = testExist("user", "u_account", account);
            var bkid = 0;
            var uid = 0;
            try
            {
                bkid = getBookId(isbn);
                uid = getUserId(account);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("书籍或账户不存在");
                return;
            }

            var datenow = DateTime.Now;
            var dateend = datenow.AddMonths(2);
            var bklent = getBookLent(isbn);
            if (isbne == 1 && accounte == 1 && bklent == 0)
            {
                try
                {
                    var new_r = new Record(bkid, uid, datenow, dateend);
                    db.Execute(
                        "INSERT INTO record(r_book, r_user, r_begin, r_end) VALUES (@r_book,@r_user,@r_begin,@r_end)",
                        new_r);
                    var changelent = String.Format("UPDATE book SET bk_lent=1 WHERE bk_id={0}", bkid.ToString());
                    db.Execute(changelent);
                    MessageBox.Show("借书成功");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    MessageBox.Show("借书失败");
                }
            }
            else
            {
                MessageBox.Show("书籍或者账户不存在，或者书已经被借出");
            }
        }

        private void backBook()
        {
            var isbn = textBox1.Text;
            var account = textBox2.Text;
            var isbne = testExist("book", "bk_isbn", isbn);
            var accounte = testExist("user", "u_account", account);
            var bkid = 0;
            var uid = 0;
            try
            {
                bkid = getBookId(isbn);
                uid = getUserId(account);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("书籍或账户不存在");
                return;
            }

            var datenow = DateTime.Now;
            var dateend = datenow.AddMonths(2);
            var bklent = getBookLent(isbn);
            if (isbne == 1 && accounte == 1 && bklent == 1)
            {
                try
                {
                    var new_r = new Record(bkid, uid, datenow, dateend);
                    db.Execute(
                        "UPDATE record SET r_isreturn=1 WHERE r_book=@r_book and r_user=@r_user",
                        new_r);
                    var changelent = String.Format("UPDATE book SET bk_lent=0 WHERE bk_id={0}", bkid.ToString());
                    db.Execute(changelent);
                    MessageBox.Show("还书成功");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    MessageBox.Show("还书失败");
                }
            }
            else
            {
                MessageBox.Show("书籍或者账户不存在，或者书已经还了");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Mode == 0)
            {
                lendBook();
            }
            else if (Mode == 1)

            {
                backBook();
            }
        }
    }
}