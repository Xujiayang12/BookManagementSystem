using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace BookManagementSystem
{
    public partial class EditUserForm : Form
    {
        public IDbConnection db = null;
        public int uId = 0;
        public int mode = 0; // 0管理员，1普通用户

        public EditUserForm(IDbConnection _db, int u_id, int _mode = 0)
        {
            InitializeComponent();
            db = _db;
            uId = u_id;
            mode = _mode;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            var usersql = String.Format("SELECT * FROM user WHERE u_id={0};", uId.ToString());
            var user = db.Query<User>(usersql).ToList()[0];
            textBox1.Text = user.u_account;
            textBox2.Text = user.u_name;
            textBox3.Text = user.u_password;
            textBox4.Text = user.u_sex;
            textBox5.Text = user.u_phone;
            textBox6.Text = user.u_isadmin == 0 ? "否" : "是";
            if (mode == 1)
            {
                textBox6.Visible = false;
                label6.Visible = false;
            }
        }

        private void admin_Click()
        {
            var account = textBox1.Text;
            var name = textBox2.Text;
            var password = textBox3.Text;
            var sex = textBox4.Text;
            var phone = textBox5.Text;
            var admin = textBox6.Text == "是" ? 1 : 0;
            var editUser = new User(account, name, sex, phone, password, admin);
            try
            {
                db.Execute(
                    "UPDATE user SET u_account=@u_account, u_name=@u_name, u_password=@u_password, u_sex=@u_sex, u_phone=@u_phone, u_isadmin=@u_isadmin WHERE u_id=" +
                    uId.ToString() + ";",
                    editUser);
                MessageBox.Show("修改成功");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("修改出错");
            }
        }
        
        private void user_Click()
        {
            var account = textBox1.Text;
            var name = textBox2.Text;
            var password = textBox3.Text;
            var sex = textBox4.Text;
            var phone = textBox5.Text;
            var admin = 0;
            var editUser = new User(account, name, sex, phone, password, admin);
            try
            {
                db.Execute(
                    "UPDATE user SET u_account=@u_account, u_name=@u_name, u_password=@u_password, u_sex=@u_sex, u_phone=@u_phone, u_isadmin=@u_isadmin WHERE u_id=" +
                    uId.ToString() + ";",
                    editUser);
                MessageBox.Show("修改成功");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("修改出错");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                admin_Click();
            }
            else
            {
                user_Click();
            }
        }
    }
}