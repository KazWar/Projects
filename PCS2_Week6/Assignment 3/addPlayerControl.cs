using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class addPlayerControl : UserControl
    {
        public addPlayerControl()
        {
            InitializeComponent();
        }
        override public string Text
        {
            get { return textBoxPlayerName.Text; }
            set { textBoxPlayerName.Text = value; }
        }
    }
}
