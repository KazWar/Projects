using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._1
{
    public partial class ResultForm : Form
    {
        static int[] array = new int[5] { 0, 0, 0, 0, 0 };

        Dictionary<Func<int, bool>, Action> myDictionary = new Dictionary<Func<int, bool>, Action>
            {
             { x => x >= 90 && x <= 100, () => array[0]++},
             { x => x >= 80 && x <= 89, () => array[1]++},
             { x => x >= 70 && x <= 79, () => array[2]++},
             { x => x >= 60 && x <= 69, () => array[3]++},
             { x => x < 60, () => array[4]++}
            };

        public ResultForm()
        {
            InitializeComponent();
            FormClosing += ResultForm_FormClosing;
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void refresh()
        {
            textBox90.Text = array[0].ToString();
            textBox80.Text = array[1].ToString();
            textBox70.Text = array[2].ToString();
            textBox60.Text = array[3].ToString();
            textBox60Less.Text = array[4].ToString();
            textBoxStudentTotal.Text = array.Sum().ToString();
        }

        public void addToListOfResults(int studentResult)
        {
            myDictionary.First(sw => sw.Key(studentResult)).Value();
        }
    }
}
