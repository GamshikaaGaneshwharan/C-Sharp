using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{

    public partial class frmAddStudent : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public frmAddStudent()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(connstring))
            {
                MessageBox.Show("Database connection string is not configured. Please check your app.config.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }





        string studentId;



        // Parameterless constructor required by Designer and other callers
        public frmAddStudent()
        {
            InitializeComponent();
        }

        // Backward-compatible constructor used by callers that pass full student details
        public frmAddStudent(string id, string firstName, string lastName, string gender, string address, string dateOfBirth, string nic, string birthCert, string tele, string medium, string admissionNumber)
        {
            InitializeComponent();
            this.studentId = id;

            // Populate known controls with provided values if they exist
            txt_Fn.Text = firstName;
            txt_Ln.Text = lastName;
            txtNIC.Text = nic;
            txtTel.Text = tele;
            cmbMedium.Text = medium;
            txtAdmission.Text = admissionNumber;

            rdoM.Checked = gender == "M" || gender == "Male";
            rdoF.Checked = gender == "F" || gender == "Female";

            if (DateTime.TryParse(dateOfBirth, out DateTime dob))
            {
                dtpDOB.Value = dob;
            }
        }


        //private void Form2_Load(object sender, EventArgs e)
        //{
        //    //txt_Fn.Text = studentId;

        //    string connstring = "server=localhost;database=school;user id=root; port=3306; password=root";
        //    MySqlConnection con = new MySqlConnection(connstring);

        //    try
        //    {
        //        con.Open();
        //        MySqlCommand cmd = new MySqlCommand($"select * from students where id = {this.studentId}", con);


        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        DataRow dr = dt.Rows[0];

        //        txt_Fn.Text = dr["first_name"].ToString();
        //        txt_Ln.Text = dr["last_name"].ToString();
        //        txtNIC.Text = dr["nic"].ToString();
        //        txtTel.Text = dr["tel"].ToString();
        //        cmbHouse.Text = dr["house_id"].ToString();
        //        cmbMedium.Text = dr["medium"].ToString();
        //        dateTimePicker1.Text = dr["admission_date"].ToString();
        //        txtAdmission.Text = dr["admission_number"].ToString();
        //        txtFamily.Text = dr["family_name"].ToString();


        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();

        //    }
        //}

        private void ShowInformation_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                cmbMedium.Items.Clear();
                cmbMedium.Items.Add("Tamil");
                cmbMedium.Items.Add("English");
                cmbMedium.Items.Add("Sinhala");

                //--------------------------Load grades into ComboBox-------------------------------
                string gradeQuery = "SELECT id, grade_name FROM grades";
                MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
                DataTable gradeTable = new DataTable();
                gradeAdapter.Fill(gradeTable);

                cmbGradeName.DataSource = gradeTable;
                cmbGradeName.DisplayMember = "grade_name";
                cmbGradeName.ValueMember = "id";

                //-------------------------------Load Houses into ComboBox----------------------------
                string houseQuery = "SELECT id, house_name FROM houses";

                MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
                DataTable houseTable = new DataTable();
                houseAdapter.Fill(houseTable);

                cmbHouse.DataSource = houseTable;
                cmbHouse.DisplayMember = "house_name";
                cmbHouse.ValueMember = "id";

                //-------------------------------Load Families into ComboBox----------------------------

                string familyQuery = "SELECT id FROM families";

                MySqlDataAdapter familyAdapter =
                new MySqlDataAdapter(familyQuery, conn);

                DataTable familyTable = new DataTable();
                familyAdapter.Fill(familyTable);

                cmbFamily.DataSource = familyTable;
                cmbFamily.DisplayMember = "id";
                cmbFamily.ValueMember = "id";



                //-------------------------------Load Student Data into Form Controls--------------------------------
                MySqlCommand cmd = new MySqlCommand($"select * from students where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", this.studentId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow dr = dt.Rows[0];

                //-------------------------------Load Student Data into TextBoxes--------------------------------
                txt_Fn.Text = dr["first_name"].ToString();
                txt_Ln.Text = dr["last_name"].ToString();
                txtNIC.Text = dr["nic_number"].ToString();
                txtTel.Text = dr["tele_number"].ToString();
                txtAdmission.Text = dr["admission_number"].ToString();

                //-------------------------------Load Gender---------------------------------
                string gender = dr["gender"].ToString();

                rdoM.Checked = gender == "M";
                rdoF.Checked = gender == "F";

                //-------------------------------Load Grade into ComboBoxes--------------------------------
                if (dr["grade_id"] != DBNull.Value)
                {
                    cmbGradeName.SelectedValue = dr["grade_id"];
                }
                else
                {
                    cmbGradeName.SelectedIndex = -1;
                    cmbGradeName.Text = "N/A";
                }

                //-------------------------------Load Date of Birth into DateTimePicker--------------------------------
                if (dr["date_of_birth"] != DBNull.Value)

                {
                    dtpDOB.Value =
                    Convert.ToDateTime(dr["date_of_birth"]);
                }

                else
                {
                    dtpDOB.Value = DateTime.Now;
                }



                //--------------------------------Load House into ComboBoxes--------------------------------
                if (dr["house_id"] != DBNull.Value)
                {
                    int houseId = Convert.ToInt32(dr["house_id"]);

                    cmbHouse.SelectedValue = houseId;
                }
                else
                {
                    cmbHouse.SelectedIndex = -1;
                    cmbHouse.Text = "N/A";
                }

                //-------------------------------Load Medium into ComboBoxes--------------------------------
                if (dr["medium"] != DBNull.Value)
                {
                    cmbMedium.Text =
                    dr["medium"].ToString();
                }
                else
                {
                    cmbMedium.Text = "N/A";
                }

                //---------------------Family ID-------------------------------------

                if (dr["family_id"] != DBNull.Value)
                {
                    cmbFamily.SelectedValue = dr["family_id"].ToString();
                }
                else
                {
                    cmbFamily.SelectedIndex = -1;
                    cmbFamily.Text = "N/A";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                conn.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            // Open empty edit form for creating a new student
            frmEditStudent f = new frmEditStudent();
            if (f.ShowDialog() == DialogResult.OK)
            {
                // a student was created in the edit form, propagate success to caller
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_btn_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=school;Uid=root;Password=root;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string updateQuery = @"UPDATE students SET first_name=@first, last_name=@last, nic_number=@nic, tele_number=@tel, admission_number=@admission, medium=@medium, grade_id=@gradeId, house_id=@houseId, family_id=@familyId, gender=@gender, date_of_birth=@dob WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@first", txt_Fn.Text);
                        cmd.Parameters.AddWithValue("@last", txt_Ln.Text);
                        cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                        cmd.Parameters.AddWithValue("@admission", txtAdmission.Text);
                        cmd.Parameters.AddWithValue("@medium", cmbMedium.Text);

                        if (cmbGradeName.SelectedValue != null && int.TryParse(cmbGradeName.SelectedValue.ToString(), out int gid))
                            cmd.Parameters.AddWithValue("@gradeId", gid);
                        else
                            cmd.Parameters.AddWithValue("@gradeId", DBNull.Value);

                        if (cmbHouse.SelectedValue != null && int.TryParse(cmbHouse.SelectedValue.ToString(), out int hid))
                            cmd.Parameters.AddWithValue("@houseId", hid);
                        else
                            cmd.Parameters.AddWithValue("@houseId", DBNull.Value);

                        if (cmbFamily.SelectedValue != null && int.TryParse(cmbFamily.SelectedValue.ToString(), out int fid))
                            cmd.Parameters.AddWithValue("@familyId", fid);
                        else
                            cmd.Parameters.AddWithValue("@familyId", DBNull.Value);

                        string gender = rdoM.Checked ? "M" : (rdoF.Checked ? "F" : null);
                        if (gender != null)
                            cmd.Parameters.AddWithValue("@gender", gender);
                        else
                            cmd.Parameters.AddWithValue("@gender", DBNull.Value);

                        if (dtpDOB.Value != DateTime.MinValue)
                            cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                        else
                            cmd.Parameters.AddWithValue("@dob", DBNull.Value);

                        cmd.Parameters.AddWithValue("@id", this.studentId);

                        int affectedRows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{affectedRows} rows updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while updating the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbMedium_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

    