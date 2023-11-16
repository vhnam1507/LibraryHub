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
    public partial class Form_readersSide : Form
    {
        public Form_readersSide()
        {
            InitializeComponent();
        }

        public event EventHandler<string> SearchPerformed;

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchText = txt_search.Text;
            SearchPerformed?.Invoke(this, searchText);
        }
    }
}
