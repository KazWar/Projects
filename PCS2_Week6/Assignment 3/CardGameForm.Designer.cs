namespace Assignment_3
{
    partial class CardGameForm
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
            this.panelPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelPlayers
            // 
            this.panelPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayers.Location = new System.Drawing.Point(0, 0);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(148, 353);
            this.panelPlayers.TabIndex = 0;
            // 
            // CardGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 353);
            this.Controls.Add(this.panelPlayers);
            this.Name = "CardGameForm";
            this.Text = "Card Game";
            this.Activated += new System.EventHandler(this.CardGameForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelPlayers;
    }
}

