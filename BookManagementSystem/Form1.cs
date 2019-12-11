using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace BookManagementSystem
{
    public partial class Form1 : Form
    {
        public IDbConnection db = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var serve = serveBox.Text.Trim();
            var account = accountBox.Text.Trim();
            var password = passwordBox.Text.Trim();
            var connString = String.Format("Server={0}; Database=xjybook; Uid=xjybook; Pwd=xjybook;", serve);
            db = new MySqlConnection(connString);
            try
            {
                db.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("无法连接服务器数据库", "连接错误");
            }

            var usersql = String.Format("SELECT * FROM user WHERE u_account='{0}' and u_password='{1}'", account,
                password);
            Console.WriteLine(usersql);
            var userlist = db.Query<User>(usersql).ToList();
            if (userlist.Count == 1)
            {
                MessageBox.Show("登录成功，点击进入系统", "登录成功");
                if (userlist[0].u_isadmin == 1)
                {
                    var managerForm = new ManagerForm(this, userlist[0], db);
                    managerForm.Show();
                }
                else
                {
                    var readerForm = new ReaderForm(this, userlist[0], db);
                    readerForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("密码错误或者不存在此用户", "登录失败");
            }
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            var serve = serveBox.Text;
            var connString = String.Format("Server={0}; Database=xjybook; Uid=xjybook; Pwd=xjybook;", serve);
            db = new MySqlConnection(connString);
            var signupform = new SignForm(db);
            signupform.ShowDialog();
        }
    }
}