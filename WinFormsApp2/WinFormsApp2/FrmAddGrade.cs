using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmAddGrade : Form
    {
        public FrmAddGrade()
        {
            InitializeComponent();
        }

        private void FrmAddGrade_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root;port=3306;password=root";

            MySqlConnection conn = new MySqlConnection(connection);

            try
            {
                conn.Open();

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root;port=3306;password=root";

            MySqlConnection conn = new MySqlConnection(connection);

            try
            {
                conn.Open();

                string query = "INSERT INTO grades (grade_name, grade_group, grade_order, colour) " +
                               "VALUES (@grade_name, @grade_group, @grade_order, @colour)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@grade_name", txt_gradeName.Text);
                cmd.Parameters.AddWithValue("@grade_group", cmb_gradeGroup.Text);
                cmd.Parameters.AddWithValue("@grade_order", cmb_gradeOrder.Text);
                cmd.Parameters.AddWithValue("@colour", cmb_gradeColour.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Grade saved successfully!");

                txt_gradeName.Clear();
                cmb_gradeGroup.SelectedIndex = -1;
                cmb_gradeOrder.SelectedIndex = -1;
                cmb_gradeColour.SelectedIndex = -1;
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
