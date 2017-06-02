using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class DiceForm : Form
    {
        Random random = new Random();
        public DiceForm()
        {
            InitializeComponent();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            int result = random.Next(1, 7);

            foreach (Control control in Controls.OfType<Control>().ToList().Where(x => x is PictureBox))
            {
                control.Visible = (control.Name.Contains(result.ToString()) && control is PictureBox);

                //if (control.Visible && control is PictureBox && !(control.Name.Contains(result.ToString())))
                //{
                //    control.Visible = false;
                //}

                //if (control.Name.Contains(result.ToString()) && control is PictureBox)
                //{
                //    control.Visible = true;
                //}
            }
        }
    }
}
