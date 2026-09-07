namespace WinFormsApp2
{
    partial class FrmShowGrades
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
            label_ID = new Label();
            label_gradeName = new Label();
            label_gradeGroup = new Label();
            label_gradeOrder = new Label();
            label_colour = new Label();
            txt_id = new TextBox();
            txt_gradeName = new TextBox();
            cmb_gradeGroup = new ComboBox();
            cmb_gradeOrder = new ComboBox();
            cmb_gradeColour = new ComboBox();
            SuspendLayout();
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(67, 45);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(18, 15);
            label_ID.TabIndex = 0;
            label_ID.Text = "ID";
            // 
            // label_gradeName
            // 
            label_gradeName.AutoSize = true;
            label_gradeName.Location = new Point(67, 106);
            label_gradeName.Name = "label_gradeName";
            label_gradeName.Size = new Size(73, 15);
            label_gradeName.TabIndex = 1;
            label_gradeName.Text = "Grade Name";
            // 
            // label_gradeGroup
            // 
            label_gradeGroup.AutoSize = true;
            label_gradeGroup.Location = new Point(67, 162);
            label_gradeGroup.Name = "label_gradeGroup";
            label_gradeGroup.Size = new Size(74, 15);
            label_gradeGroup.TabIndex = 2;
            label_gradeGroup.Text = "Grade Group";
            // 
            // label_gradeOrder
            // 
            label_gradeOrder.AutoSize = true;
            label_gradeOrder.Location = new Point(67, 221);
            label_gradeOrder.Name = "label_gradeOrder";
            label_gradeOrder.Size = new Size(71, 15);
            label_gradeOrder.TabIndex = 3;
            label_gradeOrder.Text = "Grade Order";
            // 
            // label_colour
            // 
            label_colour.AutoSize = true;
            label_colour.Location = new Point(67, 279);
            label_colour.Name = "label_colour";
            label_colour.Size = new Size(43, 15);
            label_colour.TabIndex = 4;
            label_colour.Text = "Colour";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(163, 45);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(121, 23);
            txt_id.TabIndex = 5;
            // 
            // txt_gradeName
            // 
            txt_gradeName.Location = new Point(163, 98);
            txt_gradeName.Name = "txt_gradeName";
            txt_gradeName.Size = new Size(121, 23);
            txt_gradeName.TabIndex = 5;
            // 
            // cmb_gradeGroup
            // 
            cmb_gradeGroup.FormattingEnabled = true;
            cmb_gradeGroup.Location = new Point(163, 159);
            cmb_gradeGroup.Name = "cmb_gradeGroup";
            cmb_gradeGroup.Size = new Size(121, 23);
            cmb_gradeGroup.TabIndex = 6;
            // 
            // cmb_gradeOrder
            // 
            cmb_gradeOrder.FormattingEnabled = true;
            cmb_gradeOrder.Location = new Point(163, 213);
            cmb_gradeOrder.Name = "cmb_gradeOrder";
            cmb_gradeOrder.Size = new Size(121, 23);
            cmb_gradeOrder.TabIndex = 6;
            // 
            // cmb_gradeColour
            // 
            cmb_gradeColour.FormattingEnabled = true;
            cmb_gradeColour.Location = new Point(163, 271);
            cmb_gradeColour.Name = "cmb_gradeColour";
            cmb_gradeColour.Size = new Size(121, 23);
            cmb_gradeColour.TabIndex = 6;
            // 
            // FrmShowGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
            Controls.Add(cmb_gradeColour);
            Controls.Add(cmb_gradeOrder);
            Controls.Add(cmb_gradeGroup);
            Controls.Add(txt_gradeName);
            Controls.Add(txt_id);
            Controls.Add(label_colour);
            Controls.Add(label_gradeOrder);
            Controls.Add(label_gradeGroup);
            Controls.Add(label_gradeName);
            Controls.Add(label_ID);
            Name = "FrmShowGrades";
            Text = "FrmShowGrades";
            Load += FrmShowGrades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ID;
        private Label label_gradeName;
        private Label label_gradeGroup;
        private Label label_gradeOrder;
        private Label label_colour;
        private TextBox txt_id;
        private TextBox txt_gradeName;
        private ComboBox cmb_gradeGroup;
        private ComboBox cmb_gradeOrder;
        private ComboBox cmb_gradeColour;
    }
}