namespace App.WindowsApp.Forms
{
    partial class CategoryForm
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
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvCategories = new DataGridView();
            pnlTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(120, 5);
            txtCategoryName.Margin = new Padding(2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(120, 25);
            txtCategoryName.TabIndex = 0;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(8, 5);
            lblCategoryName.Margin = new Padding(2, 0, 2, 0);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(108, 19);
            lblCategoryName.TabIndex = 1;
            lblCategoryName.Text = "Category Name:";
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(273, 7);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(377, 7);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 39);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCategories.BorderStyle = BorderStyle.None;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.Location = new Point(0, 0);
            dgvCategories.Margin = new Padding(2);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 62;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(560, 270);
            dgvCategories.TabIndex = 4;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblCategoryName);
            pnlTop.Controls.Add(txtCategoryName);
            pnlTop.Controls.Add(btnDelete);
            pnlTop.Controls.Add(btnAdd);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(560, 53);
            pnlTop.TabIndex = 5;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(pnlTop);
            Controls.Add(dgvCategories);
            Margin = new Padding(2);
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvCategories;
        private Panel pnlTop;
    }
}