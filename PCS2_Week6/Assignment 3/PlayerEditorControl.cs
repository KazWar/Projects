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
    public partial class PlayerEditorControl : UserControl
    {
        private PlayerEditorControl()
        {
            InitializeComponent();
        }


        public PlayerEditorControl(string tag) : this()
        {
            textBoxPlayerName.Tag = tag;
            fieldLabel.Text = String.Format("Player #{0}", tag);
        }


        override public string Text
        {
            get { return textBoxPlayerName.Text; }
            set { textBoxPlayerName.Text = value; }
        }
    }
}
