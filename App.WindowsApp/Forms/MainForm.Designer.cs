namespace App.WindowsApp
{
    partial class MainForm
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
            pnlSidebar = new Panel();
            btnCategories = new Button();
            btnAssignments = new Button();
            btnEmployees = new Button();
            btnAsset = new Button();
            btnDashboard = new Button();
            lblAppTitle = new Label();
            pnlHeader = new Panel();
            lblPageTitle = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(btnCategories);
            pnlSidebar.Controls.Add(btnAssignments);
            pnlSidebar.Controls.Add(btnEmployees);
            pnlSidebar.Controls.Add(btnAsset);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblAppTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(210, 386);
            pnlSidebar.TabIndex = 0;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(224, 224, 224);
            btnCategories.Dock = DockStyle.Top;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCategories.ForeColor = Color.Black;
            btnCategories.Image = Properties.Resources.icons8_categories_24;
            btnCategories.Location = new Point(0, 215);
            btnCategories.Margin = new Padding(2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(210, 49);
            btnCategories.TabIndex = 5;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleRight;
            btnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnAssignments
            // 
            btnAssignments.BackColor = Color.FromArgb(224, 224, 224);
            btnAssignments.Dock = DockStyle.Top;
            btnAssignments.FlatStyle = FlatStyle.Flat;
            btnAssignments.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAssignments.ForeColor = Color.Black;
            btnAssignments.Image = Properties.Resources.assign__1_;
            btnAssignments.Location = new Point(0, 166);
            btnAssignments.Margin = new Padding(2);
            btnAssignments.Name = "btnAssignments";
            btnAssignments.Size = new Size(210, 49);
            btnAssignments.TabIndex = 3;
            btnAssignments.Text = "Assignments";
            btnAssignments.TextAlign = ContentAlignment.MiddleRight;
            btnAssignments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAssignments.UseVisualStyleBackColor = false;
            btnAssignments.Click += btnAssignments_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(224, 224, 224);
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEmployees.ForeColor = Color.Black;
            btnEmployees.Image = Properties.Resources.teamwork;
            btnEmployees.Location = new Point(0, 117);
            btnEmployees.Margin = new Padding(2);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(210, 49);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleRight;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnAsset
            // 
            btnAsset.BackColor = Color.FromArgb(224, 224, 224);
            btnAsset.Dock = DockStyle.Top;
            btnAsset.FlatStyle = FlatStyle.Flat;
            btnAsset.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAsset.ForeColor = Color.Black;
            btnAsset.Image = Properties.Resources.asset;
            btnAsset.Location = new Point(0, 71);
            btnAsset.Margin = new Padding(2);
            btnAsset.Name = "btnAsset";
            btnAsset.Size = new Size(210, 46);
            btnAsset.TabIndex = 1;
            btnAsset.Text = "Asset";
            btnAsset.TextAlign = ContentAlignment.MiddleRight;
            btnAsset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsset.UseVisualStyleBackColor = false;
            btnAsset.Click += btnAssets_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(224, 224, 224);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = Properties.Resources.dashboard__1_;
            btnDashboard.Location = new Point(0, 25);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(210, 46);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.BackColor = Color.White;
            lblAppTitle.Dock = DockStyle.Top;
            lblAppTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.Black;
            lblAppTitle.Location = new Point(0, 0);
            lblAppTitle.Margin = new Padding(2, 0, 2, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(80, 25);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "IT Asset";
            lblAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Black;
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = Color.FromArgb(224, 224, 224);
            pnlHeader.Location = new Point(210, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(545, 34);
            pnlHeader.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Dock = DockStyle.Fill;
            lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(0, 0);
            lblPageTitle.Margin = new Padding(2, 0, 2, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(109, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(210, 34);
            pnlContent.Margin = new Padding(2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(545, 352);
            pnlContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 386);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "IT Asset Manager";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Label lblAppTitle;
        private Button btnAssignments;
        private Button btnEmployees;
        private Button btnAsset;
        private Button btnDashboard;
        private Label lblPageTitle;
        
        private Button btnCategories;
    }
}