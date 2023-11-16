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
    public partial class Form_bookPicking : Form
    {
        private Books_proc books_proc = new Books_proc();
        public List<string> SelectedBookID = new List<string>();
        private int selectedRowCount = 0;

        public Form_bookPicking()
        {
            InitializeComponent();
        }

        public event EventHandler<EndOfSelectionEventArgs> EndOfSelection;

        private void btn_ok_Click(object sender, EventArgs e)
        {
            List<string> selectedRows = new List<string>();
            foreach (DataGridViewRow row in dgv_books.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Check"];
                if (chk != null && chk.Value != null && chk.Value.Equals(true))
                {
                    selectedRows.Add(row.Cells["bookID"].Value.ToString());
                }
            }
            EndOfSelection?.Invoke(this, new EndOfSelectionEventArgs(selectedRows));
            this.Close();
        }

        //Lấy dấu check nếu mà listbox ở form_borrowing chứa sách tương ứng
        private void CheckRowsBySelectedBookID(List<string> selectedBookID)
        {
            foreach (DataGridViewRow row in dgv_books.Rows)
            {
                string rowBookID = row.Cells["bookID"].Value.ToString();
                if (selectedBookID.Contains(rowBookID))
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Check"];
                    if (chk != null)
                    {
                        chk.Value = true;
                    }
                }
            }
        }

        private void Form_bookPicking_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_books.Columns)
            {
                if (column.Name != "Check")
                {
                    column.ReadOnly = true;
                }
            }

            DataTable dt_books = books_proc.GetAvailableBooks();
            dgv_books.DataSource = dt_books;
            CheckRowsBySelectedBookID(SelectedBookID);
        }

        public void UpdateDatabySearch(string searchText)
        {
            DataTable dt_books = books_proc.SearchInBooks(searchText);
            dgv_books.DataSource = dt_books;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            UpdateDatabySearch(txt_search.Text);
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

            int count = CountCheckedCheckBoxes(dgv_books, "check");
            txt_count.Text = count.ToString();
            if (e.ColumnIndex == dgv_books.Columns["check"].Index && e.RowIndex >= 0)
            {
                if (count >= 5)
                {
                    LockAllExceptChecked();
                }
            }
        }

        private int CountCheckedCheckBoxes(DataGridView dataGridView, string checkbox)
        {
            int count = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[checkbox] as DataGridViewCheckBoxCell;

                if (chk != null && (bool)chk.EditedFormattedValue)
                {
                    count++;
                }
            }

            return count;
        }

        private void LockAllExceptChecked()
        {
            foreach (DataGridViewRow row in dgv_books.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["check"] as DataGridViewCheckBoxCell;

                if (chk != null && (bool)chk.EditedFormattedValue)
                {
                    // Nếu checkbox được chọn, bỏ khoá ô
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.ReadOnly = false;
                    }
                }
                else
                {
                    // Nếu checkbox không được chọn, khoá tất cả các ô
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.ReadOnly = true;
                    }
                }
            }
        }

    }
}
