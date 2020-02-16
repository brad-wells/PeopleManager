namespace asgB
{
    partial class AssignmentB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentB));
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.suppliersGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButtonSupplier = new System.Windows.Forms.Button();
            this.editSupplierButton = new System.Windows.Forms.Button();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.supplierListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.employeeGroupBox.SuspendLayout();
            this.customerGroupBox.SuspendLayout();
            this.suppliersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeListBox
            // 
            this.employeeListBox.BackColor = System.Drawing.Color.Navy;
            this.employeeListBox.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeListBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 19;
            this.employeeListBox.Location = new System.Drawing.Point(7, 21);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(601, 118);
            this.employeeListBox.TabIndex = 0;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.addEmployeeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmployeeButton.BackgroundImage")));
            this.addEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.Navy;
            this.addEmployeeButton.Location = new System.Drawing.Point(623, 21);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(78, 34);
            this.addEmployeeButton.TabIndex = 1;
            this.addEmployeeButton.Text = "Add";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.editEmployeeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editEmployeeButton.BackgroundImage")));
            this.editEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEmployeeButton.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeButton.ForeColor = System.Drawing.Color.Navy;
            this.editEmployeeButton.Location = new System.Drawing.Point(623, 61);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(78, 34);
            this.editEmployeeButton.TabIndex = 2;
            this.editEmployeeButton.Text = "Edit";
            this.editEmployeeButton.UseVisualStyleBackColor = false;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteEmployeeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteEmployeeButton.BackgroundImage")));
            this.deleteEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmployeeButton.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployeeButton.ForeColor = System.Drawing.Color.Navy;
            this.deleteEmployeeButton.Location = new System.Drawing.Point(623, 103);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(78, 34);
            this.deleteEmployeeButton.TabIndex = 3;
            this.deleteEmployeeButton.Text = "Delete";
            this.deleteEmployeeButton.UseVisualStyleBackColor = false;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.employeeGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeeGroupBox.Controls.Add(this.deleteEmployeeButton);
            this.employeeGroupBox.Controls.Add(this.editEmployeeButton);
            this.employeeGroupBox.Controls.Add(this.addEmployeeButton);
            this.employeeGroupBox.Controls.Add(this.employeeListBox);
            this.employeeGroupBox.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.employeeGroupBox.Location = new System.Drawing.Point(12, 82);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(733, 159);
            this.employeeGroupBox.TabIndex = 4;
            this.employeeGroupBox.TabStop = false;
            this.employeeGroupBox.Text = "Employees";
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.customerGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerGroupBox.Controls.Add(this.deleteCustomerButton);
            this.customerGroupBox.Controls.Add(this.editCustomerButton);
            this.customerGroupBox.Controls.Add(this.addCustomerButton);
            this.customerGroupBox.Controls.Add(this.customerListBox);
            this.customerGroupBox.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.customerGroupBox.Location = new System.Drawing.Point(12, 247);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(733, 159);
            this.customerGroupBox.TabIndex = 5;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customers";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteCustomerButton.BackgroundImage")));
            this.deleteCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerButton.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerButton.ForeColor = System.Drawing.Color.Navy;
            this.deleteCustomerButton.Location = new System.Drawing.Point(623, 101);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(78, 34);
            this.deleteCustomerButton.TabIndex = 3;
            this.deleteCustomerButton.Text = "Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = false;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.BackColor = System.Drawing.Color.Transparent;
            this.editCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editCustomerButton.BackgroundImage")));
            this.editCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustomerButton.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCustomerButton.ForeColor = System.Drawing.Color.Navy;
            this.editCustomerButton.Location = new System.Drawing.Point(623, 61);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(78, 34);
            this.editCustomerButton.TabIndex = 2;
            this.editCustomerButton.Text = "Edit";
            this.editCustomerButton.UseVisualStyleBackColor = false;
            this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.Transparent;
            this.addCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCustomerButton.BackgroundImage")));
            this.addCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.ForeColor = System.Drawing.Color.Navy;
            this.addCustomerButton.Location = new System.Drawing.Point(623, 21);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(78, 34);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.BackColor = System.Drawing.Color.Navy;
            this.customerListBox.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 19;
            this.customerListBox.Location = new System.Drawing.Point(6, 21);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(601, 118);
            this.customerListBox.TabIndex = 0;
            // 
            // suppliersGroupBox
            // 
            this.suppliersGroupBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.suppliersGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.suppliersGroupBox.Controls.Add(this.deleteButtonSupplier);
            this.suppliersGroupBox.Controls.Add(this.editSupplierButton);
            this.suppliersGroupBox.Controls.Add(this.addSupplierButton);
            this.suppliersGroupBox.Controls.Add(this.supplierListBox);
            this.suppliersGroupBox.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.suppliersGroupBox.Location = new System.Drawing.Point(12, 412);
            this.suppliersGroupBox.Name = "suppliersGroupBox";
            this.suppliersGroupBox.Size = new System.Drawing.Size(733, 159);
            this.suppliersGroupBox.TabIndex = 6;
            this.suppliersGroupBox.TabStop = false;
            this.suppliersGroupBox.Text = "Suppliers";
            // 
            // deleteButtonSupplier
            // 
            this.deleteButtonSupplier.BackColor = System.Drawing.Color.Transparent;
            this.deleteButtonSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButtonSupplier.BackgroundImage")));
            this.deleteButtonSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButtonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButtonSupplier.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButtonSupplier.ForeColor = System.Drawing.Color.Navy;
            this.deleteButtonSupplier.Location = new System.Drawing.Point(623, 103);
            this.deleteButtonSupplier.Name = "deleteButtonSupplier";
            this.deleteButtonSupplier.Size = new System.Drawing.Size(78, 34);
            this.deleteButtonSupplier.TabIndex = 3;
            this.deleteButtonSupplier.Text = "Delete";
            this.deleteButtonSupplier.UseVisualStyleBackColor = false;
            this.deleteButtonSupplier.Click += new System.EventHandler(this.deleteButtonSupplier_Click);
            // 
            // editSupplierButton
            // 
            this.editSupplierButton.BackColor = System.Drawing.Color.Transparent;
            this.editSupplierButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editSupplierButton.BackgroundImage")));
            this.editSupplierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSupplierButton.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSupplierButton.ForeColor = System.Drawing.Color.Navy;
            this.editSupplierButton.Location = new System.Drawing.Point(623, 63);
            this.editSupplierButton.Name = "editSupplierButton";
            this.editSupplierButton.Size = new System.Drawing.Size(78, 34);
            this.editSupplierButton.TabIndex = 2;
            this.editSupplierButton.Text = "Edit";
            this.editSupplierButton.UseVisualStyleBackColor = false;
            this.editSupplierButton.Click += new System.EventHandler(this.editSupplierButton_Click);
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.BackColor = System.Drawing.Color.Transparent;
            this.addSupplierButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addSupplierButton.BackgroundImage")));
            this.addSupplierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplierButton.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplierButton.ForeColor = System.Drawing.Color.Navy;
            this.addSupplierButton.Location = new System.Drawing.Point(623, 24);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(78, 34);
            this.addSupplierButton.TabIndex = 1;
            this.addSupplierButton.Text = "Add";
            this.addSupplierButton.UseVisualStyleBackColor = false;
            this.addSupplierButton.Click += new System.EventHandler(this.addSupplierButton_Click);
            // 
            // supplierListBox
            // 
            this.supplierListBox.BackColor = System.Drawing.Color.Navy;
            this.supplierListBox.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierListBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.supplierListBox.FormattingEnabled = true;
            this.supplierListBox.ItemHeight = 19;
            this.supplierListBox.Location = new System.Drawing.Point(6, 21);
            this.supplierListBox.Name = "supplierListBox";
            this.supplierListBox.Size = new System.Drawing.Size(601, 118);
            this.supplierListBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.titleLabel.Font = new System.Drawing.Font("Eras Medium ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Navy;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(733, 58);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "PEOPLE MANAGER";
            // 
            // AssignmentB
            // 
            this.AcceptButton = this.addEmployeeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(758, 581);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.suppliersGroupBox);
            this.Controls.Add(this.customerGroupBox);
            this.Controls.Add(this.employeeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AssignmentB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment B";
            this.employeeGroupBox.ResumeLayout(false);
            this.customerGroupBox.ResumeLayout(false);
            this.suppliersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.GroupBox employeeGroupBox;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button editCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.GroupBox suppliersGroupBox;
        private System.Windows.Forms.Button deleteButtonSupplier;
        private System.Windows.Forms.Button editSupplierButton;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.ListBox supplierListBox;
        private System.Windows.Forms.Label titleLabel;
    }
}

