using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Renci.SshNet.Security;

namespace BookManagementSystem
{
    public partial class UserManageForm : Form
    {
        public IDbConnection db = null;

        public UserManageForm(IDbConnection _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void allNewUserList(string sqlstr)
        {
            var userlist = db.Query<User>(sqlstr).ToList();
            dataGridView1.DataSource = userlist;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "账户";
            dataGridView1.Columns[2].HeaderText = "姓名";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].HeaderText = "性别";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].HeaderText = "联系电话";
            dataGridView1.Columns[5].HeaderText = "密码";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns.Add("user_status", "是否管理员");
            DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
            btncol.HeaderText = "编辑";
            btncol.Width = 50;
            dataGridView1.Columns.Add(btncol);
            DataGridViewButtonColumn btncol2 = new DataGridViewButtonColumn();
            btncol2.HeaderText = "删除";
            btncol2.Width = 50;
            dataGridView1.Columns.Add(btncol2);
            for (int i = 0; i < userlist.Count; i++)
            {
                var admin = userlist[i].u_isadmin;
                if (admin == 0)
                {
                    dataGridView1.Rows[i].Cells[7].Value = "否";
                }
                else if (admin == 1)
                {
                    dataGridView1.Rows[i].Cells[7].Value = "是";
                }
            }
        }

        private void renewUserList(string sqlstr)
        {
            var userlist = db.Query<User>(sqlstr).ToList();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = userlist;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "账户";
            dataGridView1.Columns[2].HeaderText = "姓名";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].HeaderText = "性别";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].HeaderText = "联系电话";
            dataGridView1.Columns[5].HeaderText = "密码";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns.Add("user_status", "是否管理员");
            DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
            btncol.HeaderText = "编辑";
            btncol.Width = 50;
            dataGridView1.Columns.Add(btncol);
            DataGridViewButtonColumn btncol2 = new DataGridViewButtonColumn();
            btncol2.HeaderText = "删除";
            btncol2.Width = 50;
            dataGridView1.Columns.Add(btncol2);
            for (int i = 0; i < userlist.Count; i++)
            {
                var admin = userlist[i].u_isadmin;
                if (admin == 0)
                {
                    dataGridView1.Rows[i].Cells[7].Value = "否";
                }
                else if (admin == 1)
                {
                    dataGridView1.Rows[i].Cells[7].Value = "是";
                }
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            var adminsignForm = new SignForm(db, 1);
            adminsignForm.ShowDialog();
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            var usersql = "SELECT * FROM user;";
            allNewUserList(usersql);
        }

        private void renew_Click(object sender, EventArgs e)
        {
            var usersql = "SELECT * FROM user;";
            renewUserList(usersql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var uid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 8)
            {
                var editForm = new EditUserForm(db, uid);
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == 9)
            {
                var uname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var ok = MessageBox.Show("确定删除" + uname + "?", "确认删除", MessageBoxButtons.OKCancel);
                if (ok == DialogResult.OK)
                {
                    var deletesql = "DELETE FROM user WHERE u_id=" + uid.ToString() + ";";
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
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var search = textBox1.Text;
                var srhsql = String.Format("SELECT * FROM user WHERE u_account like '%{0}%' or u_name like '%{0}%'",
                    search);
                renewUserList(srhsql);
            }
        }
    }
}