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
    public partial class database_connection : Form
    {
        public database_connection()
        {
            InitializeComponent();
        }

        private void database_connection_Load(object sender, EventArgs e)
        {

        }

        private void btn_All_students_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root; port=3306; password=root";
            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                conn.Open();
                string query = "SELECT * FROM students";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStudents.DataSource = dt;
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
        private void button1_Click(object sender, EventArgs e)  
        {
            MessageBox.Show(cmbGr.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbGr.SelectedValue = 15;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvStudents.CurrentRow.Cells["id"].Value.ToString();
                Form2 f = new Form2(id);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            // Designer expects this handler; keep simple behavior
            MessageBox.Show("Connect clicked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=school;user id=root; port=3307; password=; ";
            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                if (dgvStudents.Rows.Count == 0)
                {
                    MessageBox.Show("No data to show");
                    return;
                }
                string fname = dgvStudents.CurrentRow.Cells["first_name"].Value.ToString();
                txt_Fn.Text = fname;

                string lname = dgvStudents.CurrentRow.Cells["last_name"].Value.ToString();
                txt_Ln.Text = lname;

                string nic = dgvStudents.CurrentRow.Cells["nic_number"].Value.ToString();
                txt_nic.Text = nic;


                string tele = dgvStudents.CurrentRow.Cells["tele_number"].Value.ToString();
                txt_tel.Text = tele;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvStudents.CurrentRow.Cells["id"].Value.ToString();
                string fna = dgvStudents.CurrentRow.Cells["first_name"].Value.ToString();
                string lna = dgvStudents.CurrentRow.Cells["last_name"].Value.ToString();
                string gender = dgvStudents.CurrentRow.Cells["gender"].Value.ToString();
                string address = dgvStudents.CurrentRow.Cells["per_address"].Value.ToString();
                string date_of_birth = dgvStudents.CurrentRow.Cells["date_of_birth"].Value.ToString();
                string nic_number = dgvStudents.CurrentRow.Cells["nic_number"].Value.ToString();
                string birth_certificate_number = dgvStudents.CurrentRow.Cells["birth_certificate_number"].Value.ToString();
                string tele_number = dgvStudents.CurrentRow.Cells["tele_number"].Value.ToString();
                string medium = dgvStudents.CurrentRow.Cells["medium"].Value.ToString();
                string admission = dgvStudents.CurrentRow.Cells["admission_number"].Value.ToString();
                frmEditStudent f = new frmEditStudent(id, fna, lna, gender, address, date_of_birth, nic_number, birth_certificate_number, tele_number, medium, admission);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // refresh grid after successful update
                    btn_All_students_Click(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}