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

namespace LibraryHub.Forms_admin
{
    public partial class Form_books : Form
    {
        private Books_proc books_proc = new Books_proc();

        private string action;
        private string MessegeTitle = "Thông báo";

        public Form_books()
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
                    txt_name.Enabled = false;
                    txt_author.Enabled = false;
                    txt_gen.Enabled = false;
                    txt_publisher.Enabled = false;
                    num_total.Enabled = false;
                    num_onstock.Enabled = false;
                    num_borrowing.Enabled = false;

                    dgv_books.Enabled = true;

                    btn_save.Enabled = false;
                    btn_cancel.Enabled = false;

                    btn_add.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_remove.Enabled = false;
                    break;

                case 1: // lock tất cả trừ 3 núi thêm sửa xoá
                    action = "";
                    txt_id.Enabled = false;
                    txt_name.Enabled = false;
                    txt_author.Enabled = false;
                    txt_gen.Enabled = false;
                    txt_publisher.Enabled = false;
                    num_total.Enabled = false;
                    num_onstock.Enabled = false;
                    num_borrowing.Enabled = false;

                    dgv_books.Enabled = true;

                    btn_save.Enabled = false;
                    btn_cancel.Enabled = false;

                    btn_add.Enabled = true;
                    btn_edit.Enabled = true;
                    btn_remove.Enabled = true;
                    break;
                case 2: // trường hợp click add
                    action = "add";
                    txt_id.Enabled = false;
                    txt_name.Enabled = true;
                    txt_author.Enabled = true;
                    txt_gen.Enabled = true;
                    txt_publisher.Enabled = true;
                    num_total.Enabled = true;
                    num_onstock.Enabled = false;
                    num_borrowing.Enabled = false;

                    dgv_books.Enabled = false;

                    btn_save.Enabled = true;
                    btn_cancel.Enabled = true;

                    btn_add.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_remove.Enabled = false;
                    break;
                case 3:
                    action = "edit";
                    txt_id.Enabled = false;
                    txt_name.Enabled = true;
                    txt_author.Enabled = true;
                    txt_gen.Enabled = true;
                    txt_publisher.Enabled = true;
                    num_total.Enabled = true;
                    num_onstock.Enabled = false;
                    num_borrowing.Enabled = false;

                    dgv_books.Enabled = false;

                    btn_save.Enabled = true;
                    btn_cancel.Enabled = true;

                    btn_add.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_remove.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void Form_books_Load(object sender, EventArgs e)
        {
            DataTable dt_books = books_proc.GetAllBooks();
            dgv_books.DataSource = dt_books;
            lockstatus(1);
        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_books.CurrentRow.Selected = true;
            txt_id.Text = dgv_books.Rows[e.RowIndex].Cells["bookID"].Value.ToString();
            txt_name.Text = dgv_books.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_author.Text = dgv_books.Rows[e.RowIndex].Cells["author"].Value.ToString();
            txt_gen.Text = dgv_books.Rows[e.RowIndex].Cells["category"].Value.ToString();
            txt_publisher.Text = dgv_books.Rows[e.RowIndex].Cells["publisher"].Value.ToString();
            num_total.Value = Convert.ToInt32(dgv_books.Rows[e.RowIndex].Cells["total"].Value);
            num_onstock.Value = Convert.ToInt32(dgv_books.Rows[e.RowIndex].Cells["onStock"].Value);
            num_borrowing.Value = Convert.ToInt32(dgv_books.Rows[e.RowIndex].Cells["borrowed"].Value);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = books_proc.GenerateNewBookID();
            txt_name.Text = "";
            txt_author.Text = "";
            txt_publisher.Text = "";
            txt_gen.Text = "";
            num_total.Value = 0;
            num_onstock.Value = 0;
            num_borrowing.Value = 0;
            lockstatus(2);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Hãy chọn một quyển sách để sửa thông tin.", MessegeTitle);
                return;
            }
            lockstatus(3);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Hãy chọn một quyển sách để xóa.");
                return;
            }

            string bookIDtoDelete = txt_id.Text;

            if (books_proc.DeleteBook(bookIDtoDelete))
            {
                MessageBox.Show("Sách đã được xóa thành công.");
                // Sau khi xóa, cần làm mới danh sách học sinh

                dgv_books.DataSource = books_proc.GetAllBooks();
            }
            else
            {
                MessageBox.Show("Xóa sách thất bại.");
            }

            txt_id.Text = "";
            txt_name.Text = "";
            txt_author.Text = "";
            txt_publisher.Text = "";
            txt_gen.Text = "";
            num_total.Value = 0;
            num_onstock.Value = 0;
            num_borrowing.Value = 0;
            lockstatus(1);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string bookID = txt_id.Text;
            string name = txt_name.Text;
            string author =  txt_author.Text;
            string publisher = txt_publisher.Text;
            string gen = txt_gen.Text;
            string total = num_total.Value.ToString();

            string resultMessage = "";

            try
            {
                if (action == "add")
                {
                    if (books_proc.InsertBook(bookID, name, gen, author, publisher, total))
                    {
                        resultMessage = "Sách đã được chèn mới thành công.";
                    }
                    else
                    {
                        resultMessage = "Chèn sách mới thất bại.";
                    }
                }
                else if (action == "edit")
                {
                    if (books_proc.UpdateBook(bookID, name, gen, author, publisher, total))
                    {
                        resultMessage = "Thông tin sách đã được sửa thành công.";
                    }
                    else
                    {
                        resultMessage = "Sửa thông tin sách thất bại.";
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                dgv_books.DataSource = books_proc.GetAllBooks();
                txt_id.Text = "";
                txt_name.Text = "";
                txt_author.Text = "";
                txt_publisher.Text = "";
                txt_gen.Text = "";
                num_total.Value = 0;
                num_onstock.Value = 0;
                num_borrowing.Value = 0;
                lockstatus(1);

                MessageBox.Show(resultMessage, MessegeTitle);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dgv_books.DataSource = books_proc.GetAllBooks();
            txt_id.Text = "";
            txt_name.Text = "";
            txt_author.Text = "";
            txt_publisher.Text = "";
            txt_gen.Text = "";
            num_total.Value = 0;
            num_onstock.Value = 0;
            num_borrowing.Value = 0;
            lockstatus(1);
        }
        
        public void UpdateDatabySearch(string searchText)
        {
            DataTable dt_books = books_proc.SearchInBooks(searchText);
            dgv_books.DataSource = dt_books;
        }
    }
}
