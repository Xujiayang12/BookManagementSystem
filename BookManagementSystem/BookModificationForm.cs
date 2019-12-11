using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace BookManagementSystem
{
    public partial class BookModificationForm : Form
    {
        public int bk_id = 0;
        public IDbConnection db = null;

        public BookModificationForm(IDbConnection _db, int _bkId = 0)
        {
            InitializeComponent();
            this.db = _db;
            this.bk_id = _bkId;
            if (bk_id == 0)
            {
                button1.Text = "点击添加";
            }
            else
            {
                var sqlstr = String.Format("SELECT * FROM book WHERE bk_id = {0};", bk_id);
                var old_book = _db.Query<Book>(sqlstr).ToList()[0];
                textBox1.Text = old_book.bk_title;
                textBox2.Text = old_book.bk_author;
                textBox3.Text = old_book.bk_press;
                dateTimePicker1.Value = old_book.bk_time;
                textBox5.Text = old_book.bk_category;
                textBox6.Text = old_book.bk_isbn;
                textBox7.Text = old_book.bk_location;
                textBox9.Text = old_book.bk_intro;
                button1.Text = "点击修改";
            }
        }

        private void addBook()
        {
            var title = textBox1.Text.Trim();
            var author = textBox2.Text.Trim();
            var press = textBox3.Text.Trim();
            var time = dateTimePicker1.Value;
            var category = textBox5.Text.Trim();
            var isbn = textBox6.Text.Trim().Replace("-","");
            var location = textBox7.Text.Trim();
            var intro = textBox9.Text;
            var new_book = new Book(title, author, press, time, category, intro, isbn, location);
            if (title == "" || author == "" || press == "" || category == "" || isbn == "" || location == "")
            {
                MessageBox.Show("除了简介其他值都不能为空");
            }
            else
            {
                try
                {
                    db.Execute(
                        "INSERT INTO book(bk_title, bk_author, bk_press, bk_time, bk_category, bk_intro, bk_isbn, bk_location) VALUES (@bk_title, @bk_author, @bk_press, @bk_time, @bk_category, @bk_intro, @bk_isbn, @bk_location)",
                        new_book);
                    MessageBox.Show("添加成功");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("可能书籍重复，或者选项有非法值");
                    Console.WriteLine(exception);
                }
            }
        }

        private void updateBook()
        {
            var title = textBox1.Text.Trim();
            var author = textBox2.Text.Trim();
            var press = textBox3.Text.Trim();
            var time = dateTimePicker1.Value;
            var category = textBox5.Text.Trim();
            var isbn = textBox6.Text.Trim().Replace("-","");
            var location = textBox7.Text.Trim();
            var intro = textBox9.Text;
            var new_book = new Book(title, author, press, time, category, intro, isbn, location);
            if (title == "" || author == "" || press == "" || category == "" || isbn == "" || location == "")
            {
                MessageBox.Show("除了简介其他值都不能为空");
            }
            else
            {
                try
                {
                    db.Execute(
                        "UPDATE book SET bk_title=@bk_title, bk_author=@bk_author, bk_press=@bk_press, bk_time=@bk_time, bk_category=@bk_category, bk_intro=@bk_intro, bk_isbn=@bk_isbn,bk_location=@bk_location WHERE bk_id=" +
                        bk_id.ToString(),
                        new_book);
                    MessageBox.Show("修改成功");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("选项有非法值，或者数据库连接失败");
                    Console.WriteLine(exception);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bk_id == 0)
            {
                addBook();
                this.Close();
            }
            else
            {
                updateBook();
                this.Close();
            }
        }
    }
}