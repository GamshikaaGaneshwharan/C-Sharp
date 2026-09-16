using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp2.DAL;

namespace WinFormsApp2
{

    public partial class Form2 : Form
    {
        private string admissionNumber;
        private string fname;
        private string lname;
        private string gender;
        private string dob;
        private string nic;
        
        private string telephone;
        private string house;
        private string grade;
        private string medium;
       
       
        private string family;




        string studentId;

        public Form2(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        public Form2(string studentId, string firstName, string lastName, string gender, string dateOfBirth, string nic, string birthCertificate, string telephone, string medium, string admissionDate, string address, string familyId, string houseId, string gradeId)
        {
            InitializeComponent();
            this.studentId = studentId;

            // Populate controls using provided values
            this.txt_Fn.Text = firstName;
            this.txt_Ln.Text = lastName;
            this.dtpDOB.Text = dateOfBirth;
            this.txtNIC.Text = nic;
            this.txtTel.Text = telephone;
            this.cmbMedium.Text = medium;
            this.txtAdmission.Text = admissionDate;
            this.cmbFamily.Text = familyId;
            this.cmbHouse.Text = houseId;
            this.cmbGradeName.Text = gradeId;
            // Set gender radio buttons
            rdoM.Checked = gender == "M" || gender == "Male";
            rdoF.Checked = gender == "F" || gender == "Female";
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
     
                Students_DAL studentDal = new Students_DAL();
                DataTable dt = studentDal.GetById(studentId);

                DataRow dr = dt.Rows[0];

                //-------------------------------Load Student Data into TextBoxes--------------------------------
                txt_Fn.Text = dr["first_name"].ToString();
                txt_Ln.Text = dr["last_name"].ToString();

            ////--------------------------Load grades into ComboBox-------------------------------
            Grades_DAL gradesDal = new Grades_DAL();
            DataTable gradeTable = gradesDal.GetAll();

            cmbGradeName.DataSource = gradeTable;
            cmbGradeName.DisplayMember = "grade_name";
            cmbGradeName.ValueMember = "id";

            ////-------------------------------Load Houses into ComboBox----------------------------
            //string houseQuery = "SELECT id, house_name FROM houses";

            //MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
            //DataTable houseTable = new DataTable();
            //houseAdapter.Fill(houseTable);

            cmbHouse.DataSource = dt;
            cmbHouse.DisplayMember = "house_name";
            cmbHouse.ValueMember = "id";

            ////-------------------------------Load Families into ComboBox----------------------------

            //string familyQuery = "SELECT id FROM families";

            //MySqlDataAdapter familyAdapter =
            //new MySqlDataAdapter(familyQuery, conn);

            //DataTable dt = new DataTable();
            //familyAdapter.Fill(dt);

            cmbFamily.DataSource = dt;
            cmbFamily.DisplayMember = "id";
            cmbFamily.ValueMember = "id";





            txtNIC.Text = dr["nic_number"].ToString();
            txtTel.Text = dr["tele_number"].ToString();
            txtAdmission.Text = dr["admission_number"].ToString();

            ////-------------------------------Load Gender---------------------------------
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }

}
