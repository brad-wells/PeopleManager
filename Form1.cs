/*
 * Brad Wells
 * CIS 247
 * Assignment B
 * 2/16/18
 * This program allows a user to input customers, suppliers, and employees on a Windows Form by using classes and Helperforms
 *      
 */



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
    public partial class AssignmentB : Form
    {
        public AssignmentB()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            { 
                addEmployeeForm ef = new addEmployeeForm();
                
                if (ef.ShowDialog() == DialogResult.OK)
                {

                    Employee p = new Employee();
                    p.FirstName = ef.FirstName;
                    p.LastName = ef.LastName;
                    p.Email = ef.Email;
                    p.DOB = ef.DOB;
                    p.Salary = ef.Salary;
                    p.Department = ef.Department;

                    employeeListBox.Items.Add(p);
                    employeeListBox.Sorted = true;
            }

            }
            catch (Exception add)
            {
                MessageBox.Show(add.Message);
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            addCustomerForm cf = new addCustomerForm();
            if(cf.ShowDialog() == DialogResult.OK)
            {
                Customer c = new Customer();
                c.FirstName = cf.FirstName;
                c.LastName = cf.LastName;
                c.Email = cf.Email;
                c.CreationDate = cf.CreationDate;
                c.Active = cf.Active;

                customerListBox.Items.Add(c);
                customerListBox.Sorted = true;

            }

        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            if(employeeListBox.SelectedItem == null)
            {
                MessageBox.Show("Select an employee to edit");
                return;
            }
            Employee emp = (Employee)employeeListBox.SelectedItem;
            
            addEmployeeForm aef = new addEmployeeForm(emp.FirstName,emp.LastName,emp.Email,emp.DOB,emp.Salary,emp.Department);  ////////////here cant copy product builder and pass in an object

            if (aef.ShowDialog() == DialogResult.OK)
            {
                emp.FirstName = aef.FirstName;
                emp.LastName = aef.LastName;
                emp.DOB = aef.DOB;
                emp.Email = aef.Email;
                emp.Salary = aef.Salary;
                emp.Department = aef.Department;
                

                employeeListBox.Items.Remove(emp);
                employeeListBox.Items.Add(emp);
                employeeListBox.SelectedItem = emp;
                

                
            }
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeListBox.SelectedItem == null)
            {
                MessageBox.Show("Select the employee to delete!");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                employeeListBox.Items.Remove(employeeListBox.SelectedItem);

            }

            if (employeeListBox.Items.Count > 0)
            {
                employeeListBox.SelectedIndex = 0;
            }

        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            if(customerListBox.SelectedItem == null)
            {
                MessageBox.Show("Select a customer to edit");
                return;
            }

            Customer cust = (Customer)customerListBox.SelectedItem;
            addCustomerForm acf = new addCustomerForm(cust.FirstName, cust.LastName, cust.Email, cust.CreationDate, cust.Active);

            if (acf.ShowDialog() == DialogResult.OK)
            {
                cust.FirstName = acf.FirstName;
                cust.LastName = acf.LastName;
                cust.Email = acf.Email;
                cust.CreationDate = acf.CreationDate;
                cust.Active = acf.Active;

                customerListBox.Items.Remove(cust);
                customerListBox.Items.Add(cust);
                customerListBox.SelectedItem = cust;
            }



        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedItem == null)
            {
                MessageBox.Show("Select the customer to delete.");
                return;
            }

            if(MessageBox.Show("Are you sure?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                customerListBox.Items.Remove(customerListBox.SelectedItem);

            }

            if (customerListBox.Items.Count > 0)
            {
                customerListBox.SelectedIndex = 0;
            }
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            addSupplierForm asf = new addSupplierForm();
            if(asf.ShowDialog() == DialogResult.OK)
            {
                if (asf.Valid)
                {
                    Supplier s = new Supplier();
                    s.SupplierName = asf.SupplierName;
                    s.ContactFirstName = asf.ContactFirstName;
                    s.ContactLastname = asf.ContactLastName;
                    s.Email = asf.Email;

                    supplierListBox.Items.Add(s);
                    supplierListBox.Sorted = true;
                }
            }
        }

        private void editSupplierButton_Click(object sender, EventArgs e)
        {
            if (supplierListBox.SelectedItem == null)
            {
                MessageBox.Show("Select the supplier to edit.");
                return;
            }

            Supplier sup = (Supplier)supplierListBox.SelectedItem;
            addSupplierForm asf = new addSupplierForm(sup.SupplierName, sup.ContactFirstName, sup.ContactLastname, sup.Email);

            if(asf.ShowDialog() == DialogResult.OK)
            {
                sup.SupplierName = asf.SupplierName;
                sup.ContactFirstName = asf.ContactFirstName;
                sup.ContactLastname = asf.ContactLastName;

                supplierListBox.Items.Remove(sup);
                supplierListBox.Items.Add(sup);
                supplierListBox.SelectedItem = sup;
            }

        }

        private void deleteButtonSupplier_Click(object sender, EventArgs e)
        {
            if (supplierListBox.SelectedItem == null)
            {
                MessageBox.Show("Select the supplier to delete.");
            }

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                supplierListBox.Items.Remove(supplierListBox.SelectedItem);
            }

            if (supplierListBox.Items.Count > 0)
            {
                supplierListBox.SelectedIndex = 0;
            }
        }
    }
}
