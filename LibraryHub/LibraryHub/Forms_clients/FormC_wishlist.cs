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
    public partial class FormC_wishlist : Form
    {
        private Books_proc books_Proc = new Books_proc();

        public FormC_wishlist()
        {
            InitializeComponent();
        }

        private void FormC_wishlist_Load(object sender, EventArgs e)
        {
            DataTable dt = books_Proc.GetWishlist(UserManager.Instance.TheReaderID);
            dgv_wish.DataSource = dt;
        }

        public void UpdateBySearch(string searchtext)
        {
            DataTable dt_books = books_Proc.SearchInWishlist(UserManager.Instance.TheReaderID, searchtext);
            dgv_wish.DataSource = dt_books;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Hãy chọn một quyển sách để xóa.");
                return;
            }

            if (books_Proc.DeleteWish(UserManager.Instance.TheReaderID, txt_id.Text))
            {
                MessageBox.Show("Sách đã được xóa thành công.");
                // Sau khi xóa, cần làm mới danh sách học sinh

                dgv_wish.DataSource = books_Proc.GetWishlist(UserManager.Instance.TheReaderID);
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
        }

        private void dgv_wish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_wish.CurrentRow.Selected = true;
            txt_id.Text = dgv_wish.Rows[e.RowIndex].Cells["bookID"].Value.ToString();
            txt_name.Text = dgv_wish.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_author.Text = dgv_wish.Rows[e.RowIndex].Cells["author"].Value.ToString();
            txt_gen.Text = dgv_wish.Rows[e.RowIndex].Cells["category"].Value.ToString();
            txt_publisher.Text = dgv_wish.Rows[e.RowIndex].Cells["publisher"].Value.ToString();
            num_total.Value = Convert.ToInt32(dgv_wish.Rows[e.RowIndex].Cells["total"].Value);
            num_onstock.Value = Convert.ToInt32(dgv_wish.Rows[e.RowIndex].Cells["onStock"].Value);
            num_borrowing.Value = Convert.ToInt32(dgv_wish.Rows[e.RowIndex].Cells["borrowed"].Value);
        }
    }
}
