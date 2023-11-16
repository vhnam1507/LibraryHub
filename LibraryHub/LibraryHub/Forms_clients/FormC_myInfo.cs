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

namespace LibraryHub.Forms_clients
{
    public partial class FormC_myInfo : Form
    {
        private Readers_proc readers_Proc = new Readers_proc();
        private Users_proc users_Proc = new Users_proc();

        public FormC_myInfo()
        {
            InitializeComponent();
        }

        private void lockstatus(int n)
        {
            switch (n)
            {
                case 0:
                    txt_name.Enabled = false;
                    txt_userID.Enabled = false;
                    txt_username.Enabled = false;
                    txt_role.Enabled = false;
                    txt_password.Enabled = false;
                    txt_readerID.Enabled = false;
                    txt_address.Enabled = false;
                    txt_email.Enabled = false;
                    txt_phone.Enabled = false;

                    btn_save.Enabled = false;
                    btn_cancel.Enabled = false;
                    btn_edit.Enabled = true;
                    btn_pass.Enabled = true;
                    break;

                case 1: // trường hợp click add
                    txt_name.Enabled = true;
                    txt_userID.Enabled = false;
                    txt_username.Enabled = true;
                    txt_role.Enabled = false;
                    txt_password.Enabled = false;
                    txt_readerID.Enabled = false;
                    txt_address.Enabled = true;
                    txt_email.Enabled = true;
                    txt_phone.Enabled = true;

                    btn_save.Enabled = true;
                    btn_cancel.Enabled = true;
                    btn_edit.Enabled = false;
                    btn_pass.Enabled = false;
                    break;
            }
        }

        private void loadInfo()
        {
            txt_name.Text = UserManager.Instance.TheName;
            txt_userID.Text = UserManager.Instance.TheUserID;
            txt_username.Text = UserManager.Instance.TheUsername;
            txt_role.Text = UserManager.Instance.TheRoleName;
            txt_password.Text = UserManager.Instance.ThePassword;
            txt_readerID.Text = UserManager.Instance.TheReaderID;
            txt_address.Text = UserManager.Instance.TheReaderAddress;
            txt_email.Text = UserManager.Instance.TheReaderEmail;
            txt_phone.Text = UserManager.Instance.TheReaderPhone;
        }

        private void FormC_myInfo_Load(object sender, EventArgs e)
        {
            loadInfo();
            lockstatus(0);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            lockstatus(1);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string userID = txt_userID.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string readerID = txt_readerID.Text;
            string address = txt_address.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            string resultMessage = "";

            try
            {
                if (users_Proc.CheckUsernameExists(username) == true && username != UserManager.Instance.TheUsername)
                {
                    resultMessage = "Username đã tồn tại, xin hãy chọn một username khác";
                    return;
                }
                if (readers_Proc.UpdateReader(readerID, username, userID, name, address, phone, email, password))
                {
                    resultMessage = "Thông tin độc giả đã được sửa thành công.";
                    UserManager.Instance.TheName = name;
                    UserManager.Instance.TheUserID = userID;
                    UserManager.Instance.TheUsername = username;
                    UserManager.Instance.ThePassword = password;
                    UserManager.Instance.TheReaderID = readerID;
                    UserManager.Instance.TheReaderAddress = address;
                    UserManager.Instance.TheReaderEmail = email;
                    UserManager.Instance.TheReaderPhone = phone;
                }
                else
                {
                    resultMessage = "Sửa thông tin độc giả thất bại.";
                }
            }
            catch (Exception ex) { }
            finally
            {
                lockstatus(0);
                loadInfo();
                MessageBox.Show(resultMessage, "Thông báo");
            }
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            Forms.Form_editPassword form_EditPassword = new Forms.Form_editPassword();
            form_EditPassword.ShowDialog();
            lockstatus(0);
            loadInfo();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lockstatus(0);
            loadInfo();
        }
    }
}
