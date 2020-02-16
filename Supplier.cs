using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asgB
{
    class Supplier
    {
        public Supplier()
        {

        }

        public Supplier(String supplierName, Person contact)
        {
            this.SupplierName = supplierName;
            this.Contact = contact;
        }


        public Supplier(String supplierName, String contactFirstName, String contactLastName, String email)
        {
            this.SupplierName = supplierName;
            this.Contact = new Person();
            this.Contact.FirstName = contactFirstName;
            this.Contact.LastName = contactLastName;
            this.Contact.Email = email;
        }



        public String SupplierName { get; set; }
        public Person Contact { get; set; }


        public String ContactFirstName { get; set; }
        public String ContactLastname { get; set; }
        public String Email { get; set; }

        public override string ToString()
        {
            return SupplierName;
        }
    }
}
