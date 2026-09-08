using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp2
{
    public partial class FrmShowGrades : Form
    {
        string gradeId;
        public FrmShowGrades(string gradeId)
        {
            InitializeComponent();
            this.gradeId = gradeId;
        }

        private void FrmShowGrades_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root;port=3306;password=root";

            MySqlConnection conn = new MySqlConnection(connection);

            try
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

                // Grade Group and Grade Order are TextBoxes now; no population required

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
