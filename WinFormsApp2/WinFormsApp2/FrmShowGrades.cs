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
                    cmb_gradeGroup.Text = reader["grade_group"].ToString();
                    cmb_gradeOrder.Text = reader["grade_order"].ToString();
                    cmb_gradeColour.Text = reader["colour"].ToString();
                }

                reader.Close();

                // Grade Group
                string groupQuery = "SELECT DISTINCT grade_group FROM grades";

                MySqlCommand groupCmd = new MySqlCommand(groupQuery, conn);

                MySqlDataReader groupReader = groupCmd.ExecuteReader();

                while (groupReader.Read())
                {
                    cmb_gradeGroup.Items.Add(groupReader["grade_group"].ToString());
                }

                groupReader.Close();

                // Grade Order
                string orderQuery = "SELECT DISTINCT grade_order FROM grades";

                MySqlCommand orderCmd = new MySqlCommand(orderQuery, conn);

                MySqlDataReader orderReader = orderCmd.ExecuteReader();

                while (orderReader.Read())
                {
                    cmb_gradeOrder.Items.Add(orderReader["grade_order"].ToString());
                }

                orderReader.Close();

                // Colour
                string colourQuery = "SELECT DISTINCT colour FROM grades";

                MySqlCommand colourCmd = new MySqlCommand(colourQuery, conn);

                MySqlDataReader colourReader = colourCmd.ExecuteReader();

                while (colourReader.Read())
                {
                    cmb_gradeColour.Items.Add(colourReader["colour"].ToString());
                }

                colourReader.Close();

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
