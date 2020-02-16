using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asgB
{
    class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String DOB { get; set; }

        public Person()
        {
            
        }

        public Person(String firstName, String lastName, String email, String doB)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DOB = doB;
        }

        public Person(String firstName, String lastName, String email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DOB = DateTime.Today.ToString();
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

    }
}
