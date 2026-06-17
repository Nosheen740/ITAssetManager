namespace App.WindowsApp.Forms
{
    partial class AssetDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetDetailForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAssetName = new TextBox();
            cmbCategory = new ComboBox();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtSerial = new TextBox();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            dtpPurchaseDate = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            txtNotes = new TextBox();
            chkPurchaseDate = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 0;
            label1.Text = "Asset Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 2;
            label3.Text = "Brand:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 97);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 3;
            label4.Text = "Model:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 130);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 19);
            label5.TabIndex = 4;
            label5.Text = "Serial Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(12, 163);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 19);
            label6.TabIndex = 5;
            label6.Text = "Status:";
            // 
            // txtAssetName
            // 
            txtAssetName.Location = new Point(108, 8);
            txtAssetName.Margin = new Padding(2);
            txtAssetName.Name = "txtAssetName";
            txtAssetName.Size = new Size(106, 23);
            txtAssetName.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(108, 40);
            cmbCategory.Margin = new Padding(2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(129, 23);
            cmbCategory.TabIndex = 7;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(108, 67);
            txtBrand.Margin = new Padding(2);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(141, 23);
            txtBrand.TabIndex = 8;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(108, 97);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(141, 23);
            txtModel.TabIndex = 9;
            // 
            // txtSerial
            // 
            txtSerial.Location = new Point(108, 130);
            txtSerial.Margin = new Padding(2);
            txtSerial.Name = "txtSerial";
            txtSerial.Size = new Size(141, 23);
            txtSerial.TabIndex = 10;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(108, 163);
            cmbStatus.Margin = new Padding(2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(141, 23);
            cmbStatus.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(113, 268);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(214, 268);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 30);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Format = DateTimePickerFormat.Short;
            dtpPurchaseDate.Location = new Point(142, 197);
            dtpPurchaseDate.Margin = new Padding(2);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(141, 23);
            dtpPurchaseDate.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 197);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 19);
            label7.TabIndex = 15;
            label7.Text = "Purchase Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 230);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 19);
            label8.TabIndex = 16;
            label8.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(108, 230);
            txtNotes.Margin = new Padding(2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(106, 29);
            txtNotes.TabIndex = 17;
            // 
            // chkPurchaseDate
            // 
            chkPurchaseDate.AutoSize = true;
            chkPurchaseDate.Location = new Point(113, 201);
            chkPurchaseDate.Margin = new Padding(2);
            chkPurchaseDate.Name = "chkPurchaseDate";
            chkPurchaseDate.Size = new Size(15, 14);
            chkPurchaseDate.TabIndex = 18;
            chkPurchaseDate.UseVisualStyleBackColor = true;
            // 
            // AssetDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 309);
            Controls.Add(chkPurchaseDate);
            Controls.Add(txtNotes);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(txtSerial);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(cmbCategory);
            Controls.Add(txtAssetName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "AssetDetailForm";
            Text = "Asset Details";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAssetName;
        private ComboBox cmbCategory;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtSerial;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpPurchaseDate;
        private Label label7;
        private Label label8;
        private TextBox txtNotes;
        private CheckBox chkPurchaseDate;
    }
}