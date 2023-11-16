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
    public partial class Form_dashboard : Form
    {
        public Form_dashboard()
        {
            InitializeComponent();
        }

        private Form CurrentMain;
        private Form CurrentSide;

        private void openChildForms(Form childForm)
        {
            if (CurrentMain != null)
            {
                CurrentMain.Close();
            }
            CurrentMain = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(childForm);
            pnl_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void openChildSides(Form childForm)
        {
            if (CurrentSide != null)
            {
                CurrentSide.Close();
            }
            CurrentSide = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_side.Controls.Add(childForm);
            pnl_side.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            UserManager.Instance.TheName = "";
            UserManager.Instance.TheUserID = "";
            UserManager.Instance.TheUsername = "";
            UserManager.Instance.ThePassword = "";
            UserManager.Instance.TheReaderID = "";
            UserManager.Instance.TheReaderAddress = "";
            UserManager.Instance.TheReaderEmail = "";
            UserManager.Instance.TheReaderPhone = "";
            this.Close();
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            Form_booksSide form_BooksSide = new Form_booksSide();
            Form_books form_Books = new Form_books();

            form_BooksSide.SearchPerformed += BookOnSearchPerformed;

            openChildForms(form_Books);
            openChildSides(form_BooksSide);
        }

        private void BookOnSearchPerformed(object sender, string searchText)
        {
            Form_books form_Books = new Form_books();
            openChildForms(form_Books);
            form_Books.UpdateDatabySearch(searchText);
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            Form_borrowing form_Borrowing = new Form_borrowing();
            Form_borrowingSide form_BorrowingSide = new Form_borrowingSide();

            form_BorrowingSide.SearchPerformed += BorrowingOnSearchPerformed;
            openChildForms(form_Borrowing);
            openChildSides(form_BorrowingSide);
        }
        private void BorrowingOnSearchPerformed(object sender, string searchText)
        {
            Form_borrowing form_Borrowing = new Form_borrowing();
            openChildForms(form_Borrowing);
            form_Borrowing.UpdateDatabySearch(searchText);
        }

        private void btn_readers_Click(object sender, EventArgs e)
        {
            Form_readers form_Readers = new Form_readers();
            Form_readersSide form_ReadersSide = new Form_readersSide();

            form_ReadersSide.SearchPerformed += ReaderOnSearchPerformed;
            openChildForms(form_Readers);
            openChildSides(form_ReadersSide);
        }
        private void ReaderOnSearchPerformed(object sender, string searchText)
        {
            Form_readers form_Users = new Form_readers();
            openChildForms(form_Users);
            form_Users.UpdateDatabySearch(searchText);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Form_myInfo form_myInfo = new Form_myInfo();
            openChildForms(form_myInfo);

            if (CurrentSide != null)
            {
                CurrentSide.Close();
            }
        }
    }
}
