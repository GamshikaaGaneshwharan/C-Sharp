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
    public partial class FrmEditGrade : Form
    {
        string gradeId;
        public FrmEditGrade()
        {
            InitializeComponent();
            gradeId = "";
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
                    txt_id.Text = reader["id"].ToString();
                    txt_gradeName.Text = reader["grade_name"].ToString();

                    selectedGroup = reader["grade_group"].ToString();
                    selectedOrder = reader["grade_order"].ToString();
                    selectedColour = reader["colour"].ToString();
                }

                reader.Close();


                // Grade Group
                string groupQuery = "SELECT DISTINCT grade_group FROM grades";

                MySqlCommand groupCmd = new MySqlCommand(groupQuery, conn);
                MySqlDataReader groupReader = groupCmd.ExecuteReader();

                cmb_gradeGroup.Items.Clear();

                while (groupReader.Read())
                {
                    cmb_gradeGroup.Items.Add(
                        groupReader["grade_group"].ToString()
                    );
                }

                groupReader.Close();


                // Grade Order
                string orderQuery = "SELECT DISTINCT grade_order FROM grades";

                MySqlCommand orderCmd = new MySqlCommand(orderQuery, conn);
                MySqlDataReader orderReader = orderCmd.ExecuteReader();

                cmb_gradeOrder.Items.Clear();

                while (orderReader.Read())
                {
                    cmb_gradeOrder.Items.Add(
                        orderReader["grade_order"].ToString()
                    );
                }

                orderReader.Close();


                // Colour
                string colourQuery = "SELECT DISTINCT colour FROM grades";

                MySqlCommand colourCmd = new MySqlCommand(colourQuery, conn);
                MySqlDataReader colourReader = colourCmd.ExecuteReader();

                cmb_gradeColour.Items.Clear();

                while (colourReader.Read())
                {
                    cmb_gradeColour.Items.Add(
                        colourReader["colour"].ToString()
                    );
                }

                colourReader.Close();


                // Select current values
                cmb_gradeGroup.Text = selectedGroup;
                cmb_gradeOrder.Text = selectedOrder;
                cmb_gradeColour.Text = selectedColour;
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
                cmd.Parameters.AddWithValue("@grade_group", cmb_gradeGroup.Text);
                cmd.Parameters.AddWithValue("@grade_order", cmb_gradeOrder.Text);
                cmd.Parameters.AddWithValue("@colour", cmb_gradeColour.Text);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);

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
