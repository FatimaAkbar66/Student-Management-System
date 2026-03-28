using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy  |  hh:mm:ss tt");
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            new StudentForm().Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            // AttendanceForm will be added next
            MessageBox.Show("Attendance Form coming soon!");
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            // MarksForm will be added next
            MessageBox.Show("Marks Form coming soon!");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                new LoginForm().Show();
            }
        }
    }
}