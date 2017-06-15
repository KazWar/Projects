namespace Assignment_3
{
    partial class playerControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDrawCard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSelectCard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRdyUp = new System.Windows.Forms.Button();
            this.listBoxPlayerCards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDrawCard);
            this.panel1.Location = new System.Drawing.Point(3, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 43);
            this.panel1.TabIndex = 0;
            // 
            // buttonDrawCard
            // 
            this.buttonDrawCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDrawCard.Location = new System.Drawing.Point(0, 0);
            this.buttonDrawCard.Name = "buttonDrawCard";
            this.buttonDrawCard.Size = new System.Drawing.Size(214, 43);
            this.buttonDrawCard.TabIndex = 0;
            this.buttonDrawCard.Text = "Draw Card";
            this.buttonDrawCard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSelectCard);
            this.panel2.Location = new System.Drawing.Point(3, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 43);
            this.panel2.TabIndex = 1;
            // 
            // buttonSelectCard
            // 
            this.buttonSelectCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectCard.Location = new System.Drawing.Point(0, 0);
            this.buttonSelectCard.Name = "buttonSelectCard";
            this.buttonSelectCard.Size = new System.Drawing.Size(214, 43);
            this.buttonSelectCard.TabIndex = 0;
            this.buttonSelectCard.Text = "Select Card";
            this.buttonSelectCard.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonRdyUp);
            this.panel3.Location = new System.Drawing.Point(3, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 43);
            this.panel3.TabIndex = 2;
            // 
            // buttonRdyUp
            // 
            this.buttonRdyUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRdyUp.Location = new System.Drawing.Point(0, 0);
            this.buttonRdyUp.Name = "buttonRdyUp";
            this.buttonRdyUp.Size = new System.Drawing.Size(214, 43);
            this.buttonRdyUp.TabIndex = 0;
            this.buttonRdyUp.Text = "Ready Up";
            this.buttonRdyUp.UseVisualStyleBackColor = true;
            // 
            // listBoxPlayerCards
            // 
            this.listBoxPlayerCards.FormattingEnabled = true;
            this.listBoxPlayerCards.ItemHeight = 16;
            this.listBoxPlayerCards.Location = new System.Drawing.Point(3, 3);
            this.listBoxPlayerCards.Name = "listBoxPlayerCards";
            this.listBoxPlayerCards.Size = new System.Drawing.Size(214, 148);
            this.listBoxPlayerCards.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Points : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "N.A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            // 
            // playerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlayerCards);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "playerControl";
            this.Size = new System.Drawing.Size(223, 351);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
