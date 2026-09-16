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

    public partial class frmEditStudent : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public frmEditStudent()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(connstring))
            {
                MessageBox.Show("Database connection string is not configured. Please check your app.config.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }




        string studentId;

       

        // Backward-compatible constructor used by callers that pass full student details
        public frmEditStudent(string id, string firstName, string lastName, string gender, string address, string dateOfBirth, string nic, string birthCert, string tele, string medium, string admissionNumber)
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

                string familyQuery = "SELECT id, family_name FROM families";

                MySqlDataAdapter familyAdapter =
                new MySqlDataAdapter(familyQuery, conn);

                DataTable familyTable = new DataTable();
                familyAdapter.Fill(familyTable);

                cmbFamily.DataSource = familyTable;
                cmbFamily.DisplayMember = "family_name";
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=school;Uid=root;Password=root;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // If studentId is null or empty treat this as CREATE (INSERT)
                    if (string.IsNullOrWhiteSpace(this.studentId))
                    {
                        string insertQuery = @"INSERT INTO students (first_name, last_name, nic_number, tele_number, admission_number, medium, grade_id, house_id, family_id, gender, date_of_birth) VALUES (@first, @last, @nic, @tel, @admission, @medium, @gradeId, @houseId, @familyId, @gender, @dob)";

                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
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

                            int inserted = cmd.ExecuteNonQuery();
                            MessageBox.Show($"{inserted} row(s) inserted successfully.", "Create Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // signal success back to caller so it can refresh grid
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            return;
                        }
                    }
                    else
                    {
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

                            // indicate update success to caller
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while saving to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

    