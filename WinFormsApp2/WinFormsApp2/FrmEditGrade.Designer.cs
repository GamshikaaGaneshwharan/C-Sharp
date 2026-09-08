namespace WinFormsApp2
{
    partial class FrmEditGrade
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
            pnl_gradeColour = new Panel();
            txt_gradeOrder = new TextBox();
            txt_gradeGroup = new TextBox();
            txt_gradeName = new TextBox();
            label_colour = new Label();
            label_gradeOrder = new Label();
            label_gradeGroup = new Label();
            label_gradeName = new Label();
            btn_update = new Button();
            SuspendLayout();
            // 
            // pnl_gradeColour
            // 
            pnl_gradeColour.BackColor = SystemColors.Control;
            pnl_gradeColour.BorderStyle = BorderStyle.FixedSingle;
            pnl_gradeColour.Cursor = Cursors.Hand;
            pnl_gradeColour.Location = new Point(143, 293);
            pnl_gradeColour.Name = "pnl_gradeColour";
            pnl_gradeColour.Size = new Size(121, 23);
            pnl_gradeColour.TabIndex = 14;
            pnl_gradeColour.Click += pnl_gradeColour_Click;
            // 
            // txt_gradeOrder
            // 
            txt_gradeOrder.Location = new Point(143, 243);
            txt_gradeOrder.Name = "txt_gradeOrder";
            txt_gradeOrder.Size = new Size(121, 23);
            txt_gradeOrder.TabIndex = 15;
            // 
            // txt_gradeGroup
            // 
            txt_gradeGroup.Location = new Point(143, 181);
            txt_gradeGroup.Name = "txt_gradeGroup";
            txt_gradeGroup.Size = new Size(121, 23);
            txt_gradeGroup.TabIndex = 16;
            // 
            // txt_gradeName
            // 
            txt_gradeName.Location = new Point(143, 120);
            txt_gradeName.Name = "txt_gradeName";
            txt_gradeName.Size = new Size(121, 23);
            txt_gradeName.TabIndex = 12;
            // 
            // label_colour
            // 
            label_colour.AutoSize = true;
            label_colour.Location = new Point(47, 301);
            label_colour.Name = "label_colour";
            label_colour.Size = new Size(43, 15);
            label_colour.TabIndex = 11;
            label_colour.Text = "Colour";
            // 
            // label_gradeOrder
            // 
            label_gradeOrder.AutoSize = true;
            label_gradeOrder.Location = new Point(47, 243);
            label_gradeOrder.Name = "label_gradeOrder";
            label_gradeOrder.Size = new Size(71, 15);
            label_gradeOrder.TabIndex = 10;
            label_gradeOrder.Text = "Grade Order";
            // 
            // label_gradeGroup
            // 
            label_gradeGroup.AutoSize = true;
            label_gradeGroup.Location = new Point(47, 184);
            label_gradeGroup.Name = "label_gradeGroup";
            label_gradeGroup.Size = new Size(74, 15);
            label_gradeGroup.TabIndex = 9;
            label_gradeGroup.Text = "Grade Group";
            // 
            // label_gradeName
            // 
            label_gradeName.AutoSize = true;
            label_gradeName.Location = new Point(47, 128);
            label_gradeName.Name = "label_gradeName";
            label_gradeName.Size = new Size(73, 15);
            label_gradeName.TabIndex = 8;
            label_gradeName.Text = "Grade Name";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(189, 353);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 17;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_edit_Click;
            // 
            // FrmEditGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 462);
            Controls.Add(btn_update);
            Controls.Add(pnl_gradeColour);
            Controls.Add(txt_gradeOrder);
            Controls.Add(txt_gradeGroup);
            Controls.Add(txt_gradeName);
            Controls.Add(label_colour);
            Controls.Add(label_gradeOrder);
            Controls.Add(label_gradeGroup);
            Controls.Add(label_gradeName);
            Name = "FrmEditGrade";
            Text = "FrmEditGrade";
            Load += FrmEditGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_gradeColour;
        private TextBox txt_gradeOrder;
        private TextBox txt_gradeGroup;
        private TextBox txt_gradeName;
        private Label label_colour;
        private Label label_gradeOrder;
        private Label label_gradeGroup;
        private Label label_gradeName;
        private Button btn_update;
    }
}