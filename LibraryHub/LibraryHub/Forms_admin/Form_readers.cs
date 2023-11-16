using LibraryHub.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryHub.Forms_admin
{
    public partial class Form_readers : Form
    {
        private Readers_proc readers_proc = new Readers_proc();
        private Users_proc users_proc = new Users_proc();
        private Borrowings_proc borrowings_proc = new Borrowings_proc();

        private string action;
        private string MessegeTitle = "Thông báo";
        private string defaultPassword = "Pass@123";
        public Form_readers()
        {
            InitializeComponent();
        }

        private void lockstatus(int n)
        {
            switch (n)
            {
                case 0:
                    action = "";
                    txt_id.Enabled = false;
                    txt_userID.Enabled = false;
                    txt_name.Enabled = false;
                    txt_username.Enabled = false;
                    txt_phone.Enabled = false;
                    txt_address.Enabled = false;
                    txt_email.Enabled = false;
                    txt_password.Enabled = false;

                    num_total.Enabled = false;
                    num_now.Enabled = false;
                    num_done.Enabled = false;

                    dgv_readers.Enabled = true;

                    btn_save.Enabled = false;
                    btn_cancel.Enabled = false;

                    btn_resetPassword.Enabled = false;
                    btn_add.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_remove.Enabled = false;
                    break;

                case 1: // lock tất cả trừ 3 núi thêm sửa xoá
                    action = "";
                    txt_id.Enabled = false;
                    txt_userID.Enabled = false;
                    txt_name.Enabled = false;
                    txt_username.Enabled = false;
                    txt_phone.Enabled = false;
                    txt_address.Enabled = false;
                    txt_email.Enabled = false;
                    txt_password.Enabled = false;

                    num_total.Enabled = false;
                    num_now.Enabled = false;
                    num_done.Enabled = false;

                    dgv_readers.Enabled = true;

                    btn_save.Enabled = false;
                    btn_cancel.Enabled = false;

                    btn_resetPassword.Enabled = false;
                    btn_add.Enabled = true;
                    btn_edit.Enabled = true;
                    btn_remove.Enabled = true;
                    break;
                case 2: // trường hợp click add
                    action = "add";
                    txt_id.Enabled = false;
                    txt_userID.Enabled = false;
                    txt_name.Enabled = true;
                    txt_username.Enabled = true;
                    txt_phone.Enabled = true;
                    txt_address.Enabled = true;
                    txt_email.Enabled = true;
                    txt_password.Enabled = false;

                    num_total.Enabled = false;
                    num_now.Enabled = false;
                    num_done.Enabled = false;

                    dgv_readers.Enabled = false;

                    btn_save.Enabled = true;
                    btn_cancel.Enabled = true;

                    btn_resetPassword.Enabled = false;
                    btn_add.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_remove.Enabled = false;
                    break;
                case 3:
                    action = "edit";
                    txt_id.Enabled = false;
                    txt_userID.Enabled = false;
                    txt_name.Enabled = true;
                    txt_username.Enabled = true;
                    txt_phone.Enabled = true;
                    txt_address.Enabled = true;
                    txt_email.Enabled = true;
                    txt_password.Enabled = false;

                    num_total.Enabled = false;
                    num_now.Enabled = false;
                    num_done.Enabled = false;

                    dgv_readers.Enabled = false;

                    btn_save.Enabled = true;
                    btn_cancel.Enabled = true;

                    btn_resetPassword.Enabled = true;
                    btn_add.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_remove.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void Form_readers_Load(object sender, EventArgs e)
        {
            DataTable dt_readers = readers_proc.GetAllReaders();
            dgv_readers.DataSource = dt_readers;
            lockstatus(1);
        }

        public void UpdateDatabySearch(string searchText)
        {
            DataTable dt_readers = readers_proc.SearchInReaders(searchText);
            dgv_readers.DataSource = dt_readers;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = readers_proc.GenerateNewReaderID();
            txt_userID.Text = readers_proc.GenerateNewUserID();
            txt_name.Text = "";
            txt_username.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            txt_email.Text = "";
            txt_password.Text = defaultPassword;
            lockstatus(2);
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_password.Text = defaultPassword;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Hãy chọn một độc giả để sửa thông tin.", MessegeTitle);
                return;
            }
            lockstatus(3);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userID.Text))
            {
                MessageBox.Show("Hãy chọn một tài khoản độc giả để xóa.");
                return;
            }

            string userIDtoDelete = txt_userID.Text;

            if (readers_proc.DeleteReader(userIDtoDelete))
            {
                MessageBox.Show("Độc giả đã được xóa thành công.");
                // Sau khi xóa, cần làm mới danh sách học sinh

                dgv_readers.DataSource = readers_proc.GetAllReaders();
            }
            else
            {
                MessageBox.Show("Xóa độc giả thất bại.");
            }

            txt_id.Text = "";
            txt_name.Text = "";
            txt_userID.Text = "";
            txt_username.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            lockstatus(1);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string readerID = txt_id.Text;
            string name = txt_name.Text;
            string username = txt_username.Text;
            string userID = txt_userID.Text;
            string address = txt_address.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            string password = txt_password.Text;
            string total = num_total.Value.ToString();
            string resultMessage = "";

            try
            {
                if (action == "add")
                {
                    if (users_proc.CheckUsernameExists(username) == true)
                    {
                        resultMessage = "Username đã tồn tại, xin hãy chọn một username khác";
                        return;
                    }
                    if (readers_proc.InsertReader(readerID, username, userID, name, address, phone, email, password))
                    {
                        resultMessage = "Độc giả đã được chèn mới thành công.";
                    }
                    else
                    {
                        resultMessage = "Chèn độc giả mới thất bại.";
                    }
                }
                else if (action == "edit")
                {
                    if (readers_proc.UpdateReader(readerID, username, userID, name, address, phone, email, password))
                    {
                        resultMessage = "Thông tin độc giả đã được sửa thành công.";
                    }
                    else
                    {
                        resultMessage = "Sửa thông tin độc giả thất bại.";
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                dgv_readers.DataSource = readers_proc.GetAllReaders();
                txt_id.Text = "";
                txt_name.Text = "";
                txt_userID.Text = "";
                txt_username.Text = "";
                txt_phone.Text = "";
                txt_address.Text = "";
                txt_email.Text = "";
                txt_password.Text = "";
                lockstatus(1);

                MessageBox.Show(resultMessage, MessegeTitle);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dgv_readers.DataSource = readers_proc.GetAllReaders();
            txt_id.Text = "";
            txt_name.Text = "";
            txt_userID.Text = "";
            txt_username.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            lockstatus(1);
        }

        private void dgv_readers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_readers.CurrentRow.Selected = true;
            string SelectedReader = dgv_readers.Rows[e.RowIndex].Cells["readerID"].Value.ToString();

            DataTable allInfo = readers_proc.GetAllReaderInfo(SelectedReader);

            if (allInfo.Rows.Count > 0)
            {
                txt_id.Text = allInfo.Rows[0]["readerID"].ToString();
                txt_name.Text = allInfo.Rows[0]["name"].ToString();
                txt_userID.Text = allInfo.Rows[0]["userID"].ToString();
                txt_username.Text = allInfo.Rows[0]["username"].ToString();
                txt_phone.Text = allInfo.Rows[0]["phone"].ToString();
                txt_address.Text = allInfo.Rows[0]["address"].ToString();
                txt_email.Text = allInfo.Rows[0]["email"].ToString();
                string password = allInfo.Rows[0]["password"].ToString();

                if (password == defaultPassword)
                {
                    txt_password.PasswordChar = '\0';
                    txt_password.Text = password;
                }
                else
                {
                    txt_password.PasswordChar = '●';
                    txt_password.Text = password;
                }

                Tuple<int, int, int> borrowingStats = borrowings_proc.GetReaderBorrowingStats(txt_id.Text);

                num_total.Value = borrowingStats.Item1;
                num_now.Value = borrowingStats.Item2;
                num_done.Value = borrowingStats.Item3;
            }
        }
    }
}
