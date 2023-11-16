using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHub.MyClasses
{
    public class EndOfSelectionEventArgs : EventArgs
    {
        public List<string> SelectedRows { get; }

        public EndOfSelectionEventArgs(List<string> selectedRows)
        {
            SelectedRows = selectedRows;
        }
    }
}
