namespace App.WindowsApp.Forms
{
    partial class EmployeeDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetailForm));
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            txtDepartment = new TextBox();
            label3 = new Label();
            txtContact = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(15, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 0;
            label1.Text = "Full Name *";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(114, 12);
            txtFullName.Margin = new Padding(2, 2, 2, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(106, 23);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(15, 49);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 2;
            label2.Text = "Department";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(114, 49);
            txtDepartment.Margin = new Padding(2, 2, 2, 2);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(106, 23);
            txtDepartment.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 89);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 4;
            label3.Text = "Contact No.";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(114, 89);
            txtContact.Margin = new Padding(2, 2, 2, 2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(106, 23);
            txtContact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(15, 127);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 125);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(106, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(167, 188);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(260, 188);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EmployeeDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 241);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtContact);
            Controls.Add(label3);
            Controls.Add(txtDepartment);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "EmployeeDetailForm";
            Text = "Employee Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtDepartment;
        private Label label3;
        private TextBox txtContact;
        private Label label4;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
    }
}