namespace Assignment_3
{
    partial class GameStartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAmountOfPlayers = new System.Windows.Forms.ComboBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.PlayerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the amount of players : ";
            // 
            // comboBoxAmountOfPlayers
            // 
            this.comboBoxAmountOfPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmountOfPlayers.FormattingEnabled = true;
            this.comboBoxAmountOfPlayers.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxAmountOfPlayers.Location = new System.Drawing.Point(218, 6);
            this.comboBoxAmountOfPlayers.Name = "comboBoxAmountOfPlayers";
            this.comboBoxAmountOfPlayers.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAmountOfPlayers.TabIndex = 2;
            this.comboBoxAmountOfPlayers.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmountOfPlayers_SelectedIndexChanged);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(15, 160);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(328, 50);
            this.buttonStartGame.TabIndex = 4;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.Location = new System.Drawing.Point(15, 36);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(324, 118);
            this.PlayerPanel.TabIndex = 5;
            // 
            // GameStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 221);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.comboBoxAmountOfPlayers);
            this.Controls.Add(this.label1);
            this.Name = "GameStartForm";
            this.Text = "Card Game Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAmountOfPlayers;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.FlowLayoutPanel PlayerPanel;
    }
}