using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace combobox2
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = cmbSubject.Text;

            cmbSelectedSubject.Text = name;

            // int selectedIndex = cmbSubject.SelectedIndex;



            //MessageBox.Show(
            //"Selected Subject: " + selectedSubject,
            //"Subject",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information
            //);
        }

        private void cmbSubject_Click(object sender, EventArgs e)
        {
            string name = cmbSubject.Text;

            cmbSelectedSubject.Text = name;

        }
    }
}