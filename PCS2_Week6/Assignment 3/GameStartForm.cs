using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class GameStartForm : Form
    {
        public GameStartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recursively finds all controls of specified type within the given container control
        /// </summary>
        /// <param name="container">Container control to traverse</param>
        /// <param name="controlType">Type of controls to find</param>
        /// <param name="controls">Collection where found controls are accumulated</param>
        /// <returns>Found controls</returns>
        /// <remarks>
        /// This is a fine example of recursion - a function which calls itself.
        /// Here, when container has child controls, we dive inside them in further search of the wanted controls.
        /// Again, if any of child controls has more child controls, the recursion will proceed into them, 
        /// theoretically infinitely. Practically this will eat up computer memory and throw the dreaded
        /// StackOverflow exception, which is a clear sign of recursion gone wrong :-)
        /// </remarks>
        private List<Control> GetAllControls(Control container, Type controlType, List<Control> controls = null)
        {
            if (controls == null)
            { 
                controls = new List<Control>();
            }

            if (container.GetType() == controlType)
            {
                controls.Add(container);
            }

            if (container.Controls != null)
            {
                foreach (Control child in container.Controls)
                {
                     GetAllControls(child, controlType, controls);
                }
            }

            return controls;
        }


        /// <summary>
        /// Starts the game
        /// </summary>
        /// <param name="inputs">List of text boxes containing player names</param>
        private void StartGame(List<Control> inputs)
        {
            var players = new Players();
            foreach (TextBox input in inputs)
            {
                var player = new Player(input.Text);
                players.Add(player);
            }

            this.Hide();
            CardGameForm GameForm = new CardGameForm(players);
            GameForm.Activate();
            GameForm.Show();
        }


        /// <summary>
        /// Validates player names
        /// </summary>
        /// <param name="list">List of textboxes containing player names</param>
        /// <returns>List of found errors or null, if no errors found</returns>
        private List<string> ValidateInputs(List<Control> list)
        {
            var errors = new List<string>();
            foreach (TextBox input in list)
            {
                if (string.IsNullOrWhiteSpace(input.Text.Trim()))
                {
                    errors.Add(String.Format("Player #{0} required", input.Tag));
                }
            }
            return errors.Count > 0 ? errors : null;
        }


        /// <summary>
        /// Displays the found input validation errors
        /// </summary>
        /// <param name="errors">Errors to display</param>
        private void DisplayErrors(List<string> errors)
        {
            if (errors != null && errors.Count > 0)
            {
                var message = String.Join("\n", errors);
                MessageBox.Show(message);
            }
        }


        /// <summary>
        /// Creates inputs for entering the specified amount of players
        /// </summary>
        /// <param name="count">Amount of players to add</param>
        private void AddPlayers(int count)
        {
            if (count > 0)
            {
                PlayerPanel.Controls.Clear();
                while (PlayerPanel.Controls.Count < count)
                {
                    var label = (PlayerPanel.Controls.Count + 1).ToString();
                    PlayerEditorControl playerName = new PlayerEditorControl(label);
                    PlayerPanel.Controls.Add(playerName);
                }
            }
        }


        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            // Collect all inputs
            var inputs = GetAllControls(PlayerPanel, typeof(TextBox));
            // Validate the entered values
            var errors = ValidateInputs(inputs);
            // If no errors, play the game
            if (errors == null)
            {
                StartGame(inputs);
            }
            else
            // Otherwise display errors
            {
                DisplayErrors(errors);
            }
        }


        private void comboBoxAmountOfPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddPlayers(comboBoxAmountOfPlayers.SelectedIndex + 1);
        }


    }
}