namespace asgB
{
    partial class addSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSupplierForm));
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.contactEmailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.contactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.contactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.contactGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelCustomerButton = new System.Windows.Forms.Button();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.contactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.BackColor = System.Drawing.Color.Navy;
            this.supplierNameTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.supplierNameTextBox.Location = new System.Drawing.Point(103, 20);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.supplierNameTextBox.TabIndex = 13;
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Location = new System.Drawing.Point(6, 22);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(101, 17);
            this.SupplierNameLabel.TabIndex = 12;
            this.SupplierNameLabel.Text = "Supplier Name:";
            // 
            // contactEmailTextBox
            // 
            this.contactEmailTextBox.BackColor = System.Drawing.Color.Navy;
            this.contactEmailTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.contactEmailTextBox.Location = new System.Drawing.Point(98, 89);
            this.contactEmailTextBox.Name = "contactEmailTextBox";
            this.contactEmailTextBox.Size = new System.Drawing.Size(268, 22);
            this.contactEmailTextBox.TabIndex = 21;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(1, 89);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(43, 17);
            this.emailLabel.TabIndex = 20;
            this.emailLabel.Text = "email:";
            // 
            // contactLastNameTextBox
            // 
            this.contactLastNameTextBox.BackColor = System.Drawing.Color.Navy;
            this.contactLastNameTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.contactLastNameTextBox.Location = new System.Drawing.Point(98, 52);
            this.contactLastNameTextBox.Name = "contactLastNameTextBox";
            this.contactLastNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.contactLastNameTextBox.TabIndex = 19;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(1, 54);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(77, 17);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // contactFirstNameTextBox
            // 
            this.contactFirstNameTextBox.BackColor = System.Drawing.Color.Navy;
            this.contactFirstNameTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.contactFirstNameTextBox.Location = new System.Drawing.Point(98, 19);
            this.contactFirstNameTextBox.Name = "contactFirstNameTextBox";
            this.contactFirstNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.contactFirstNameTextBox.TabIndex = 17;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(1, 19);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(78, 17);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name:";
            // 
            // contactGroupBox
            // 
            this.contactGroupBox.BackColor = System.Drawing.Color.Navy;
            this.contactGroupBox.Controls.Add(this.contactEmailTextBox);
            this.contactGroupBox.Controls.Add(this.emailLabel);
            this.contactGroupBox.Controls.Add(this.contactLastNameTextBox);
            this.contactGroupBox.Controls.Add(this.lastNameLabel);
            this.contactGroupBox.Controls.Add(this.contactFirstNameTextBox);
            this.contactGroupBox.Controls.Add(this.firstNameLabel);
            this.contactGroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.contactGroupBox.Location = new System.Drawing.Point(5, 67);
            this.contactGroupBox.Name = "contactGroupBox";
            this.contactGroupBox.Size = new System.Drawing.Size(372, 128);
            this.contactGroupBox.TabIndex = 22;
            this.contactGroupBox.TabStop = false;
            this.contactGroupBox.Text = "contact info";
            // 
            // cancelCustomerButton
            // 
            this.cancelCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelCustomerButton.BackgroundImage")));
            this.cancelCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCustomerButton.ForeColor = System.Drawing.Color.Navy;
            this.cancelCustomerButton.Location = new System.Drawing.Point(290, 200);
            this.cancelCustomerButton.Name = "cancelCustomerButton";
            this.cancelCustomerButton.Size = new System.Drawing.Size(81, 32);
            this.cancelCustomerButton.TabIndex = 24;
            this.cancelCustomerButton.Text = "Cancel";
            this.cancelCustomerButton.UseVisualStyleBackColor = true;
            this.cancelCustomerButton.Click += new System.EventHandler(this.cancelCustomerButton_Click);
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addSupplierButton.BackgroundImage")));
            this.addSupplierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplierButton.ForeColor = System.Drawing.Color.Navy;
            this.addSupplierButton.Location = new System.Drawing.Point(103, 200);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(81, 32);
            this.addSupplierButton.TabIndex = 23;
            this.addSupplierButton.Text = "Add";
            this.addSupplierButton.UseVisualStyleBackColor = true;
            this.addSupplierButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // addSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(384, 238);
            this.Controls.Add(this.cancelCustomerButton);
            this.Controls.Add(this.addSupplierButton);
            this.Controls.Add(this.supplierNameTextBox);
            this.Controls.Add(this.SupplierNameLabel);
            this.Controls.Add(this.contactGroupBox);
            this.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Supplier";
            this.contactGroupBox.ResumeLayout(false);
            this.contactGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.TextBox contactEmailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox contactLastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox contactFirstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox contactGroupBox;
        private System.Windows.Forms.Button cancelCustomerButton;
        private System.Windows.Forms.Button addSupplierButton;
    }
}