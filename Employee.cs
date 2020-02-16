using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asgB
{
    class Employee:Person
    {
        public Employee()
        {

        }

        public Employee(String fristName, String lastName, String email, String doB, double salary, String department)
        {
            this.FirstName = fristName;
            this.LastName = lastName;
            this.Email = email;
            this.DOB = doB;
            this.Salary = salary;
            this.Department = department;
        }

        private double salary;
        public double Salary
        {
            
            get
            {
                return salary;
            }

            set
            {

                    salary = value;

                        
            }
        } 

        public String Department { get; set; }
        
    }
}
