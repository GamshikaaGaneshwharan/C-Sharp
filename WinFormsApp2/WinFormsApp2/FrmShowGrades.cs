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
    public partial class FrmShowGrades : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public FrmShowGrades()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(connstring))
            {
                MessageBox.Show("Database connection string is not configured. Please check your app.config.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private readonly string gradeId;

        public FrmShowGrades(string gradeId)
        {
            InitializeComponent();
            this.gradeId = gradeId;
        }

        private void FrmShowGrades_Load(object sender, EventArgs e)
        {
            if (!Config.TryGetConnectionString(out var connection, this)) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "SELECT * FROM grades WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", gradeId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_id.Text = reader["id"].ToString();
                        txt_gradeName.Text = reader["grade_name"].ToString();
                        txt_gradeGroup.Text = reader["grade_group"].ToString();
                        txt_gradeOrder.Text = reader["grade_order"].ToString();
                        var c = reader["colour"].ToString();
                        if (!string.IsNullOrEmpty(c))
                        {
                            try
                            {
                                pnl_gradeColour.BackColor = ColorTranslator.FromHtml(c);
                            }
                            catch { }
                        }
                    }

                    reader.Close();
                }

                // Grade Group and Grade Order are TextBoxes now; no population required
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
