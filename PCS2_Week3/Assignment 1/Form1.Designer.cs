namespace Assignment_1
{
    partial class Form1
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
            this.ButtonChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonChangeColor
            // 
            this.ButtonChangeColor.Location = new System.Drawing.Point(12, 189);
            this.ButtonChangeColor.Name = "ButtonChangeColor";
            this.ButtonChangeColor.Size = new System.Drawing.Size(258, 52);
            this.ButtonChangeColor.TabIndex = 0;
            this.ButtonChangeColor.Text = "Change Color";
            this.ButtonChangeColor.UseVisualStyleBackColor = true;
            this.ButtonChangeColor.Click += new System.EventHandler(this.ButtonChangeColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.ButtonChangeColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonChangeColor;
    }
}

