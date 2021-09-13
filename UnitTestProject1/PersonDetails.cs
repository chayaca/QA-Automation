using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class PersonDetails
    {
        public PersonDetails(string fName, string lName, string email, string phone)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.phone = phone;
        }

        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}
