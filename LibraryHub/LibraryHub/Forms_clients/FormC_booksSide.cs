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
    public partial class FormC_booksSide : Form
    {
        public FormC_booksSide()
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
