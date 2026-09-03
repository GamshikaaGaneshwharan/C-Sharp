namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Item 1");
            comboBox1.Items.Add("Item 2");
            comboBox1.Items.Add("Item 3");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem?.ToString();
            MessageBox.Show("You selected: " + selectedItem);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string newItem = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                comboBox1.Items.Add(newItem);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid item.");
            }
        }


    }
