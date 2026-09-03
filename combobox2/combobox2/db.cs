using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace combobox2
{
    public partial class db : Form
    {
        public db()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school_db;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Succeed");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from students", connection);

                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvStudents.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
