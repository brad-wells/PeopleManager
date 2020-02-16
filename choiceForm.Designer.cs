namespace asgB
{
    partial class choiceForm
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
            this.employeeButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.supplierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeButton
            // 
            this.employeeButton.Location = new System.Drawing.Point(13, 49);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(81, 41);
            this.employeeButton.TabIndex = 0;
            this.employeeButton.Text = "Employee";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(140, 49);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(81, 41);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            // 
            // supplierButton
            // 
            this.supplierButton.Location = new System.Drawing.Point(267, 49);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(81, 41);
            this.supplierButton.TabIndex = 2;
            this.supplierButton.Text = "Supplier";
            this.supplierButton.UseVisualStyleBackColor = true;
            // 
            // choiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 158);
            this.Controls.Add(this.supplierButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.employeeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "choiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "What do you want to add?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button supplierButton;
    }
}