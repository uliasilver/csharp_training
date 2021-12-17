using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests_jk
{
    class ClassFillContact
    {
        private string firstname;
        private string middlename;

        public ClassFillContact(string firstname, string middlename)
        {
            this.firstname = firstname;
            this.middlename = middlename;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Middlename
        {
            get
            {
                return middlename;
            }

            set
            {
                middlename = value;
            }
        }

    }

}
