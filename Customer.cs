using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asgB
{
    class Customer : Person
    {
        public Customer()
        {

        }

        public Customer(String firstName, String lastName, String email, String doB, String creationDate, String active)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Email = email;
            this.DOB = doB;
            this.CreationDate = creationDate;
            this.Active = active;
        }

        public String CreationDate {get;set;}
        private String active;
        public String Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    } // end class Customer
}
