namespace asgB
{
    partial class addCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCustomerForm));
            this.cancelCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.creationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.ActiveDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelCustomerButton
            // 
            this.cancelCustomerButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelCustomerButton.BackgroundImage")));
            this.cancelCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCustomerButton.Location = new System.Drawing.Point(280, 193);
            this.cancelCustomerButton.Name = "cancelCustomerButton";
            this.cancelCustomerButton.Size = new System.Drawing.Size(81, 32);
            this.cancelCustomerButton.TabIndex = 19;
            this.cancelCustomerButton.Text = "Cancel";
            this.cancelCustomerButton.UseVisualStyleBackColor = false;
            this.cancelCustomerButton.Click += new System.EventHandler(this.cancelCustomerButton_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.Transparent;
            this.addCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCustomerButton.BackgroundImage")));
            this.addCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Location = new System.Drawing.Point(94, 193);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(81, 32);
            this.addCustomerButton.TabIndex = 18;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.BackColor = System.Drawing.Color.Navy;
            this.customerEmailTextBox.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.customerEmailTextBox.Location = new System.Drawing.Point(94, 82);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(268, 22);
            this.customerEmailTextBox.TabIndex = 15;
            this.customerEmailTextBox.TextChanged += new System.EventHandler(this.customerEmailTextBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.emailLabel.Location = new System.Drawing.Point(9, 82);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(43, 17);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "email:";
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.BackColor = System.Drawing.Color.Navy;
            this.customerLastNameTextBox.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLastNameTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.customerLastNameTextBox.Location = new System.Drawing.Point(94, 44);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.customerLastNameTextBox.TabIndex = 13;
            this.customerLastNameTextBox.TextChanged += new System.EventHandler(this.customerLastNameTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(9, 47);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(77, 17);
            this.lastNameLabel.TabIndex = 12;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.BackColor = System.Drawing.Color.Navy;
            this.customerFirstNameTextBox.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFirstNameTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(94, 11);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.customerFirstNameTextBox.TabIndex = 11;
            this.customerFirstNameTextBox.TextChanged += new System.EventHandler(this.customerFirstNameTextBox_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(9, 11);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(78, 17);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First Name:";
            // 
            // creationDateTimePicker
            // 
            this.creationDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Navy;
            this.creationDateTimePicker.Enabled = false;
            this.creationDateTimePicker.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateTimePicker.Location = new System.Drawing.Point(127, 120);
            this.creationDateTimePicker.Name = "creationDateTimePicker";
            this.creationDateTimePicker.Size = new System.Drawing.Size(235, 22);
            this.creationDateTimePicker.TabIndex = 21;
            this.creationDateTimePicker.ValueChanged += new System.EventHandler(this.creationDateTimePicker_ValueChanged);
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.creationDateLabel.Location = new System.Drawing.Point(9, 125);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(96, 17);
            this.creationDateLabel.TabIndex = 20;
            this.creationDateLabel.Text = "Creation Date:";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.activeLabel.Location = new System.Drawing.Point(9, 164);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(50, 17);
            this.activeLabel.TabIndex = 22;
            this.activeLabel.Text = "Active:";
            // 
            // ActiveDisplayLabel
            // 
            this.ActiveDisplayLabel.AutoSize = true;
            this.ActiveDisplayLabel.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveDisplayLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ActiveDisplayLabel.Location = new System.Drawing.Point(91, 164);
            this.ActiveDisplayLabel.Name = "ActiveDisplayLabel";
            this.ActiveDisplayLabel.Size = new System.Drawing.Size(30, 17);
            this.ActiveDisplayLabel.TabIndex = 23;
            this.ActiveDisplayLabel.Text = "YES";
            // 
            // addCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(374, 238);
            this.Controls.Add(this.ActiveDisplayLabel);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.creationDateTimePicker);
            this.Controls.Add(this.creationDateLabel);
            this.Controls.Add(this.cancelCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customerEmailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.customerLastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.customerFirstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.addCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.DateTimePicker creationDateTimePicker;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label ActiveDisplayLabel;
    }
}