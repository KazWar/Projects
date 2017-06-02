namespace Assignment_4._1
{
    partial class InputForm
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEnterInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 31);
            this.textBoxInput.MaxLength = 2;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 22);
            this.textBoxInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.MaximumSize = new System.Drawing.Size(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter student grades below. Press 0 to stop.";
            // 
            // ButtonEnterInput
            // 
            this.ButtonEnterInput.Location = new System.Drawing.Point(118, 30);
            this.ButtonEnterInput.Name = "ButtonEnterInput";
            this.ButtonEnterInput.Size = new System.Drawing.Size(179, 26);
            this.ButtonEnterInput.TabIndex = 4;
            this.ButtonEnterInput.Text = "Enter Result";
            this.ButtonEnterInput.UseVisualStyleBackColor = true;
            this.ButtonEnterInput.Click += new System.EventHandler(this.ButtonEnterInput_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 68);
            this.Controls.Add(this.ButtonEnterInput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "InputForm";
            this.Text = "Input Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEnterInput;
    }
}

