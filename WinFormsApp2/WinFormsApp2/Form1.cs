namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            string fname = txtFName.Text;
            string lname = txtLName.Text;
           
            if(string.IsNullOrEmpty(fname)) {
                MessageBox.Show("First Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Last Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string fullname = fname + " " + lname;

            txtFL.Text = fullname;


            //MessageBox.Show("Full Name: " + fullname, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }



    }
}
