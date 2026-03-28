namespace StudentManagementSystem
{
    partial class DashboardForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Icon = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblCard1Desc = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Icon = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblCard2Desc = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Icon = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lblCard3Desc = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.tmrDate = new System.Windows.Forms.Timer();

            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.SuspendLayout();

            // ── SIDEBAR PANEL ──
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(28, 37, 65);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 230;
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Controls.Add(this.lblAppName);
            this.pnlSidebar.Controls.Add(this.lblSubtitle);
            this.pnlSidebar.Controls.Add(this.btnStudents);
            this.pnlSidebar.Controls.Add(this.btnAttendance);
            this.pnlSidebar.Controls.Add(this.btnMarks);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.lblVersion);

            // picLogo
            this.picLogo.Location = new System.Drawing.Point(85, 25);
            this.picLogo.Size = new System.Drawing.Size(60, 60);
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.picLogo.Name = "picLogo";

            // lblAppName
            this.lblAppName.Text = "SMS Portal";
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(30, 95);
            this.lblAppName.Size = new System.Drawing.Size(170, 30);
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle
            this.lblSubtitle.Text = "Management System";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(150, 170, 210);
            this.lblSubtitle.Location = new System.Drawing.Point(30, 125);
            this.lblSubtitle.Size = new System.Drawing.Size(170, 20);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── SIDEBAR BUTTONS ──
            StyleSidebarButton(this.btnStudents, "    👤   Students", 185);
            StyleSidebarButton(this.btnAttendance, "    📋   Attendance", 245);
            StyleSidebarButton(this.btnMarks, "    📊   Marks", 305);

            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);

            // btnLogout
            this.btnLogout.Text = "    🚪   Logout";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(40, 50, 80);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Location = new System.Drawing.Point(0, 490);
            this.btnLogout.Size = new System.Drawing.Size(230, 50);
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // lblVersion
            this.lblVersion.Text = "v1.0.0";
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(100, 120, 160);
            this.lblVersion.Location = new System.Drawing.Point(80, 548);
            this.lblVersion.Size = new System.Drawing.Size(70, 20);

            // ── MAIN PANEL ──
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.pnlCard1);
            this.pnlMain.Controls.Add(this.pnlCard2);
            this.pnlMain.Controls.Add(this.pnlCard3);
            this.pnlMain.Controls.Add(this.lblFooter);

            // lblWelcome
            this.lblWelcome.Text = "Welcome Back, Admin! 👋";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(28, 37, 65);
            this.lblWelcome.Location = new System.Drawing.Point(30, 35);
            this.lblWelcome.Size = new System.Drawing.Size(500, 40);

            // lblDate
            this.lblDate.Text = System.DateTime.Now.ToString("dddd, dd MMMM yyyy");
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(120, 130, 160);
            this.lblDate.Location = new System.Drawing.Point(32, 75);
            this.lblDate.Size = new System.Drawing.Size(350, 25);

            // ── CARD 1 — Students ──
            StyleCard(this.pnlCard1, 30, 130,
                System.Drawing.Color.FromArgb(67, 97, 238));
            this.pnlCard1.Controls.Add(this.lblCard1Icon);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblCard1Desc);
            this.lblCard1Icon.Text = "👤";
            this.lblCard1Icon.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblCard1Icon.ForeColor = System.Drawing.Color.White;
            this.lblCard1Icon.Location = new System.Drawing.Point(20, 20);
            this.lblCard1Icon.Size = new System.Drawing.Size(60, 50);
            this.lblCard1Title.Text = "Students";
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.White;
            this.lblCard1Title.Location = new System.Drawing.Point(20, 80);
            this.lblCard1Title.Size = new System.Drawing.Size(180, 28);
            this.lblCard1Desc.Text = "Add · Edit · Delete · View";
            this.lblCard1Desc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard1Desc.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblCard1Desc.Location = new System.Drawing.Point(20, 112);
            this.lblCard1Desc.Size = new System.Drawing.Size(180, 20);
            this.pnlCard1.Click += new System.EventHandler(this.btnStudents_Click);

            // ── CARD 2 — Attendance ──
            StyleCard(this.pnlCard2, 250, 130,
                System.Drawing.Color.FromArgb(76, 201, 160));
            this.pnlCard2.Controls.Add(this.lblCard2Icon);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblCard2Desc);
            this.lblCard2Icon.Text = "📋";
            this.lblCard2Icon.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblCard2Icon.ForeColor = System.Drawing.Color.White;
            this.lblCard2Icon.Location = new System.Drawing.Point(20, 20);
            this.lblCard2Icon.Size = new System.Drawing.Size(60, 50);
            this.lblCard2Title.Text = "Attendance";
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.White;
            this.lblCard2Title.Location = new System.Drawing.Point(20, 80);
            this.lblCard2Title.Size = new System.Drawing.Size(180, 28);
            this.lblCard2Desc.Text = "Mark · View · Report";
            this.lblCard2Desc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard2Desc.ForeColor = System.Drawing.Color.FromArgb(200, 240, 225);
            this.lblCard2Desc.Location = new System.Drawing.Point(20, 112);
            this.lblCard2Desc.Size = new System.Drawing.Size(180, 20);
            this.pnlCard2.Click += new System.EventHandler(this.btnAttendance_Click);

            // ── CARD 3 — Marks ──
            StyleCard(this.pnlCard3, 470, 130,
                System.Drawing.Color.FromArgb(247, 127, 0));
            this.pnlCard3.Controls.Add(this.lblCard3Icon);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblCard3Desc);
            this.lblCard3Icon.Text = "📊";
            this.lblCard3Icon.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblCard3Icon.ForeColor = System.Drawing.Color.White;
            this.lblCard3Icon.Location = new System.Drawing.Point(20, 20);
            this.lblCard3Icon.Size = new System.Drawing.Size(60, 50);
            this.lblCard3Title.Text = "Marks";
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.White;
            this.lblCard3Title.Location = new System.Drawing.Point(20, 80);
            this.lblCard3Title.Size = new System.Drawing.Size(180, 28);
            this.lblCard3Desc.Text = "Enter · Grade · Results";
            this.lblCard3Desc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard3Desc.ForeColor = System.Drawing.Color.FromArgb(255, 220, 180);
            this.lblCard3Desc.Location = new System.Drawing.Point(20, 112);
            this.lblCard3Desc.Size = new System.Drawing.Size(180, 20);
            this.pnlCard3.Click += new System.EventHandler(this.btnMarks_Click);

            // lblFooter
            this.lblFooter.Text = "© 2025 Student Management System  |  Built with C# WinForms";
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(160, 170, 200);
            this.lblFooter.Location = new System.Drawing.Point(30, 530);
            this.lblFooter.Size = new System.Drawing.Size(500, 20);

            // Timer for live date
            this.tmrDate.Interval = 1000;
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            this.tmrDate.Start();

            // ── FORM ──
            this.Text = "Dashboard — Student Management System";
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── HELPER METHODS ──
        private void StyleSidebarButton(System.Windows.Forms.Button btn, string text, int y)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            btn.ForeColor = System.Drawing.Color.FromArgb(200, 215, 255);
            btn.BackColor = System.Drawing.Color.FromArgb(28, 37, 65);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = new System.Drawing.Point(0, y);
            btn.Size = new System.Drawing.Size(230, 50);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void StyleCard(System.Windows.Forms.Panel pnl, int x, int y,
            System.Drawing.Color color)
        {
            pnl.BackColor = color;
            pnl.Location = new System.Drawing.Point(x, y);
            pnl.Size = new System.Drawing.Size(200, 150);
            pnl.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        // Controls
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Icon;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Desc;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Icon;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Desc;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Icon;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Desc;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Timer tmrDate;
    }
}