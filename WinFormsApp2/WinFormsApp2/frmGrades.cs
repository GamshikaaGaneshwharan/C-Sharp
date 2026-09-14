using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmGrades : Form
    {

        string connstring = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public frmGrades()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(connstring))
            {
                MessageBox.Show("Database connection string is not configured. Please check your app.config.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btn_AllGrades_Click(object sender, EventArgs e)
        {
            if (!Config.TryGetConnectionString(out var connection, this)) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "SELECT * FROM grades";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvGrades.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_showGrades_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvGrades.CurrentRow == null)
                {
                    MessageBox.Show("Please select a grade.");
                    return;
                }

                string gradeId = dgvGrades.CurrentRow.Cells["id"].Value.ToString();
                string colour = dgvGrades.CurrentRow.Cells["colour"].Value.ToString();
                string gradeGroup = dgvGrades.CurrentRow.Cells["grade_group"].Value.ToString();
                string gradeOrder = dgvGrades.CurrentRow.Cells["grade_order"].Value.ToString();

                txt_gradeGroup.Text = gradeGroup;
                txt_gradeOrder.Text = gradeOrder;

                panel1.BackColor = ColorTranslator.FromHtml(colour);

                FrmShowGrades showForm = new FrmShowGrades(gradeId);

                showForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmGrades_Load(object sender, EventArgs e)
        {

            if (!Config.TryGetConnectionString(out var connection, this)) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "SELECT * FROM grades LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_gradeGroup.Text = reader["grade_group"].ToString();
                            txt_gradeOrder.Text = reader["grade_order"].ToString();

                            string colour = reader["colour"].ToString();

                            panel1.BackColor = ColorTranslator.FromHtml(colour);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            FrmAddGrade addForm = new FrmAddGrade();

            addForm.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade.");
                return;
            }

            string gradeId = dgvGrades.SelectedRows[0].Cells["id"].Value.ToString();

            FrmEditGrade editGrade = new FrmEditGrade(gradeId);
            editGrade.ShowDialog();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade.");
                return;
            }

            string gradeId = dgvGrades.SelectedRows[0].Cells["id"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this grade?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {  
                return;
            }

            if (!Config.TryGetConnectionString(out var connection, this)) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "DELETE FROM grades WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", gradeId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Grade deleted successfully.");

                            // Refresh DataGridView
                            btn_AllGrades_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Grade was not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    panel1.BackColor = colorDialog.Color;
                }
            }


        }
    }
}
