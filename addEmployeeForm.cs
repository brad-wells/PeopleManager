using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asgB
{
    public partial class addEmployeeForm : Form
    {
        public Boolean Valid { get; set; }

        public addEmployeeForm()
        {
            InitializeComponent();
            Valid = false;
        }






       
       
        
        public addEmployeeForm(String firstName, String lastName, String email, String dOB, double salary, String department)
        {


            InitializeComponent();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DOB = dOB;
            this.Salary = salary;
            this.Department = department;
            Valid = false;
        }

           



        public String FirstName
        {
            get
            {
                return firstNameTextBox.Text;
            }
            set
            {
                firstNameTextBox.Text = value;
            }
        }

        public String LastName
        {
            get
            {
                return lastNameTextBox.Text;
            }
            set
            {
                lastNameTextBox.Text = value;
            }
        }

        public String Email
        {
            get
            {
                return emailTextBox.Text;
            }
            set
            {
                emailTextBox.Text = value;
            }
        }

        public String DOB
        {
            get
            {
                return dobDateTimePicker.Text;
            }
            set
            {
                dobDateTimePicker.Text = value;
            }
        }

        public double Salary
        {
            get
            {

                try
                {
                    double s = Convert.ToDouble(salaryTextBox.Text);
                    return s;
                }
                catch(Exception s)
                {
                    throw new Exception("Salary must be a number");  //this one is NotFiniteNumberException being thrown
                }
            }
            set
            {
                salaryTextBox.Text = value.ToString();
            }
        }

        public String Department
        {
            get
            {
                return employeeDepartmentTextBox.Text;
            }
            set
            {
                employeeDepartmentTextBox.Text = value;
            }
        }

        private void addEmployeeForm_Load(object sender, EventArgs e)
        {


        }

        private void cancelEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Valid = false;
            this.Close();
        }

        private Boolean isDataValid()
        {
            bool valid = true;

            if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("You must enter a first name!");
                valid = false;
            }
            if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("You must enter a last name!");
                valid = false;
            }
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("You must enter a email address!");
                valid = false;
            }
            if (dobDateTimePicker.Text == "")
            {
                MessageBox.Show("You must select a date");
                valid = false;
            }
            ///sal and dep here??????? ---yes
            ///

            if (salaryTextBox.Text == "")
            {
                MessageBox.Show("You must enter a salary");
                valid = false;
            }


            // }


            try
            {
                

                double s = Convert.ToDouble(salaryTextBox.Text);

                if ( (s < 0) )
                {
                    valid = false;
                    //MessageBox.Show("Enter a positive number.");
                    throw new Exception("Enter a positive number");
                }

                bool hasNums = salaryTextBox.Text.ToCharArray().Any(Char.IsDigit);
                //foreach(char c in salaryTextBox.Text)
                //{
                if (!hasNums)
                {
                    valid = false;
                    //throw new Exception("Enter a number for salary.");

                    MessageBox.Show("Enter a number for salary.");


                }

                
                
                   
                
            }
            catch(Exception convert)
            {
                MessageBox.Show(convert.Message);
            }

            
            if (employeeDepartmentTextBox.Text == "")
            {
                valid = false;
            }

            if (employeeDepartmentTextBox.Text == "")
            {
                MessageBox.Show("You must enter a department");
                valid = false;

            }

            return valid;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {

            if (isDataValid())
            {
                this.Valid = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Valid = false;
               // MessageBox.Show("You entered invalid data.");
                
            }

            //addEmployeeForm ef = new addEmployeeForm();
            //if(ef.ShowDialog() == DialogResult.OK)
            //{
            //    Person p = new Person();
            //    p.firstName = ef.FirstName;
            //    p.lastName = ef.LastName;
            //    p.email = ef.Email;
            //    p.dOB = ef.DOB;

                
            //}
        }
    }
}
