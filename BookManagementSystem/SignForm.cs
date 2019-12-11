using System;
using System.Data;
using System.Windows.Forms;
using Dapper;

namespace BookManagementSystem
{
    public partial class SignForm : Form
    {
        public IDbConnection db = null;
        public int adminMode = 0;

        public SignForm(IDbConnection _db, int _adminMode = 0)
        {
            InitializeComponent();
            db = _db;
            adminMode = _adminMode;
            if (adminMode == 0)
            {
                comboBox2.Visible = false;
                label6.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var account = textBox1.Text.Trim();
            var name = textBox2.Text.Trim();
            var sex = comboBox1.Text.Trim();
            var phone = textBox4.Text.Trim();
            var password = textBox5.Text.Trim();
            var isadmin = comboBox2.Text.Trim();
            var admin = 0;
            if (isadmin == "是")
            {
                admin = 1;
            }

            var new_user = new User(account, name, sex, phone, password, admin);
            if (name == "" || sex == "" || password == "")
            {
                MessageBox.Show("各个选项都不能为空", "注册失败");
            }
            else
            {
                try
                {
                    db.Execute(
                        "INSERT INTO user(u_account, u_name, u_sex, u_phone, u_password, u_isadmin) VALUES (@u_account, @u_name, @u_sex, @u_phone, @u_password,@u_isadmin)",
                        new_user);
                    MessageBox.Show("注册成功");
                    this.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show("注册失败，数据提交错误，或者账号已存在");
                }
            }
        }
    }
}