namespace Assignment_2
{
    partial class StudentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonFindStudent = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxStudents);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 411);
            this.panel1.TabIndex = 0;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(0, 0);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(182, 411);
            this.listBoxStudents.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.textBoxStudentName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(216, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 411);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonFindStudent);
            this.panel4.Location = new System.Drawing.Point(3, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 43);
            this.panel4.TabIndex = 1;
            // 
            // buttonFindStudent
            // 
            this.buttonFindStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFindStudent.Enabled = false;
            this.buttonFindStudent.Location = new System.Drawing.Point(0, 0);
            this.buttonFindStudent.Name = "buttonFindStudent";
            this.buttonFindStudent.Size = new System.Drawing.Size(151, 43);
            this.buttonFindStudent.TabIndex = 5;
            this.buttonFindStudent.Text = "Find Student";
            this.buttonFindStudent.UseVisualStyleBackColor = true;
            this.buttonFindStudent.Click += new System.EventHandler(this.buttonFindStudent_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonAddStudent);
            this.panel5.Location = new System.Drawing.Point(3, 273);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 43);
            this.panel5.TabIndex = 1;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddStudent.Location = new System.Drawing.Point(0, 0);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(151, 43);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(6, 31);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(148, 22);
            this.textBoxStudentName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonRemoveStudent);
            this.panel3.Location = new System.Drawing.Point(3, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 43);
            this.panel3.TabIndex = 0;
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveStudent.Location = new System.Drawing.Point(0, 0);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(151, 43);
            this.buttonRemoveStudent.TabIndex = 4;
            this.buttonRemoveStudent.Text = "Remove Student";
            this.buttonRemoveStudent.UseVisualStyleBackColor = true;
            this.buttonRemoveStudent.Click += new System.EventHandler(this.buttonRemoveStudent_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonFindStudent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRemoveStudent;
    }
}

