using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        private Teacher teacher;
        private Student student;

        public Form1()
        {
            InitializeComponent();
            teacher = new Teacher("Edna Krabappel", 111111, 36, Function.DOCENT_1, 1500, "Mcdonaldway 544"); // create a teacher
            student = new Student("Bart Simpson", 123456, 15, "USA", "Burgerstreet 14");

            LogTeacherChange("start");

            labelStudent.Text = student.Name;
            labelTeacher.Text = teacher.Name;
        }


        private void LogTeacherChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** " + operationName);
            this.richTextBoxLog.AppendText("\n"+ teacher.InfoString());
        }
        private void LogStudentChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** " + operationName);
            this.richTextBoxLog.AppendText("\n" + student.InfoString());
        }

        private void buttonSchoolYearTeacher_Click(object sender, EventArgs e)
        {
            teacher.StartAnotherSchoolYear();
            LogTeacherChange("Another school year");
        }

        private void buttonBirthdayTeacher_Click(object sender, EventArgs e)
        {
            teacher.CelebrateBirthday();
            LogTeacherChange("Birthday");
        }

        private void buttonPromote_Click(object sender, EventArgs e)
        {
            teacher.Promote();
            LogTeacherChange("promotion");
        }

        private void buttonSchoolYearStudent_Click(object sender, EventArgs e)
        {
            student.StartAnotherSchoolYear();
            LogStudentChange("Add Another Year");
        }

        private void buttonBirthdayStudent_Click(object sender, EventArgs e)
        {
            student.CelebrateBirthday();
            LogStudentChange("Birthday");
        }

        private void buttonAddModule_Click(object sender, EventArgs e)
        {
            student.AddOneModuleEC();
            LogStudentChange("Added 3 EC's");
        }
    }
}
