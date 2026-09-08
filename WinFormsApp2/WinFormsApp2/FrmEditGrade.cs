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
    public partial class FrmEditGrade : Form
    {
        //string connstring = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        string gradeId;
        public FrmEditGrade()
        {
            InitializeComponent();
            gradeId = "";
        }

        private void pnl_gradeColour_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pnl_gradeColour.BackColor = dlg.Color;
                }
            }
        }

        public FrmEditGrade(string id) : this()
        {
            gradeId = id;
        }

        private void FrmEditGrade_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root;port=3306;password=root";

            MySqlConnection conn = new MySqlConnection(connection);

            try
            {
                conn.Open();

                // Get selected grade details
                string query = "SELECT * FROM grades WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", gradeId);

                MySqlDataReader reader = cmd.ExecuteReader();

                string selectedGroup = "";
                string selectedOrder = "";
                string selectedColour = "";

                if (reader.Read())
                {
                    //txt_id.Text = reader["id"].ToString();
                    txt_gradeName.Text = reader["grade_name"].ToString();

                    selectedGroup = reader["grade_group"].ToString();
                    selectedOrder = reader["grade_order"].ToString();
                    selectedColour = reader["colour"].ToString();
                }

                reader.Close();

                // Grade Group and Grade Order are TextBoxes now: set values directly
                txt_gradeGroup.Text = selectedGroup;
                txt_gradeOrder.Text = selectedOrder;
                // set panel color from stored value if available
                if (!string.IsNullOrEmpty(selectedColour))
                {
                    try
                    {
                        pnl_gradeColour.BackColor = ColorTranslator.FromHtml(selectedColour);
                    }
                    catch { /* ignore parse errors and leave default */ }
                }
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root;port=3306;password=root";

            MySqlConnection conn = new MySqlConnection(connection);

            try
            {
                conn.Open();

                string query = "UPDATE grades SET grade_name = @grade_name, grade_group = @grade_group, grade_order = @grade_order, colour = @colour WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@grade_name", txt_gradeName.Text);
                cmd.Parameters.AddWithValue("@grade_group", txt_gradeGroup.Text);
                cmd.Parameters.AddWithValue("@grade_order", txt_gradeOrder.Text);
                cmd.Parameters.AddWithValue("@colour", ColorTranslator.ToHtml(pnl_gradeColour.BackColor));
              //  cmd.Parameters.AddWithValue("@id", txt_id.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Grade updated successfully!");
                }
                else
                {
                    MessageBox.Show("Grade was not updated.");
                }
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
