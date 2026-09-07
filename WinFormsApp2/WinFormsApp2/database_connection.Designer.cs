namespace WinFormsApp2
{
    partial class database_connection
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
            btn_All_students = new Button();
            btn_Connect = new Button();
            btn_Show = new Button();
            dgvStudents = new DataGridView();
            label1 = new Label();
            txt_Fn = new TextBox();
            label2 = new Label();
            txt_Ln = new TextBox();
            lblG = new Label();
            cmbGr = new ComboBox();
            btnGr = new Button();
            button1 = new Button();
            button2 = new Button();
            buton3 = new Button();
            label3 = new Label();
            txt_nic = new TextBox();
            label4 = new Label();
            txt_tel = new TextBox();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_create = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btn_All_students
            // 
            btn_All_students.Location = new Point(106, 30);
            btn_All_students.Name = "btn_All_students";
            btn_All_students.Size = new Size(112, 36);
            btn_All_students.TabIndex = 0;
            btn_All_students.Text = "All Students";
            btn_All_students.UseVisualStyleBackColor = true;
            btn_All_students.Click += btn_All_students_Click;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(12, 30);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(88, 36);
            btn_Connect.TabIndex = 1;
            btn_Connect.Text = " Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(460, 30);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(141, 36);
            btn_Show.TabIndex = 2;
            btn_Show.Text = "Show";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 105);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(589, 320);
            dgvStudents.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(641, 117);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // txt_Fn
            // 
            txt_Fn.Location = new Point(755, 109);
            txt_Fn.Name = "txt_Fn";
            txt_Fn.Size = new Size(151, 23);
            txt_Fn.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(641, 171);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // txt_Ln
            // 
            txt_Ln.Location = new Point(755, 163);
            txt_Ln.Name = "txt_Ln";
            txt_Ln.Size = new Size(151, 23);
            txt_Ln.TabIndex = 5;
            // 
            // lblG
            // 
            lblG.AutoSize = true;
            lblG.Location = new Point(641, 230);
            lblG.Name = "lblG";
            lblG.Size = new Size(73, 15);
            lblG.TabIndex = 4;
            lblG.Text = "Grade Name";
            // 
            // cmbGr
            // 
            cmbGr.FormattingEnabled = true;
            cmbGr.Location = new Point(755, 227);
            cmbGr.Name = "cmbGr";
            cmbGr.Size = new Size(151, 23);
            cmbGr.TabIndex = 6;
            // 
            // btnGr
            // 
            btnGr.Location = new Point(224, 30);
            btnGr.Name = "btnGr";
            btnGr.Size = new Size(112, 36);
            btnGr.TabIndex = 0;
            btnGr.Text = "All Grades";
            btnGr.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(661, 256);
            button1.Name = "button1";
            button1.Size = new Size(88, 36);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(808, 256);
            button2.Name = "button2";
            button2.Size = new Size(88, 36);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buton3
            // 
            buton3.Location = new Point(342, 30);
            buton3.Name = "buton3";
            buton3.Size = new Size(112, 36);
            buton3.TabIndex = 0;
            buton3.Text = "DB Show";
            buton3.UseVisualStyleBackColor = true;
            buton3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(641, 319);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "NIC Number";
            // 
            // txt_nic
            // 
            txt_nic.Location = new Point(755, 311);
            txt_nic.Name = "txt_nic";
            txt_nic.Size = new Size(151, 23);
            txt_nic.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 363);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 4;
            label4.Text = "Tel Number";
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(755, 355);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(151, 23);
            txt_tel.TabIndex = 5;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(607, 30);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(123, 36);
            btn_edit.TabIndex = 7;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(736, 30);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(102, 36);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += button3_Click_1;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(844, 30);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(102, 36);
            btn_create.TabIndex = 8;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // database_connection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 446);
            Controls.Add(btn_create);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(cmbGr);
            Controls.Add(lblG);
            Controls.Add(txt_tel);
            Controls.Add(label4);
            Controls.Add(txt_nic);
            Controls.Add(label3);
            Controls.Add(txt_Ln);
            Controls.Add(label2);
            Controls.Add(txt_Fn);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Controls.Add(btn_Show);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_Connect);
            Controls.Add(buton3);
            Controls.Add(btnGr);
            Controls.Add(btn_All_students);
            Name = "database_connection";
            Text = "database_connection";
            Load += database_connection_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_All_students;
        private Button btn_Connect;
        private Button btn_Show;
        private DataGridView dgvStudents;
        private Label label1;
        private TextBox txt_Fn;
        private Label label2;
        private TextBox txt_Ln;
        private Label lblG;
        private ComboBox cmbGr;
        private Button btnGr;
        private Button button1;
        private Button button2;
        private Button buton3;
        private Label label3;
        private TextBox txt_nic;
        private Label label4;
        private TextBox txt_tel;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_create;
    }
}