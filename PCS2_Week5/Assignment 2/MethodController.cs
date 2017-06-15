using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public class MethodController
    {
        public List<string> listOfStudents = new List<string>();

        public enum Types
        {
            Add,
            Remove,
            Find
        }

        public void Methods(Types Type, TextBox input, dynamic optional = null)
        {
            if (CheckEmpty(input) == false)
            {
                switch (Type)
                {
                    case Types.Add:
                        AddStudent(input);
                        break;
                    case Types.Remove:
                        RemoveStudent(input, optional);
                        break;
                    case Types.Find:
                        FindStudent(input);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Studentname input is empty!");
            }
        }

        private void AddStudent(TextBox StudentName)
        {
            listOfStudents.Add(StudentName.Text);
        }

        private void RemoveStudent(TextBox StudentName, int selectedStudent = -1)
        {
            if (selectedStudent != -1)
            {
                listOfStudents.RemoveAt(selectedStudent);
            }
            else
            {
                listOfStudents.Remove(listOfStudents.Find(x => x == StudentName.Text));
            }
        }

        private void FindStudent (TextBox StudentName)
        {
        }

        private bool CheckEmpty(TextBox inputfield)
        {
            bool empty;
            if (string.IsNullOrWhiteSpace(inputfield.Text) == true)
            {
                empty = true;
                return empty;
            }
            else
            {
                empty = false;
                return empty;
            }
        }
    }
}
