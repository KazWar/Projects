namespace Assignment1
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
            this.btnAddition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.lbCalculations = new System.Windows.Forms.ListBox();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(43, 86);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(41, 23);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.Tag = "1";
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number 1 : ";
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(100, 44);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(100, 22);
            this.tbNumber2.TabIndex = 2;
            // 
            // lbCalculations
            // 
            this.lbCalculations.FormattingEnabled = true;
            this.lbCalculations.ItemHeight = 16;
            this.lbCalculations.Location = new System.Drawing.Point(239, 16);
            this.lbCalculations.Name = "lbCalculations";
            this.lbCalculations.Size = new System.Drawing.Size(168, 212);
            this.lbCalculations.TabIndex = 3;
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(100, 16);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(100, 22);
            this.tbNumber1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number 2 : ";
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(90, 86);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(37, 23);
            this.btnSubstract.TabIndex = 6;
            this.btnSubstract.Tag = "2";
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(178, 86);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(44, 23);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Tag = "4";
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(133, 86);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(39, 23);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Tag = "3";
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 242);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.lbCalculations);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.ListBox lbCalculations;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
    }
}

