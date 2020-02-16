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
    public partial class addCustomerForm : Form
    {
        public Boolean Valid { get; set; }

        public addCustomerForm()
        {
            InitializeComponent();
            Valid = false;
        }

        private void creationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.Text = DateTime.Today.ToString();
        }

        public addCustomerForm(String firstName, String lastName, String email, String creationDate, String active)
        {
            InitializeComponent();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CreationDate = creationDate;
            this.Active = active;
            Valid = false;
        }

        public String FirstName
        {
            get
            {
                return customerFirstNameTextBox.Text;
            }

            set
            {
                customerFirstNameTextBox.Text = value;
            }
        }
        public String LastName
        {
            get
            {
                return customerLastNameTextBox.Text;
            }
            set
            {
                customerLastNameTextBox.Text = value;
            }
        }
        public String Email
        {
            get
            {
                return customerEmailTextBox.Text;
            }
            set
            {
                customerEmailTextBox.Text = value;
            }
        }
        public String CreationDate
        {
            get
            {
                return creationDateTimePicker.Text;
            }
            set
            {
                creationDateTimePicker.Text = value;
            }
        }
        public String Active
        {
            get
            {
                return ActiveDisplayLabel.Text;
            }
            set
            {
                ActiveDisplayLabel.Text = value;
            }
        }



        private void cancelCustomerButton_Click(object sender, EventArgs e)
        {
            this.Valid = false;
            this.Close();
        }

        private Boolean isDataValid()
        {
            bool valid = true;

            if (customerFirstNameTextBox.Text == "")
            {
                MessageBox.Show("Enter a first name");
                valid = false;
            }

            if (customerLastNameTextBox.Text == "")
            {
                MessageBox.Show("Enter a last name");

                valid = false;
            }

            if (customerEmailTextBox.Text == "")
            {
                MessageBox.Show("Enter a email address");

                valid = false;
            }

           if (creationDateLabel.Text == "")
            {
                valid = false;
            }

            return valid;


        }

        private void addCustomerButton_Click(object sender, EventArgs e)
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
                //MessageBox.Show("You entered invalid data.");
            }
        }

        private void addCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void customerFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerLastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
