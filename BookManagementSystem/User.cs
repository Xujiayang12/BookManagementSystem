namespace BookManagementSystem
{
    public class User
    {
        public User()
        {
            
        }
        public User(string uAccount, string uName, string uSex, string uPhone, string uPassword, int uAdmin)
        {
            u_account = uAccount;
            u_name = uName;
            u_sex = uSex;
            u_phone = uPhone;
            u_password = uPassword;
            u_isadmin = uAdmin;
        }

        public int u_id { get; set; }
        public string u_account { get; set; }
        public string u_name { get; set; }
        public string u_sex { get; set; }
        public string u_phone { get; set; }
        public string u_password { get; set; }
        public int u_isadmin { get; set; }
    }
}