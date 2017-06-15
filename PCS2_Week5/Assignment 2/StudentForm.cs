using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class StudentForm : Form
    {
        MethodController MC = new MethodController();

        public StudentForm()
        {
            InitializeComponent();
            listBoxStudents.DataSource = null;
            listBoxStudents.DataSource = MC.listOfStudents;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MC.Methods(MethodController.Types.Add,textBoxStudentName);
            refresh();
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            
            MC.Methods(MethodController.Types.Remove, textBoxStudentName, listBoxStudents.SelectedIndex);
            refresh();
        }


        private void buttonFindStudent_Click(object sender, EventArgs e)
        {
            MC.Methods(MethodController.Types.Find, textBoxStudentName);
            refresh();
        }
        
        private void refresh()
        {
            listBoxStudents.DataSource = null;
            listBoxStudents.DataSource = MC.listOfStudents;
        }
    }
}
