namespace WinFormsApp2
{
    partial class FrmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fname = new Label();
            lname = new Label();
            dob = new Label();
            Address = new Label();
            telnumber = new Label();
            NIC = new Label();
            gender = new Label();
            btn1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtTelNum = new TextBox();
            txtNic = new TextBox();
            txtFirstNameDet = new TextBox();
            txtLastNameDet = new TextBox();
            txtAddressDet = new TextBox();
            txtTelNumDet = new TextBox();
            textBox12 = new TextBox();
            DateDet = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Location = new Point(35, 40);
            fname.Name = "fname";
            fname.Size = new Size(64, 15);
            fname.TabIndex = 0;
            fname.Text = "First Name";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Location = new Point(35, 81);
            lname.Name = "lname";
            lname.Size = new Size(63, 15);
            lname.TabIndex = 0;
            lname.Text = "Last Name";
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Location = new Point(35, 128);
            dob.Name = "dob";
            dob.Size = new Size(73, 15);
            dob.TabIndex = 0;
            dob.Text = "Date of Birth";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(35, 172);
            Address.Name = "Address";
            Address.Size = new Size(49, 15);
            Address.TabIndex = 0;
            Address.Text = "Address";
            // 
            // telnumber
            // 
            telnumber.AutoSize = true;
            telnumber.Location = new Point(35, 213);
            telnumber.Name = "telnumber";
            telnumber.Size = new Size(109, 15);
            telnumber.TabIndex = 0;
            telnumber.Text = "Telephone Number";
            // 
            // NIC
            // 
            NIC.AutoSize = true;
            NIC.Location = new Point(35, 257);
            NIC.Name = "NIC";
            NIC.Size = new Size(27, 15);
            NIC.TabIndex = 0;
            NIC.Text = "NIC";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(35, 298);
            gender.Name = "gender";
            gender.Size = new Size(45, 15);
            gender.TabIndex = 0;
            gender.Text = "Gender";
            // 
            // btn1
            // 
            btn1.Location = new Point(365, 363);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "Fill Details";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(153, 300);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(283, 300);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton1";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(209, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(209, 81);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(209, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtTelNum
            // 
            txtTelNum.Location = new Point(209, 210);
            txtTelNum.Name = "txtTelNum";
            txtTelNum.Size = new Size(150, 23);
            txtTelNum.TabIndex = 3;
         
            // 
            // txtNic
            // 
            txtNic.Location = new Point(209, 249);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(150, 23);
            txtNic.TabIndex = 3;
            // 
            // txtFirstNameDet
            // 
            txtFirstNameDet.Location = new Point(464, 43);
            txtFirstNameDet.Name = "txtFirstNameDet";
            txtFirstNameDet.Size = new Size(150, 23);
            txtFirstNameDet.TabIndex = 3;
            // 
            // txtLastNameDet
            // 
            txtLastNameDet.Location = new Point(464, 81);
            txtLastNameDet.Name = "txtLastNameDet";
            txtLastNameDet.Size = new Size(150, 23);
            txtLastNameDet.TabIndex = 3;
            // 
            // txtAddressDet
            // 
            txtAddressDet.Location = new Point(464, 169);
            txtAddressDet.Name = "txtAddressDet";
            txtAddressDet.Size = new Size(150, 23);
            txtAddressDet.TabIndex = 3;
            // 
            // txtTelNumDet
            // 
            txtTelNumDet.Location = new Point(464, 210);
            txtTelNumDet.Name = "txtTelNumDet";
            txtTelNumDet.Size = new Size(150, 23);
            txtTelNumDet.TabIndex = 3;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(464, 249);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(150, 23);
            textBox12.TabIndex = 3;
            // 
            // DateDet
            // 
            DateDet.Location = new Point(209, 128);
            DateDet.Name = "DateDet";
            DateDet.Size = new Size(150, 23);
            DateDet.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(464, 128);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(150, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 600);
            Controls.Add(dateTimePicker2);
            Controls.Add(DateDet);
            Controls.Add(textBox12);
            Controls.Add(txtTelNumDet);
            Controls.Add(txtNic);
            Controls.Add(txtAddressDet);
            Controls.Add(txtTelNum);
            Controls.Add(txtAddress);
            Controls.Add(txtLastNameDet);
            Controls.Add(txtFirstNameDet);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btn1);
            Controls.Add(telnumber);
            Controls.Add(Address);
            Controls.Add(gender);
            Controls.Add(dob);
            Controls.Add(NIC);
            Controls.Add(lname);
            Controls.Add(fname);
            Name = "FrmStudent";
            Text = " c4r";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fname;
        private Label lname;
        private Label dob;
        private Label Address;
        private Label telnumber;
        private Label NIC;
        private Label gender;
        private Button btn1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtTelNum;
        private TextBox txtNic;
        private TextBox txtFirstNameDet;
        private TextBox txtLastNameDet;
        private TextBox txtAddressDet;
        private TextBox txtTelNumDet;
        private TextBox textBox12;
        private DateTimePicker DateDet;
        private DateTimePicker dateTimePicker2;
    }
}