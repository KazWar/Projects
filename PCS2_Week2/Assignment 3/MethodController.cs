using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public class MethodController
    {
        public void AddToList (string value, BindingList<double> items)
        {
            var input = Convert.ToDouble(value);
            if (input > 10 || input < 1)
            {
                MessageBox.Show("Please provide a value between 1 and 10");
            }
            else
            {
                items.Add(input);
            }
        }

        public void RemoveFromList(BindingList<double> items)
        {
            items.Clear();
        }

        public void ClearAllText(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
    }
}
