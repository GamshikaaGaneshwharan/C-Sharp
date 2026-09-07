namespace WinFormsApp2
{
    partial class frmGrades
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
            components = new System.ComponentModel.Container();
            btn_AllGrades = new Button();
            btn_showGrades = new Button();
            btn_edit = new Button();
            btn_create = new Button();
            btn_delete = new Button();
            dgvGrades = new DataGridView();
            label_id = new Label();
            label_gradeName = new Label();
            label_gradeGroup = new Label();
            label_gradeOrder = new Label();
            label5 = new Label();
            txt_id = new TextBox();
            txt_GradeName = new TextBox();
            cmb_gradeGroup = new ComboBox();
            cmb_gradeOrder = new ComboBox();
            cmb_gradeColour = new ComboBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btn_AllGrades
            // 
            btn_AllGrades.Location = new Point(35, 32);
            btn_AllGrades.Name = "btn_AllGrades";
            btn_AllGrades.Size = new Size(75, 23);
            btn_AllGrades.TabIndex = 1;
            btn_AllGrades.Text = "All Grades";
            btn_AllGrades.UseVisualStyleBackColor = true;
            btn_AllGrades.Click += btn_AllGrades_Click;
            // 
            // btn_showGrades
            // 
            btn_showGrades.Location = new Point(135, 32);
            btn_showGrades.Name = "btn_showGrades";
            btn_showGrades.Size = new Size(75, 23);
            btn_showGrades.TabIndex = 2;
            btn_showGrades.Text = "Show";
            btn_showGrades.UseVisualStyleBackColor = true;
            btn_showGrades.Click += btn_showGrades_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(232, 32);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 3;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(337, 32);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(75, 23);
            btn_create.TabIndex = 4;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(442, 32);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // dgvGrades
            // 
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(35, 81);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.Size = new Size(366, 432);
            dgvGrades.TabIndex = 6;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(446, 111);
            label_id.Name = "label_id";
            label_id.Size = new Size(18, 15);
            label_id.TabIndex = 7;
            label_id.Text = "ID";
            // 
            // label_gradeName
            // 
            label_gradeName.AutoSize = true;
            label_gradeName.Location = new Point(446, 151);
            label_gradeName.Name = "label_gradeName";
            label_gradeName.Size = new Size(73, 15);
            label_gradeName.TabIndex = 7;
            label_gradeName.Text = "Grade Name";
            // 
            // label_gradeGroup
            // 
            label_gradeGroup.AutoSize = true;
            label_gradeGroup.Location = new Point(446, 192);
            label_gradeGroup.Name = "label_gradeGroup";
            label_gradeGroup.Size = new Size(74, 15);
            label_gradeGroup.TabIndex = 7;
            label_gradeGroup.Text = "Grade Group";
            // 
            // label_gradeOrder
            // 
            label_gradeOrder.AutoSize = true;
            label_gradeOrder.Location = new Point(446, 235);
            label_gradeOrder.Name = "label_gradeOrder";
            label_gradeOrder.Size = new Size(71, 15);
            label_gradeOrder.TabIndex = 7;
            label_gradeOrder.Text = "Grade Order";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 278);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "Colour";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(529, 111);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(121, 23);
            txt_id.TabIndex = 8;
            // 
            // txt_GradeName
            // 
            txt_GradeName.Location = new Point(529, 151);
            txt_GradeName.Name = "txt_GradeName";
            txt_GradeName.Size = new Size(121, 23);
            txt_GradeName.TabIndex = 9;
            // 
            // cmb_gradeGroup
            // 
            cmb_gradeGroup.FormattingEnabled = true;
            cmb_gradeGroup.Location = new Point(529, 192);
            cmb_gradeGroup.Name = "cmb_gradeGroup";
            cmb_gradeGroup.Size = new Size(121, 23);
            cmb_gradeGroup.TabIndex = 10;
            // 
            // cmb_gradeOrder
            // 
            cmb_gradeOrder.FormattingEnabled = true;
            cmb_gradeOrder.Location = new Point(529, 235);
            cmb_gradeOrder.Name = "cmb_gradeOrder";
            cmb_gradeOrder.Size = new Size(121, 23);
            cmb_gradeOrder.TabIndex = 11;
            // 
            // cmb_gradeColour
            // 
            cmb_gradeColour.FormattingEnabled = true;
            cmb_gradeColour.Location = new Point(529, 275);
            cmb_gradeColour.Name = "cmb_gradeColour";
            cmb_gradeColour.Size = new Size(121, 23);
            cmb_gradeColour.TabIndex = 12;
            // 
            // frmGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 559);
            Controls.Add(cmb_gradeColour);
            Controls.Add(cmb_gradeOrder);
            Controls.Add(cmb_gradeGroup);
            Controls.Add(txt_GradeName);
            Controls.Add(txt_id);
            Controls.Add(label5);
            Controls.Add(label_gradeOrder);
            Controls.Add(label_gradeGroup);
            Controls.Add(label_gradeName);
            Controls.Add(label_id);
            Controls.Add(dgvGrades);
            Controls.Add(btn_delete);
            Controls.Add(btn_create);
            Controls.Add(btn_edit);
            Controls.Add(btn_showGrades);
            Controls.Add(btn_AllGrades);
            Name = "frmGrades";
            Text = "frmGrades";
            Load += frmGrades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_AllGrades;
        private Button btn_showGrades;
        private Button btn_edit;
        private Button btn_create;
        private Button btn_delete;
        private DataGridView dgvGrades;
        private Label label_id;
        private Label label_gradeName;
        private Label label_gradeGroup;
        private Label label_gradeOrder;
        private Label label5;
        private TextBox txt_id;
        private TextBox txt_GradeName;
        private ComboBox cmb_gradeGroup;
        private ComboBox cmb_gradeOrder;
        private ComboBox cmb_gradeColour;
        private BindingSource bindingSource1;
    }
}