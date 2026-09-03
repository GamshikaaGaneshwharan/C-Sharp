namespace combobox2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbSelectedSubject = new ComboBox();
            comboBox2 = new ComboBox();
            cmbSubject = new Button();
            SuspendLayout();
            // 
            // cmbSelectedSubject
            // 
            cmbSelectedSubject.FormattingEnabled = true;
            cmbSelectedSubject.Items.AddRange(new object[] { "Tamil", "English", "Science", "Maths", "History" });
            cmbSelectedSubject.Location = new Point(122, 116);
            cmbSelectedSubject.Name = "cmbSelectedSubject";
            cmbSelectedSubject.Size = new Size(121, 23);
            cmbSelectedSubject.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(484, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // cmbSubject
            // 
            cmbSubject.Location = new Point(168, 177);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(75, 23);
            cmbSubject.TabIndex = 2;
            cmbSubject.Text = "Save";
            cmbSubject.UseVisualStyleBackColor = true;
            cmbSubject.Click += cmbSubject_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSubject);
            Controls.Add(comboBox2);
            Controls.Add(cmbSelectedSubject);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSelectedSubject;
        private ComboBox comboBox2;
        private Button cmbSubject;
    }
}
