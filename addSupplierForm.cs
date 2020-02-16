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
    public partial class addSupplierForm : Form
    {
        public Boolean Valid;

        public addSupplierForm()
        {
            InitializeComponent();
            Valid = false;
        }

        public addSupplierForm(String supplierName,String contactFirstName, String contactLastName, String email)
        {
            InitializeComponent();
            this.SupplierName = supplierName;
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.Email = email;
        }

        public String SupplierName
        {
            get
            {
                return supplierNameTextBox.Text;
            }
            set
            {
                supplierNameTextBox.Text = value;
            }
        }

        public String ContactFirstName
        {
            get
            {
                return contactFirstNameTextBox.Text;
            }
            set
            {
                contactFirstNameTextBox.Text = value;
            }
        }

        public String ContactLastName
        {
            get
            {
                return contactLastNameTextBox.Text;
            }
            set
            {
                contactLastNameTextBox.Text = value;
            }
        }

        public String Email
        {
            get
            {
                return contactEmailTextBox.Text;
            }
            set
            {
                contactEmailTextBox.Text = value;
            }
        }





        private void cancelCustomerButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Valid = false;
            this.Close();
        }

        private Boolean isDataValid()
        {
            bool valid = true;

            if(supplierNameTextBox.Text == "")
            {
                MessageBox.Show("The supplier name is missing");
                valid = false;
            }
            if(contactFirstNameTextBox.Text == "")
            {
                MessageBox.Show("Enter a first name for contact");

                valid = false;
            }
            if(contactLastNameTextBox.Text == "")
            {
                MessageBox.Show("Enter a last name for contact");

                valid = false;
            }
            if(contactEmailTextBox.Text == "")
            {
                MessageBox.Show("Enter a contact email");

                valid = false;
            }

            return valid;
        }

        //supplier
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if(isDataValid())
            {
                this.Valid = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Valid = false;
               // this.DialogResult = DialogResult.Cancel;
                //MessageBox.Show("You entered invalid data.");
            }
        }
    }
}
