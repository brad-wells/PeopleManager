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
    public partial class choiceForm : Form
    {
        public choiceForm()
        {
            InitializeComponent();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            addEmployeeForm ef = new addEmployeeForm();
            ef.ShowDialog();
            
        }
    }
}
