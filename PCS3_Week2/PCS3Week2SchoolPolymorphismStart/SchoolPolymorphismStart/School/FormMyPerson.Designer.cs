namespace School
{
    partial class FormMyPerson
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
            this.buttonBirthday = new System.Windows.Forms.Button();
            this.buttonSchoolYear = new System.Windows.Forms.Button();
            this.richTextBoxActivityLogMyPerson = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPCN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonPerson = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.GBPersonTypes = new System.Windows.Forms.GroupBox();
            this.btnPromote = new System.Windows.Forms.Button();
            this.btnAddEC = new System.Windows.Forms.Button();
            this.lbPersons = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMyPersonInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTeacher.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.GBPersonTypes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBirthday
            // 
            this.buttonBirthday.Location = new System.Drawing.Point(322, 395);
            this.buttonBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBirthday.Name = "buttonBirthday";
            this.buttonBirthday.Size = new System.Drawing.Size(152, 33);
            this.buttonBirthday.TabIndex = 7;
            this.buttonBirthday.Text = "celebrate birthday!";
            this.buttonBirthday.UseVisualStyleBackColor = true;
            this.buttonBirthday.Click += new System.EventHandler(this.buttonBirthdayStudent_Click);
            // 
            // buttonSchoolYear
            // 
            this.buttonSchoolYear.Location = new System.Drawing.Point(322, 354);
            this.buttonSchoolYear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSchoolYear.Name = "buttonSchoolYear";
            this.buttonSchoolYear.Size = new System.Drawing.Size(152, 33);
            this.buttonSchoolYear.TabIndex = 12;
            this.buttonSchoolYear.Text = "another school year";
            this.buttonSchoolYear.UseVisualStyleBackColor = true;
            this.buttonSchoolYear.Click += new System.EventHandler(this.buttonSchoolYearTeacher_Click);
            // 
            // richTextBoxActivityLogMyPerson
            // 
            this.richTextBoxActivityLogMyPerson.Location = new System.Drawing.Point(493, 28);
            this.richTextBoxActivityLogMyPerson.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxActivityLogMyPerson.Name = "richTextBoxActivityLogMyPerson";
            this.richTextBoxActivityLogMyPerson.Size = new System.Drawing.Size(311, 563);
            this.richTextBoxActivityLogMyPerson.TabIndex = 16;
            this.richTextBoxActivityLogMyPerson.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "action log";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(160, 266);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(146, 43);
            this.buttonCreate.TabIndex = 32;
            this.buttonCreate.Text = "create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTeacher.Controls.Add(this.textBoxSalary);
            this.panelTeacher.Controls.Add(this.label7);
            this.panelTeacher.Location = new System.Drawing.Point(329, 186);
            this.panelTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(141, 72);
            this.panelTeacher.TabIndex = 31;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(63, 7);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(65, 22);
            this.textBoxSalary.TabIndex = 13;
            this.textBoxSalary.Text = "1500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "salary";
            // 
            // panelStudent
            // 
            this.panelStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStudent.Controls.Add(this.textBoxStudentNumber);
            this.panelStudent.Controls.Add(this.label6);
            this.panelStudent.Controls.Add(this.label5);
            this.panelStudent.Controls.Add(this.textBoxCountry);
            this.panelStudent.Location = new System.Drawing.Point(104, 186);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(4);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(217, 72);
            this.panelStudent.TabIndex = 30;
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Location = new System.Drawing.Point(116, 36);
            this.textBoxStudentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(85, 22);
            this.textBoxStudentNumber.TabIndex = 13;
            this.textBoxStudentNumber.Text = "222222";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "student number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "country";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(116, 4);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(85, 22);
            this.textBoxCountry.TabIndex = 11;
            this.textBoxCountry.Text = "USA";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(124, 76);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(347, 22);
            this.textBoxAge.TabIndex = 29;
            this.textBoxAge.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "age";
            // 
            // textBoxPCN
            // 
            this.textBoxPCN.Location = new System.Drawing.Point(124, 44);
            this.textBoxPCN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPCN.Name = "textBoxPCN";
            this.textBoxPCN.Size = new System.Drawing.Size(347, 22);
            this.textBoxPCN.TabIndex = 27;
            this.textBoxPCN.Text = "123456";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "pcn";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 12);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(347, 22);
            this.textBoxName.TabIndex = 25;
            this.textBoxName.Text = "Peter Smith";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "name";
            // 
            // radioButtonPerson
            // 
            this.radioButtonPerson.AutoSize = true;
            this.radioButtonPerson.Checked = true;
            this.radioButtonPerson.Location = new System.Drawing.Point(7, 22);
            this.radioButtonPerson.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPerson.Name = "radioButtonPerson";
            this.radioButtonPerson.Size = new System.Drawing.Size(74, 21);
            this.radioButtonPerson.TabIndex = 34;
            this.radioButtonPerson.TabStop = true;
            this.radioButtonPerson.Tag = "person";
            this.radioButtonPerson.Text = "Person";
            this.radioButtonPerson.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(88, 22);
            this.radioButtonStudent.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(78, 21);
            this.radioButtonStudent.TabIndex = 35;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Tag = "student";
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Location = new System.Drawing.Point(310, 22);
            this.radioButtonTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(82, 21);
            this.radioButtonTeacher.TabIndex = 36;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Tag = "teacher";
            this.radioButtonTeacher.Text = "Teacher";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            // 
            // GBPersonTypes
            // 
            this.GBPersonTypes.Controls.Add(this.radioButtonPerson);
            this.GBPersonTypes.Controls.Add(this.radioButtonTeacher);
            this.GBPersonTypes.Controls.Add(this.radioButtonStudent);
            this.GBPersonTypes.Location = new System.Drawing.Point(19, 105);
            this.GBPersonTypes.Name = "GBPersonTypes";
            this.GBPersonTypes.Size = new System.Drawing.Size(451, 52);
            this.GBPersonTypes.TabIndex = 37;
            this.GBPersonTypes.TabStop = false;
            this.GBPersonTypes.Text = "Person Types";
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(322, 436);
            this.btnPromote.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(152, 33);
            this.btnPromote.TabIndex = 38;
            this.btnPromote.Text = "Make Promotion";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // btnAddEC
            // 
            this.btnAddEC.Location = new System.Drawing.Point(322, 477);
            this.btnAddEC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEC.Name = "btnAddEC";
            this.btnAddEC.Size = new System.Drawing.Size(152, 33);
            this.btnAddEC.TabIndex = 39;
            this.btnAddEC.Text = "Add one module EC\'s";
            this.btnAddEC.UseVisualStyleBackColor = true;
            this.btnAddEC.Click += new System.EventHandler(this.btnAddEC_Click);
            // 
            // lbPersons
            // 
            this.lbPersons.FormattingEnabled = true;
            this.lbPersons.ItemHeight = 16;
            this.lbPersons.Location = new System.Drawing.Point(-1, 344);
            this.lbPersons.Name = "lbPersons";
            this.lbPersons.Size = new System.Drawing.Size(186, 244);
            this.lbPersons.TabIndex = 40;
            this.lbPersons.SelectedIndexChanged += new System.EventHandler(this.lbPersons_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMyPersonInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 344);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 166);
            this.panel1.TabIndex = 41;
            // 
            // labelMyPersonInfo
            // 
            this.labelMyPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelMyPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.labelMyPersonInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyPersonInfo.Name = "labelMyPersonInfo";
            this.labelMyPersonInfo.Size = new System.Drawing.Size(121, 130);
            this.labelMyPersonInfo.TabIndex = 22;
            this.labelMyPersonInfo.Text = "please create!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "my person:";
            // 
            // FormMyPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPersons);
            this.Controls.Add(this.btnAddEC);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.GBPersonTypes);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPCN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxActivityLogMyPerson);
            this.Controls.Add(this.buttonSchoolYear);
            this.Controls.Add(this.buttonBirthday);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMyPerson";
            this.Text = "School Form";
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.GBPersonTypes.ResumeLayout(false);
            this.GBPersonTypes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBirthday;
        private System.Windows.Forms.Button buttonSchoolYear;
        private System.Windows.Forms.RichTextBox richTextBoxActivityLogMyPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPCN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonPerson;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonTeacher;
        private System.Windows.Forms.GroupBox GBPersonTypes;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Button btnAddEC;
        private System.Windows.Forms.ListBox lbPersons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMyPersonInfo;
        private System.Windows.Forms.Label label1;
    }
}

