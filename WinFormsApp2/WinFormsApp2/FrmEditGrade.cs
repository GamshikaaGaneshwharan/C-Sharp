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

                string query = "SELECT grade_group, grade_order, colour FROM grades WHERE id = @id";

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
