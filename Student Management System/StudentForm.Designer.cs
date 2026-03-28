namespace StudentManagementSystem
{
    partial class StudentForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // ── HEADER PANEL ──
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);

            this.lblTitle.Text = "👤  Student Management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Size = new System.Drawing.Size(400, 32);

            this.lblSubtitle.Text = "Add, Edit, Delete and Search Students";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 215, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 48);
            this.lblSubtitle.Size = new System.Drawing.Size(350, 20);

            // ── FORM PANEL (Left) ──
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Location = new System.Drawing.Point(15, 95);
            this.pnlForm.Size = new System.Drawing.Size(310, 520);
            this.pnlForm.Controls.Add(this.lblName);
            this.pnlForm.Controls.Add(this.txtName);
            this.pnlForm.Controls.Add(this.lblAge);
            this.pnlForm.Controls.Add(this.txtAge);
            this.pnlForm.Controls.Add(this.lblGender);
            this.pnlForm.Controls.Add(this.cmbGender);
            this.pnlForm.Controls.Add(this.lblClass);
            this.pnlForm.Controls.Add(this.cmbClass);
            this.pnlForm.Controls.Add(this.lblPhone);
            this.pnlForm.Controls.Add(this.txtPhone);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);

            // Form Fields
            AddLabel(this.lblName, "Full Name", 20);
            AddLabel(this.lblAge, "Age", 100);
            AddLabel(this.lblGender, "Gender", 180);
            AddLabel(this.lblClass, "Class", 260);
            AddLabel(this.lblPhone, "Phone", 340);

            AddTextBox(this.txtName, 45);
            AddTextBox(this.txtAge, 125);
            AddTextBox(this.txtPhone, 365);

            // cmbGender
            this.cmbGender.Location = new System.Drawing.Point(20, 205);
            this.cmbGender.Size = new System.Drawing.Size(265, 28);
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // cmbClass
            this.cmbClass.Location = new System.Drawing.Point(20, 285);
            this.cmbClass.Size = new System.Drawing.Size(265, 28);
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClass.Items.AddRange(new object[] {
                "Class 6", "Class 7", "Class 8",
                "Class 9", "Class 10", "Class 11", "Class 12" });
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // ── BUTTONS ──
            StyleButton(this.btnAdd, "➕  Add Student", 420,
                System.Drawing.Color.FromArgb(67, 97, 238));
            StyleButton(this.btnUpdate, "✏️  Update", 465,
                System.Drawing.Color.FromArgb(76, 201, 160));
            StyleButton(this.btnDelete, "🗑️  Delete", 465,
                System.Drawing.Color.FromArgb(220, 53, 69));
            StyleButton(this.btnClear, "🔄  Clear", 510,
                System.Drawing.Color.FromArgb(108, 117, 125));

            this.btnAdd.Location = new System.Drawing.Point(20, 420);
            this.btnAdd.Size = new System.Drawing.Size(265, 40);
            this.btnUpdate.Location = new System.Drawing.Point(20, 465);
            this.btnUpdate.Size = new System.Drawing.Size(128, 38);
            this.btnDelete.Location = new System.Drawing.Point(157, 465);
            this.btnDelete.Size = new System.Drawing.Size(128, 38);
            this.btnClear.Location = new System.Drawing.Point(20, 508);
            this.btnClear.Size = new System.Drawing.Size(265, 35);

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ── GRID PANEL (Right) ──
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(340, 95);
            this.pnlGrid.Size = new System.Drawing.Size(630, 520);
            this.pnlGrid.Controls.Add(this.lblSearch);
            this.pnlGrid.Controls.Add(this.txtSearch);
            this.pnlGrid.Controls.Add(this.btnSearch);
            this.pnlGrid.Controls.Add(this.dgvStudents);

            // Search bar
            this.lblSearch.Text = "🔍";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearch.Location = new System.Drawing.Point(15, 18);
            this.lblSearch.Size = new System.Drawing.Size(30, 28);

            this.txtSearch.Location = new System.Drawing.Point(45, 18);
            this.txtSearch.Size = new System.Drawing.Size(430, 28);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.btnSearch.Text = "Search";
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(485, 15);
            this.btnSearch.Size = new System.Drawing.Size(120, 34);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // DataGridView
            this.dgvStudents.Location = new System.Drawing.Point(15, 65);
            this.dgvStudents.Size = new System.Drawing.Size(600, 440);
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvStudents.ColumnHeadersHeight = 35;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            // Status label
            this.lblStatus.Text = "";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.lblStatus.Location = new System.Drawing.Point(15, 625);
            this.lblStatus.Size = new System.Drawing.Size(950, 22);

            // ── FORM ──
            this.Text = "Student Management";
            this.ClientSize = new System.Drawing.Size(990, 660);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.lblStatus);

            this.pnlHeader.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
        }

        // ── HELPERS ──
        private void AddLabel(System.Windows.Forms.Label lbl, string text, int y)
        {
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(80, 90, 120);
            lbl.Location = new System.Drawing.Point(20, y);
            lbl.Size = new System.Drawing.Size(265, 20);
        }

        private void AddTextBox(System.Windows.Forms.TextBox txt, int y)
        {
            txt.Location = new System.Drawing.Point(20, y);
            txt.Size = new System.Drawing.Size(265, 28);
            txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void StyleButton(System.Windows.Forms.Button btn,
            string text, int y, System.Drawing.Color color)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.BackColor = color;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        // Controls
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblStatus;
    }
}