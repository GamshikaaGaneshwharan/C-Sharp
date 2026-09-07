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
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }

        private void btn_AllGrades_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root;port=3306;password=root";

            MySqlConnection conn = new MySqlConnection(connection);

            try
            {
                conn.Open();

                string query = "SELECT * FROM grades";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvGrades.DataSource = dt;
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
            string connection = "server=localhost;database=school;user id=root;port=3306;password=root";

            MySqlConnection conn = new MySqlConnection(connection);

            try
            {
                conn.Open();

                //grade_group combo box

                string query = "SELECT DISTINCT grade_group FROM grades";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmb_gradeGroup.Items.Add(reader["grade_group"].ToString());
                }

                reader.Close();

                //grade_order combo box
                string orderQuery = "SELECT DISTINCT grade_order FROM grades";

                MySqlCommand orderCmd = new MySqlCommand(orderQuery, conn);

                MySqlDataReader orderReader = orderCmd.ExecuteReader();

                while (orderReader.Read())
                {
                    cmb_gradeOrder.Items.Add(orderReader["grade_order"].ToString());
                }

                orderReader.Close();

                // colour
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
    }
}
