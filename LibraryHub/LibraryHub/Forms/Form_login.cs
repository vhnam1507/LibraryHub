using LibraryHub.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryHub.Forms
{
    public partial class Form_login : Form
    {
        private Users_proc users_Proc = new Users_proc();
        private Readers_proc readers_Proc = new Readers_proc();
        private string MessageTitle = "Thông báo";

        public Form_login()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (users_Proc.CheckUsernameExists(txt_username.Text) == false)
            {
                MessageBox.Show("Username không đúng! Hãy kiểm tra và thử lại", MessageTitle);
            }
            else if(users_Proc.CheckUsernameExists(txt_username.Text) == true)
            {
                if (users_Proc.CheckPassword(txt_username.Text, txt_password.Text) == false)
                {
                    MessageBox.Show("Mật khẩu không đúng! Hãy kiểm tra và thử lại", MessageTitle);
                    txt_password.Clear();
                }
                else if (users_Proc.CheckPassword(txt_username.Text, txt_password.Text) == true)
                {
                    UserManager.Instance.TheUserID = users_Proc.GetUserID(txt_username.Text);
                    UserManager.Instance.ThePassword = users_Proc.GetPassword(UserManager.Instance.TheUserID);
                    UserManager.Instance.TheName = users_Proc.GetName(UserManager.Instance.TheUserID);
                    UserManager.Instance.TheRoleID = users_Proc.GetUserRoleID(UserManager.Instance.TheUserID);
                    UserManager.Instance.TheUsername = txt_username.Text;
                    if (UserManager.Instance.TheRoleID == "ROLE01")
                    {
                        UserManager.Instance.TheRoleName = "Thủ thư";
                        this.Close();
                        Forms_admin.Form_dashboard form_Dashboard = new Forms_admin.Form_dashboard();
                        form_Dashboard.Show();
                    }
                    else if(UserManager.Instance.TheRoleID == "ROLE02")
                    {
                        UserManager.Instance.TheRoleName = "Độc giả";
                        UserManager.Instance.TheReaderID = users_Proc.GetReaderID(UserManager.Instance.TheUserID);

                        Tuple<string, string, string> contactInfo = readers_Proc.GetReaderContact(UserManager.Instance.TheReaderID);
                        UserManager.Instance.TheReaderAddress = contactInfo.Item1;
                        UserManager.Instance.TheReaderEmail = contactInfo.Item2;
                        UserManager.Instance.TheReaderPhone = contactInfo.Item3;

                        this.Close();
                        Forms_clients.FormC_dashboard form_Dashboard = new Forms_clients.FormC_dashboard();
                        form_Dashboard.Show();
                    }
                }
            }
        }
    }
}
