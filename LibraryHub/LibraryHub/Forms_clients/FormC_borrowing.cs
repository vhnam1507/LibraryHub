using LibraryHub.Forms_admin;
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
    public partial class FormC_borrowing : Form
    {
        private Borrowings_proc borrowings_Proc = new Borrowings_proc();
        private Readers_proc readers_Proc = new Readers_proc();

        private List<string> SelectedBookID = new List<string>();

        public FormC_borrowing()
        {
            InitializeComponent();
        }

        private void lockstatus()
        {
            txt_id.Enabled = false;
            txt_name.Enabled = false;
            txt_readerID.Enabled = false;
            dtp_start.Enabled = false;
            dtp_end.Enabled = false;
            rad_done.Enabled = false;
            rad_notyet.Enabled = false;

            dgv_borrow.Enabled = true;

            btn_all.Enabled = true;
            btn_done.Enabled = true;
            btn_notyet.Enabled = true;
            btn_late.Enabled = true;
        }

        private void FormC_borrowing_Load(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetBorrowingByReaderID(UserManager.Instance.TheReaderID);
            dgv_borrow.DataSource = dt_borrow;
            lockstatus();
        }

        private void dgv_borrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_borrow.CurrentRow.Selected = true;
            string SelectedBorrowing = dgv_borrow.Rows[e.RowIndex].Cells["borrowingID"].Value.ToString();

            DataTable allInfo = borrowings_Proc.GetAllBorrowingsInfo(SelectedBorrowing);

            if (allInfo.Rows.Count > 0)
            {
                txt_id.Text = allInfo.Rows[0]["borrowingID"].ToString();
                txt_name.Text = allInfo.Rows[0]["name"].ToString();
                txt_readerID.Text = allInfo.Rows[0]["readerID"].ToString();
                dtp_start.Value = (DateTime)allInfo.Rows[0]["startDay"];
                dtp_end.Value = (DateTime)allInfo.Rows[0]["endDay"];

                if (allInfo.Rows[0]["status"].ToString() == "True")
                {
                    rad_done.Checked = true;
                    rad_notyet.Checked = false;
                }
                else if (allInfo.Rows[0]["status"].ToString() == "False")
                {
                    rad_done.Checked = false;
                    rad_notyet.Checked = true;
                }
            }
            lst_books.Items.Clear();
            List<string> list = borrowings_Proc.GetBooksByBorrowingID(txt_id.Text);
            foreach (string items in list)
            {
                Books_proc books_Proc = new Books_proc();
                lst_books.Items.Add(items);
            }
        }

        private void OnEndOfSelection(object sender, EndOfSelectionEventArgs e)
        {
            SelectedBookID.Clear();
            lst_books.Items.Clear();

            foreach (var selectedItem in e.SelectedRows)
            {
                SelectedBookID.Add(selectedItem);
            }

            foreach (string items in SelectedBookID)
            {
                Books_proc books_Proc = new Books_proc();
                lst_books.Items.Add(books_Proc.GetBookInfoByID(items));
            }
        }


        private void btn_done_Click(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetDoneBorrowingsByReaderID(UserManager.Instance.TheReaderID);
            dgv_borrow.DataSource = dt_borrow;
        }

        private void btn_notyet_Click(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetNotYetBorrowingsByReaderID(UserManager.Instance.TheReaderID);
            dgv_borrow.DataSource = dt_borrow;
        }

        private void btn_late_Click(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetLateBorrowingsByReaderID(UserManager.Instance.TheReaderID);
            dgv_borrow.DataSource = dt_borrow;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetBorrowingByReaderID(UserManager.Instance.TheReaderID);
            dgv_borrow.DataSource = dt_borrow;
        }

        public void UpdateBySearch(string searchText)
        {
            DataTable dt_readers = borrowings_Proc.SearchInBorrowingByReaderID(UserManager.Instance.TheReaderID, searchText);
            dgv_borrow.DataSource = dt_readers;
        }

    }
}
