namespace BillingSystem
{
    partial class AddCustomerForm
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
            lblTitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblBalance = new Label();
            txtBalance = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(130, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Customer";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(55, 70);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(84, 21);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            lblFullName.Click += lblFullName_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(211, 62);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 29);
            txtFullName.TabIndex = 2;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(55, 110);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 21);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(211, 103);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 29);
            txtAddress.TabIndex = 4;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(55, 152);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(132, 21);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact Number: ";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(211, 149);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 29);
            txtContact.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(55, 195);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(211, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 29);
            txtEmail.TabIndex = 8;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(55, 235);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(108, 21);
            lblBalance.TabIndex = 9;
            lblBalance.Text = "Initial Balance:";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(211, 232);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(125, 29);
            txtBalance.TabIndex = 10;
            txtBalance.Text = "0.0";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(55, 309);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(172, 309);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(285, 309);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 373);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Add Customer";
            Load += AddCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblBalance;
        private TextBox txtBalance;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
    }
}