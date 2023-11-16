using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHub.MyClasses
{
    public class UserManager
    {
        private static UserManager _instance;

        public string TheUserID { get; set; }
        public string TheUsername { get; set; }
        public string TheName { get; set; }
        public string TheRoleID { get; set; }
        public string TheRoleName { get; set; }
        public string ThePassword { get; set; }

        public string TheReaderID { get; set; }
        public string TheReaderPhone { get; set; }
        public string TheReaderAddress { get; set; }
        public string TheReaderEmail { get; set; }

        private UserManager() { }

        public static UserManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserManager();
                return _instance;
            }
        }
    }
}
