using LibraryHub.Forms_admin;
using LibraryHub.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace LibraryHub.Forms_clients
{
    public partial class FormC_dashboard : Form
    {
        public FormC_dashboard()
        {
            InitializeComponent();
        }

        private Form CurrentMain;
        private Form CurrentSide;

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

        private void btn_books_Click(object sender, EventArgs e)
        {
            FormC_booksSide form_BooksSide = new FormC_booksSide();
            FormC_books form_Books = new FormC_books();
            form_BooksSide.SearchPerformed += BookOnSearchPerformed;

            openChildForms(form_Books);
            openChildSides(form_BooksSide);
        }

        private void BookOnSearchPerformed(object sender, string searchText)
        {
            Form_books formC_Books = new Form_books();
            openChildForms(formC_Books);
            formC_Books.UpdateDatabySearch(searchText);
        }

        private void btn_wishlist_Click(object sender, EventArgs e)
        {
            FormC_wishlistSide formC_WishlistSide = new FormC_wishlistSide();
            FormC_wishlist formC_Wishlist = new FormC_wishlist();
            
            formC_WishlistSide.SearchPerformed += WishOnSearchPerformed;

            openChildForms(formC_Wishlist);
            openChildSides(formC_WishlistSide);
        }

        private void WishOnSearchPerformed(object sender, string searchText)
        {
            FormC_wishlist formC_Wishlist = new FormC_wishlist();
            openChildForms(formC_Wishlist);
            formC_Wishlist.UpdateBySearch(searchText);
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            FormC_borrowing formC_Borrowing= new FormC_borrowing();
            FormC_borrowingSide formC_BorrowingSide = new FormC_borrowingSide();

            formC_BorrowingSide.SearchPerformed += BorrowingOnSearchPerformed;

            openChildForms(formC_Borrowing);
            openChildSides(formC_BorrowingSide);
        }

        private void BorrowingOnSearchPerformed(object sender, string searchText)
        {
            FormC_borrowing formC_Borrowing = new FormC_borrowing();
            openChildForms(formC_Borrowing);
            formC_Borrowing.UpdateBySearch(searchText);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            FormC_myInfo formC_myInfo = new FormC_myInfo();
            openChildForms(formC_myInfo);
            if (CurrentSide != null)
            {
                CurrentSide.Close();
            }
        }
    }
}
