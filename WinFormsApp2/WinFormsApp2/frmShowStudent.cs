using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            txt_Fn.Text = fname;
            txt_Ln.Text = lname;

            if (gender == "M")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            textBox1.Text = address;
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
