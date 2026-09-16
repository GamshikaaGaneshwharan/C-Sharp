using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.DAL;

namespace WinFormsApp2
{
    public partial class frmShowStudent : Form
    {
        string fname, lname, gender, address, tel, house_id, nic, gradeName;
        public frmShowStudent(string fname, string lname, string gender, string address, string tel, string house_id, string nic, string gradeName)
        {
            InitializeComponent();
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.address = address;
            this.tel = tel;
            this.house_id = house_id;
            this.nic = nic;
            this.gradeName = gradeName;
        }

        private void frmShowStudent_Load(object sender, EventArgs e)
        {
            // The form already receives the student data via constructor parameters
            // populate the designer controls with those values.
            txt_Fn.Text = this.fname;
            txt_Ln.Text = this.lname;
            // set gender radio buttons
            if (!string.IsNullOrEmpty(this.gender) && this.gender.ToLower().StartsWith("m"))
            {
                radioButton1.Checked = true;
            }
            else if (!string.IsNullOrEmpty(this.gender) && this.gender.ToLower().StartsWith("f"))
            {
                radioButton2.Checked = true;
            }
            // address -> textBox1
            textBox1.Text = this.address;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {

        }
    }
}
