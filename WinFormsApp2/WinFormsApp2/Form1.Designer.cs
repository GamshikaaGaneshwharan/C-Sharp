namespace WinFormsApp2
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
            btn1 = new Button();
            txtFName = new TextBox();
            txtLName = new TextBox();
            FirstName = new Label();
            LastName = new Label();
            label1 = new Label();
            txtFullName = new Label();
            txtFL = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(421, 238);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 32);
            btn1.TabIndex = 0;
            btn1.Text = "Submit";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(203, 64);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(308, 23);
            txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(203, 113);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(308, 23);
            txtLName.TabIndex = 1;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            FirstName.Location = new Point(26, 55);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(119, 30);
            FirstName.TabIndex = 2;
            FirstName.Text = "First Name";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LastName.Location = new Point(26, 104);
            LastName.Name = "LastName";
            LastName.Size = new Size(116, 30);
            LastName.TabIndex = 2;
            LastName.Text = "Last Name";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(597, 51);
            label1.TabIndex = 3;
            label1.Text = "Full Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.AutoSize = true;
            txtFullName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(26, 161);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(113, 30);
            txtFullName.TabIndex = 4;
            txtFullName.Text = "Full Name";
            // 
            // txtFL
            // 
            txtFL.Location = new Point(203, 161);
            txtFL.Name = "txtFL";
            txtFL.Size = new Size(308, 23);
            txtFL.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 382);
            Controls.Add(txtFL);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private TextBox txtFName;
        private TextBox txtLName;
        private Label FirstName;
        private Label LastName;
        private Label label1;
        private Label txtFullName;
        private TextBox txtFL;
    }
}
