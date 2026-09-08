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

        private void FrmAddGrade_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root;port=3306;password=root";

            MySqlConnection conn = new MySqlConnection(connection);

            try
            {
                conn.Open();

                // Grade Group and Grade Order are textboxes now; users can type values directly.


                // Colour
                // Colour: replaced with colour panel UI; no longer populate a ComboBox
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
                cmd.Parameters.AddWithValue("@grade_group", txt_gradeGroup.Text);
                cmd.Parameters.AddWithValue("@grade_order", txt_gradeOrder.Text);
                cmd.Parameters.AddWithValue("@colour", ColorTranslator.ToHtml(pnl_gradeColour.BackColor));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Grade saved successfully!");

                txt_gradeName.Clear();
                txt_gradeGroup.Text = string.Empty;
                txt_gradeOrder.Text = string.Empty;
                // reset colour panel to default
                pnl_gradeColour.BackColor = SystemColors.Control;
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
