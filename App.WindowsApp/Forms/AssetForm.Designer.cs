namespace App.WindowsApp.Forms
{
    partial class AssetForm
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
            pnlTop = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            dgvAssets = new DataGridView();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssets).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnDelete);
            pnlTop.Controls.Add(btnEdit);
            pnlTop.Controls.Add(btnAdd);
            pnlTop.Controls.Add(txtSearch);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(2, 2, 2, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(615, 53);
            pnlTop.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(351, 5);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.WhiteSmoke;
            btnEdit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.edit__1_;
            btnEdit.Location = new Point(259, 5);
            btnEdit.Margin = new Padding(2, 2, 2, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 31);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.Location = new Point(162, 5);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = " Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(8, 7);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search assets...";
            txtSearch.Size = new Size(141, 23);
            txtSearch.TabIndex = 0;
            // 
            // dgvAssets
            // 
            dgvAssets.BackgroundColor = Color.White;
            dgvAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssets.Dock = DockStyle.Fill;
            dgvAssets.Location = new Point(0, 53);
            dgvAssets.Margin = new Padding(2, 2, 2, 2);
            dgvAssets.Name = "dgvAssets";
            dgvAssets.RowHeadersWidth = 62;
            dgvAssets.Size = new Size(615, 273);
            dgvAssets.TabIndex = 1;
            // 
            // AssetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 326);
            Controls.Add(dgvAssets);
            Controls.Add(pnlTop);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AssetForm";
            Text = "Assets Management";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssets).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlTop;
        private TextBox txtSearch;
        private Button btnAdd;
        private DataGridView dgvAssets;
        private Button btnDelete;
        private Button btnEdit;
    }
}