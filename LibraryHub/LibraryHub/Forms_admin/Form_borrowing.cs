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
    public partial class Form_borrowing : Form
    {
        private Borrowings_proc borrowings_Proc = new Borrowings_proc();
        private Readers_proc readers_Proc = new Readers_proc();
        private DataTable dt_bookPicking = new DataTable();
        private string action;
        private string MessegeTitle = "Thông báo!";
        private List<string> SelectedBookID = new List<string>();

        public Form_borrowing()
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
                    txt_readerID.Enabled = false;
                    dtp_start.Enabled = false;
                    dtp_end.Enabled = false;
                    rad_done.Enabled = false;
                    rad_notyet.Enabled = false;

                    dgv_borrow.Enabled = true;

                    btn_save.Enabled = false;
                    btn_cancel.Enabled = false;

                    btn_all.Enabled = true;
                    btn_done.Enabled = true;
                    btn_notyet.Enabled = true;
                    btn_late.Enabled = true;
                    
                    btn_add.Enabled = true;
                    btn_addBooks.Enabled = false;
                    btn_updateStatus.Enabled = false;
                    break;
                case 1: // lock tất cả trừ 3 núi thêm sửa xoá
                    action = "";
                    txt_id.Enabled = false;
                    txt_name.Enabled = false;
                    txt_readerID.Enabled = false;
                    dtp_start.Enabled = false;
                    dtp_end.Enabled = false;
                    rad_done.Enabled = false;
                    rad_notyet.Enabled = false;

                    dgv_borrow.Enabled = true;

                    btn_save.Enabled = false;
                    btn_cancel.Enabled = false;

                    btn_all.Enabled = true;
                    btn_done.Enabled = true;
                    btn_notyet.Enabled = true;
                    btn_late.Enabled = true;

                    btn_add.Enabled = true;
                    btn_addBooks.Enabled = false;
                    btn_updateStatus.Enabled = true;
                    break;
                case 2: // trường hợp click add
                    action = "add";
                    txt_id.Enabled = false;
                    txt_name.Enabled = false;
                    txt_readerID.Enabled = true;
                    dtp_start.Enabled = false;
                    dtp_end.Enabled = false;
                    rad_done.Enabled = false;
                    rad_notyet.Enabled = false;

                    dgv_borrow.Enabled = false;

                    btn_save.Enabled = true;
                    btn_cancel.Enabled = true;

                    btn_all.Enabled = false;
                    btn_done.Enabled = false;
                    btn_notyet.Enabled = false;
                    btn_late.Enabled = false;

                    btn_add.Enabled = false;
                    btn_addBooks.Enabled = true;
                    btn_updateStatus.Enabled = false;
                    break;
                case 3:
                    action = "updateStatus";
                    txt_id.Enabled = false;
                    txt_name.Enabled = false;
                    txt_readerID.Enabled = false;
                    dtp_start.Enabled = false;
                    dtp_end.Enabled = false;
                    rad_done.Enabled = true;
                    rad_notyet.Enabled = true;

                    dgv_borrow.Enabled = false;

                    btn_all.Enabled = false;
                    btn_done.Enabled = false;
                    btn_notyet.Enabled = false;
                    btn_late.Enabled = false;

                    btn_save.Enabled = true;
                    btn_cancel.Enabled = true;

                    btn_add.Enabled = false;
                    btn_addBooks.Enabled = false;
                    btn_updateStatus.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void Form_borrowing_Load(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetAllBorrowings();
            dgv_borrow.DataSource = dt_borrow;

            DataTable dt_readerID = readers_Proc.GetAllReaderID();

            AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();

            foreach (DataRow row in dt_readerID.Rows)
            {
                autoCompleteSource.Add(row["ReaderID"].ToString());
            }

            txt_readerID.AutoCompleteCustomSource = autoCompleteSource;
            txt_readerID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_readerID.AutoCompleteSource = AutoCompleteSource.CustomSource;

            lockstatus(1);
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

            if (rad_done.Checked == false && rad_notyet.Checked == true)
            {
                lockstatus(1);
            }
            else
            {
                lockstatus(0);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = borrowings_Proc.GenerateNewBorrowingID();
            txt_name.Text = "";
            txt_readerID.Text = "";
            dtp_start.Value = DateTime.Today;
            dtp_end.Value = DateTime.Today.AddDays(14);
            rad_done.Checked = false;
            rad_notyet .Checked = true;
            lst_books.Items.Clear();
            lockstatus(2);
        }

        private void txt_readerID_Validating(object sender, CancelEventArgs e)
        {
            string enteredValue = txt_readerID.Text.Trim();

            DataTable dt_readerID = readers_Proc.GetAllReaderID();
            DataRow[] rows = dt_readerID.Select($"ReaderID = '{enteredValue}'");

            if (rows.Length == 0)
            {
                MessageBox.Show("ID độc giả không đúng. Hãy thử nhập một giá trị khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_readerID.Text = ""; // Xóa giá trị nếu không hợp lệ
                txt_name.Text = "";
                e.Cancel = true;
            }
            else
            {
                txt_name.Text = readers_Proc.GetName(txt_readerID.Text);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_readerID.Text = "";
            lst_books.Items.Clear();
            dtp_start.Value = DateTime.Today;
            dtp_end.Value = DateTime.Today;
            rad_done.Checked = false;
            rad_notyet.Checked = false;
            lockstatus(1);
        }

        private void btn_updateStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Hãy chọn một phiếu mượn để sửa trạng thái.", MessegeTitle);
                return;
            }
            lockstatus(3);
        }

        private void btn_addBooks_Click(object sender, EventArgs e)
        {
            Form_bookPicking form_BookPicking = new Form_bookPicking();
            form_BookPicking.SelectedBookID = SelectedBookID;
            form_BookPicking.EndOfSelection += OnEndOfSelection;
            form_BookPicking.ShowDialog();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string readerID = txt_readerID.Text.ToUpper();
            string start = dtp_start.Value.ToString();
            string end = dtp_end.Value.ToString();
            List<string> books = SelectedBookID;
            string status;
            if (rad_done.Checked)
            {
                status = "True";
            }
            else
            {
                status="False";
            }

            string resultMessage = "";

            try
            {
                if (action == "add")
                {
                    if ( books.Count == 0)
                    {
                        resultMessage = "Thêm phiếu mượn mới thất bại. \nPhiếu mượn không thể được tạo mà không có sách";
                    }
                    else
                    {
                        if (borrowings_Proc.InsertBorrowing(id, readerID, start, end, status, books))
                        {
                            resultMessage = "Phiếu mượn đã được thêm mới thành công.";
                        }
                        else
                        {
                            resultMessage = "Thêm phiếu mượn mới thất bại.";
                        }
                    }
                }
                else if (action == "updateStatus")
                {
                    if (borrowings_Proc.UpdateStatus(id, status))
                    {
                        resultMessage = "Trạng thái phiếu mượn đã được sửa thành công.";
                    }
                    else
                    {
                        resultMessage = "Sửa trạng thái phiếu mượn thất bại.";
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                dgv_borrow.DataSource = borrowings_Proc.GetAllBorrowings();
                txt_id.Text = "";
                txt_name.Text = "";
                txt_readerID.Text = "";
                lst_books.Items.Clear();
                SelectedBookID.Clear();
                books.Clear();
                dtp_start.Value = DateTime.Today;
                dtp_end.Value = DateTime.Today;
                rad_done.Checked = false;
                rad_notyet.Checked = false;
                lockstatus(1);
                MessageBox.Show(resultMessage, MessegeTitle);
            }
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetDoneBorrowings();
            dgv_borrow.DataSource = dt_borrow;
        }

        private void btn_notyet_Click(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetNotYetBorrowings();
            dgv_borrow.DataSource = dt_borrow;
        }

        private void btn_late_Click(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetLateBorrowings();
            dgv_borrow.DataSource = dt_borrow;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            DataTable dt_borrow = borrowings_Proc.GetAllBorrowings();
            dgv_borrow.DataSource = dt_borrow;
        }

        public void UpdateDatabySearch(string searchText)
        {
            DataTable dt_readers = borrowings_Proc.SearchInBorrowing(searchText);
            dgv_borrow.DataSource = dt_readers;
        }
    }
}
