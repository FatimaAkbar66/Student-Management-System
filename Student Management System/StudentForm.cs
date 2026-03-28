using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class StudentForm : Form
    {
        int selectedID = 0;

        public StudentForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        // ── LOAD ALL STUDENTS ──
        private void LoadStudents(string search = "")
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = "SELECT StudentID, FullName, Age, Gender, ClassName, Phone FROM Students";

                    if (search != "")
                        query += " WHERE FullName LIKE @s OR ClassName LIKE @s OR Phone LIKE @s";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    if (search != "")
                        da.SelectCommand.Parameters.AddWithValue("@s", "%" + search + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStudents.DataSource = dt;

                    // Rename columns nicely
                    dgvStudents.Columns["StudentID"].HeaderText = "ID";
                    dgvStudents.Columns["FullName"].HeaderText = "Full Name";
                    dgvStudents.Columns["Age"].HeaderText = "Age";
                    dgvStudents.Columns["Gender"].HeaderText = "Gender";
                    dgvStudents.Columns["ClassName"].HeaderText = "Class";
                    dgvStudents.Columns["Phone"].HeaderText = "Phone";

                    lblStatus.Text = $"✅ Total Students: {dt.Rows.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── ADD STUDENT ──
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"INSERT INTO Students 
                                    (FullName, Age, Gender, ClassName, Phone) 
                                    VALUES (@n, @a, @g, @c, @p)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", txtAge.Text.Trim());
                    cmd.Parameters.AddWithValue("@g", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@c", cmbClass.Text);
                    cmd.Parameters.AddWithValue("@p", txtPhone.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Student added successfully!");
                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── UPDATE STUDENT ──
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("⚠️ Please select a student from the list first!",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateFields()) return;

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"UPDATE Students SET 
                                    FullName=@n, Age=@a, Gender=@g, 
                                    ClassName=@c, Phone=@p 
                                    WHERE StudentID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", txtAge.Text.Trim());
                    cmd.Parameters.AddWithValue("@g", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@c", cmbClass.Text);
                    cmd.Parameters.AddWithValue("@p", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedID);
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Student updated successfully!");
                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── DELETE STUDENT ──
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("⚠️ Please select a student to delete!",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete {txtName.Text}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = DBConnection.GetConnection())
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM Students WHERE StudentID=@id", con);
                        cmd.Parameters.AddWithValue("@id", selectedID);
                        cmd.ExecuteNonQuery();
                    }
                    ShowSuccess("Student deleted successfully!");
                    LoadStudents();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── ROW CLICK — Fill form fields ──
        private void dgvStudents_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
            selectedID = Convert.ToInt32(row.Cells["StudentID"].Value);
            txtName.Text = row.Cells["FullName"].Value.ToString();
            txtAge.Text = row.Cells["Age"].Value.ToString();
            cmbGender.Text = row.Cells["Gender"].Value.ToString();
            cmbClass.Text = row.Cells["ClassName"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            lblStatus.Text = $"📌 Selected: {txtName.Text}";
        }

        // ── SEARCH ──
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents(txtSearch.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                LoadStudents();
        }

        // ── CLEAR ──
        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtPhone.Text = "";
            cmbGender.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            selectedID = 0;
            lblStatus.Text = "";
        }

        // ── VALIDATION ──
        private bool ValidateFields()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("⚠️ Please enter student name!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (txtAge.Text.Trim() == "" || !int.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("⚠️ Please enter a valid age!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Please select gender!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Please select class!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ShowSuccess(string msg)
        {
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(76, 201, 160);
            lblStatus.Text = "✅ " + msg;
        }
    }
}