namespace Assignment_3
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDrawCard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSelectCard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRdyUp = new System.Windows.Forms.Button();
            this.listBoxPlayerCards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayerPoints = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDrawCard);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonDrawCard
            // 
            resources.ApplyResources(this.buttonDrawCard, "buttonDrawCard");
            this.buttonDrawCard.Name = "buttonDrawCard";
            this.buttonDrawCard.UseVisualStyleBackColor = true;
            this.buttonDrawCard.Click += new System.EventHandler(this.buttonDrawCard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSelectCard);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // buttonSelectCard
            // 
            resources.ApplyResources(this.buttonSelectCard, "buttonSelectCard");
            this.buttonSelectCard.Name = "buttonSelectCard";
            this.buttonSelectCard.UseVisualStyleBackColor = true;
            this.buttonSelectCard.Click += new System.EventHandler(this.buttonSelectCard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonRdyUp);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // buttonRdyUp
            // 
            resources.ApplyResources(this.buttonRdyUp, "buttonRdyUp");
            this.buttonRdyUp.Name = "buttonRdyUp";
            this.buttonRdyUp.UseVisualStyleBackColor = true;
            this.buttonRdyUp.Click += new System.EventHandler(this.buttonRdyUp_Click);
            // 
            // listBoxPlayerCards
            // 
            this.listBoxPlayerCards.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxPlayerCards, "listBoxPlayerCards");
            this.listBoxPlayerCards.Name = "listBoxPlayerCards";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // labelPlayerName
            // 
            resources.ApplyResources(this.labelPlayerName, "labelPlayerName");
            this.labelPlayerName.Name = "labelPlayerName";
            // 
            // labelPlayerPoints
            // 
            resources.ApplyResources(this.labelPlayerPoints, "labelPlayerPoints");
            this.labelPlayerPoints.Name = "labelPlayerPoints";
            // 
            // PlayerControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPlayerPoints);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlayerCards);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlayerControl";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDrawCard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSelectCard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRdyUp;
        private System.Windows.Forms.ListBox listBoxPlayerCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelPlayerPoints;
    }
}
