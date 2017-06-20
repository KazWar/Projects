using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraineeRegistration
{
    public partial class Form1 : Form
    {
        Trainee trainee;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnCreateTrainee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) == false && string.IsNullOrWhiteSpace(tbName.Text) == false)
            {
                trainee = new Trainee(tbName.Text, Convert.ToInt32(tbAge.Text));
                this.Text = string.Format("Created by K.Waraksa :: Details for {0}, age {1}", trainee.Name, trainee.Age);
            }
            else
            {
                MessageBox.Show("Please enter a name and/or age for the trainee.");
            }
        }


        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (trainee != null && cbCourses.SelectedItem != null)
            {
                Course.CourseLevels courselevel;
                if (rbBeginner.Checked == true)
                {
                    courselevel = Course.CourseLevels.BEGINNER;
                }
                else if (rbAdvanced.Checked == true)
                {
                    courselevel = Course.CourseLevels.ADVANCED;
                }
                else
                {
                    courselevel = Course.CourseLevels.INTERMEDIATE;
                }

                trainee.RegisterForCourse(cbCourses.SelectedItem.ToString(), courselevel);
                showAllCourses();
            } else
            {
                MessageBox.Show("Please create a student and/or select a course from the list.");
            }
        }


        private void btnChangeCourse_Click(object sender, EventArgs e)
        {
            if (cbCourses.SelectedItem != null)
            {
                Course.CourseLevels courselevel;
                if (rbBeginner.Checked == true)
                {
                    courselevel = Course.CourseLevels.BEGINNER;
                }
                else if (rbAdvanced.Checked == true)
                {
                    courselevel = Course.CourseLevels.ADVANCED;
                }
                else
                {
                    courselevel = Course.CourseLevels.INTERMEDIATE;
                }

                trainee.ChangeCourse(cbCourses.SelectedItem.ToString(), courselevel);
                showAllCourses();
            }
            else
            {
                MessageBox.Show("Please select a course from the list.");
            }
        }


        private void btnShowAllCourses_Click(object sender, EventArgs e)
        {
            showAllCourses();
        }


        private void btnShowBeginnerCourses_Click(object sender, EventArgs e)
        {
            lbCourses.Items.Clear();
            foreach (Course course in trainee.GetAllBeginnerCourses())
            {
                lbCourses.Items.Add(course.AsString());
            }
        }


        private void btnShowBillingDetails_Click(object sender, EventArgs e)
        {
            tbBillingName.Text = trainee.Name + " " + trainee.Age;
            tbBillingNrOfCourses.Text = trainee.GetAllCourses().Count().ToString();

            decimal TotalPrice = 0;
            foreach (Course course in trainee.GetAllCourses())
            {
                TotalPrice += course.GetPrice(course.CourseLevel);
            }

            tbBillingTotalPrice.Text = TotalPrice.ToString();
        }

        /// <summary>
        /// Refreshes the listbox of the courses and gives all the new values.
        /// </summary>
        public void showAllCourses()
        {
            lbCourses.Items.Clear();
            foreach (Course course in trainee.GetAllCourses())
            {
                lbCourses.Items.Add(course.AsString());
            }
        } 
    }
}
