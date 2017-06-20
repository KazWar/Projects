namespace Assignment_3
{
    partial class PlayerEditorControl
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
            this.fieldLabel = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fieldLabel
            // 
            this.fieldLabel.AutoSize = true;
            this.fieldLabel.Location = new System.Drawing.Point(3, 5);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(101, 17);
            this.fieldLabel.TabIndex = 0;
            this.fieldLabel.Text = "Player Name : ";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(110, 5);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(149, 22);
            this.textBoxPlayerName.TabIndex = 1;
            // 
            // PlayerEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.fieldLabel);
            this.Name = "PlayerEditorControl";
            this.Size = new System.Drawing.Size(264, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fieldLabel;
        private System.Windows.Forms.TextBox textBoxPlayerName;
    }
}
