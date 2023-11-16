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
    public partial class Form_editPassword : Form
    {
        private Users_proc users_Proc = new Users_proc();

        public Form_editPassword()
        {
            InitializeComponent();
        }

        private void clearTxtboxs()
        {
            txt_password.Text = string.Empty;
            txt_newPass.Text = string.Empty;
            txt_newPass2.Text = string.Empty;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != UserManager.Instance.ThePassword)
            {
                clearTxtboxs();
                MessageBox.Show("Mật khẩu hiện tại của bạn vừa nhập không đúng! \nVui lòng kiểm tra lại!", "Thông báo");
            }
            else if (txt_password.Text == UserManager.Instance.ThePassword)
            {
                if (IsStrongPassword(txt_newPass.Text) == false)
                {
                    clearTxtboxs();
                    MessageBox.Show("Mật khẩu mới của bạn quá yếu! \nVui lòng chọn mật khẩu khác dài tối thiểu 8 ký tự, trong đó có ít nhất 1 chữ cái HOA, 1 chữ cái thường, 1 số và 1 ký tự đặc biệt!", "Thông báo");
                }
                else if (IsStrongPassword(txt_newPass.Text) == true)
                {
                    if (txt_newPass.Text != txt_newPass2.Text || txt_newPass.Text == "" || txt_newPass2.Text == "")
                    {
                        clearTxtboxs();
                        MessageBox.Show("Mật khẩu mới của bạn chưa được xác nhận là đúng! \nVui lòng kiểm tra lại!", "Thông báo");
                    }
                    else if (txt_newPass.Text == txt_newPass2.Text || txt_newPass.Text != "" || txt_newPass2.Text != "")
                    {
                        if (users_Proc.UpdateUserPassword(UserManager.Instance.TheUserID, txt_newPass.Text))
                        {
                            MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo");
                            UserManager.Instance.ThePassword = txt_newPass.Text;
                            clearTxtboxs();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thay đổi mật khẩu thất bại, vui lòng thử lại sau!", "Thông báo");
                            clearTxtboxs();
                            this.Close();
                        }
                    }
                }
            }
        }

        private bool IsStrongPassword(string newpassword)
        {
            if (newpassword.Length < 8)
            {
                return false;
            }

            if (!newpassword.Any(char.IsLower))
            {
                return false;
            }

            if (!newpassword.Any(char.IsUpper))
            {
                return false;
            }

            if (!newpassword.Any(char.IsDigit))
            {
                return false;
            }

            if (!newpassword.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return false;
            }

            return true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearTxtboxs();
            this.Close();
        }
    }
}
