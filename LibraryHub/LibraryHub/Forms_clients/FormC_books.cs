using LibraryHub.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryHub.Forms_clients
{
    public partial class FormC_books : Form
    {
        public FormC_books()
        {
            InitializeComponent();
        }

        private Books_proc books_proc = new Books_proc();

        private string MessegeTitle = "Thông báo";

        private void lockstatus()
        {
            txt_id.Enabled = false;
            txt_name.Enabled = false;
            txt_author.Enabled = false;
            txt_gen.Enabled = false;
            txt_publisher.Enabled = false;
            num_total.Enabled = false;
            num_onstock.Enabled = false;
            num_borrowing.Enabled = false;
            dgv_books.Enabled = true;
            dgv_books.ReadOnly = true;
            btn_add.Enabled = true;
        }

        private void FormC_books_Load(object sender, EventArgs e)
        {
            DataTable dt_books = books_proc.GetAllBooks();
            dgv_books.DataSource = dt_books;
            lockstatus();
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
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Hãy chọn một quyển sách để đưa vào Wishlist của bạn.", MessegeTitle);
                return;
            }

            if (books_proc.CheckDuplicateWish(txt_id.Text, UserManager.Instance.TheReaderID) == true)
            {
                MessageBox.Show("Quyển sách này đã có sẵn trong Wishlist của bạn rồi.", MessegeTitle);
                return;
            }

            string resultMessage = "";
            try
            {
                if (books_proc.BookToWishlist(txt_id.Text, UserManager.Instance.TheReaderID))
                {
                    resultMessage = "Sách đã thêm vào wishlist của bạn.";
                }
                else
                {
                    resultMessage = "Thêm vào wishlist thất bại.";
                }
            }
            catch (Exception ex) { }
            finally
            {
                MessageBox.Show(resultMessage, MessegeTitle);
            }
        }

        public void UpdateDatabySearch(string searchText)
        {
            DataTable dt_books = books_proc.SearchInBooks(searchText);
            dgv_books.DataSource = dt_books;
        }

        private void btn_avail_Click(object sender, EventArgs e)
        {
            DataTable dt_books = books_proc.GetAvailableBooks();
            dgv_books.DataSource = dt_books;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            DataTable dt_books = books_proc.GetAllBooks();
            dgv_books.DataSource = dt_books;
        }

        private void btn_borrowed_Click(object sender, EventArgs e)
        {
            DataTable dt_books = books_proc.GetBorrowedBooksByReaderID(UserManager.Instance.TheReaderID);
            dgv_books.DataSource = dt_books;
        }
    }
}
