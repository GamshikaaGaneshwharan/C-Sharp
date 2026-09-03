namespace WinFormsApp2
{
    partial class frmEditStudent
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
            txt_Fn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_Ln = new TextBox();
            label3 = new Label();
            txtNIC = new TextBox();
            Tel = new Label();
            txtTel = new TextBox();
            label5 = new Label();
            cmbHouse = new ComboBox();
            label6 = new Label();
            cmbMedium = new ComboBox();
            label7 = new Label();
            dtpDOB = new DateTimePicker();
            label8 = new Label();
            rdoM = new RadioButton();
            rdoF = new RadioButton();
            label9 = new Label();
            cmbGradeName = new ComboBox();
            label10 = new Label();
            txtAdmission = new TextBox();
            label11 = new Label();
            label12 = new Label();
            cmbFamily = new ComboBox();
            btn_update = new Button();
            SuspendLayout();
            // 
            // txt_Fn
            // 
            txt_Fn.Location = new Point(174, 34);
            txt_Fn.Name = "txt_Fn";
            txt_Fn.Size = new Size(151, 23);
            txt_Fn.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 10;
            label1.Text = "first name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 78);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "last name";
            // 
            // txt_Ln
            // 
            txt_Ln.Location = new Point(174, 75);
            txt_Ln.Name = "txt_Ln";
            txt_Ln.Size = new Size(151, 23);
            txt_Ln.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 124);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 10;
            label3.Text = "NIC";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(174, 121);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(151, 23);
            txtNIC.TabIndex = 11;
            // 
            // Tel
            // 
            Tel.AutoSize = true;
            Tel.Location = new Point(70, 170);
            Tel.Name = "Tel";
            Tel.Size = new Size(69, 15);
            Tel.TabIndex = 10;
            Tel.Text = "Tel Number";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(174, 167);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(151, 23);
            txtTel.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 219);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "House ID";
            // 
            // cmbHouse
            // 
            cmbHouse.FormattingEnabled = true;
            cmbHouse.Location = new Point(174, 211);
            cmbHouse.Name = "cmbHouse";
            cmbHouse.Size = new Size(151, 23);
            cmbHouse.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 265);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 13;
            label6.Text = "Medium";
            // 
            // cmbMedium
            // 
            cmbMedium.FormattingEnabled = true;
            cmbMedium.Location = new Point(174, 265);
            cmbMedium.Name = "cmbMedium";
            cmbMedium.Size = new Size(151, 23);
            cmbMedium.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 316);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 15;
            label7.Text = "DOB";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(174, 308);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(151, 23);
            dtpDOB.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 352);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 17;
            label8.Text = "Gender";
            label8.Click += label8_Click;
            // 
            // rdoM
            // 
            rdoM.AutoSize = true;
            rdoM.Location = new Point(174, 348);
            rdoM.Name = "rdoM";
            rdoM.Size = new Size(51, 19);
            rdoM.TabIndex = 18;
            rdoM.TabStop = true;
            rdoM.Text = "Male";
            rdoM.UseVisualStyleBackColor = true;
            // 
            // rdoF
            // 
            rdoF.AutoSize = true;
            rdoF.Location = new Point(287, 348);
            rdoF.Name = "rdoF";
            rdoF.Size = new Size(63, 19);
            rdoF.TabIndex = 18;
            rdoF.TabStop = true;
            rdoF.Text = "Female";
            rdoF.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 392);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 19;
            label9.Text = "Grade Name";
            // 
            // cmbGradeName
            // 
            cmbGradeName.FormattingEnabled = true;
            cmbGradeName.Location = new Point(174, 384);
            cmbGradeName.Name = "cmbGradeName";
            cmbGradeName.Size = new Size(151, 23);
            cmbGradeName.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 443);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 21;
            label10.Text = "Admission Number";
            // 
            // txtAdmission
            // 
            txtAdmission.Location = new Point(187, 435);
            txtAdmission.Name = "txtAdmission";
            txtAdmission.Size = new Size(138, 23);
            txtAdmission.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(71, 499);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 21;
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(72, 491);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 23;
            label12.Text = "Family ID";
            // 
            // cmbFamily
            // 
            cmbFamily.FormattingEnabled = true;
            cmbFamily.Location = new Point(174, 483);
            cmbFamily.Name = "cmbFamily";
            cmbFamily.Size = new Size(151, 23);
            cmbFamily.TabIndex = 14;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(215, 533);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(110, 32);
            btn_update.TabIndex = 24;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // frmEditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 628);
            Controls.Add(btn_update);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtAdmission);
            Controls.Add(label10);
            Controls.Add(cmbGradeName);
            Controls.Add(label9);
            Controls.Add(rdoF);
            Controls.Add(rdoM);
            Controls.Add(label8);
            Controls.Add(dtpDOB);
            Controls.Add(label7);
            Controls.Add(cmbFamily);
            Controls.Add(cmbMedium);
            Controls.Add(label6);
            Controls.Add(cmbHouse);
            Controls.Add(label5);
            Controls.Add(txtTel);
            Controls.Add(Tel);
            Controls.Add(txtNIC);
            Controls.Add(label3);
            Controls.Add(txt_Ln);
            Controls.Add(label2);
            Controls.Add(txt_Fn);
            Controls.Add(label1);
            Name = "frmEditStudent";
            Text = "\"Student Information";
            Load += ShowInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Fn;
        private Label label1;
        private TextBox txt_Ln;
        private Label label2;
        private Label label3;
        private TextBox txtNIC;
        private Label Tel;
        private TextBox txtTel;
        private Label label5;
        private ComboBox cmbHouse;
        private Label label6;
        private ComboBox cmbMedium;
        private Label label7;
        private DateTimePicker dtpDOB;
        private Label label8;
        private RadioButton rdoM;
        private RadioButton rdoF;
        private Label label9;
        private ComboBox cmbGradeName;
        private Label label10;
        private TextBox txtAdmission;
        private Label label11;
        private Label label12;
        private ComboBox cmbFamily;
        private Button btn_update;
    }
}