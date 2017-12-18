namespace assignment2
{
    partial class recursiveFunctionsForm
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
            this.tbValueA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbMethods = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValueB = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbValueA
            // 
            this.tbValueA.Location = new System.Drawing.Point(190, 8);
            this.tbValueA.Name = "tbValueA";
            this.tbValueA.Size = new System.Drawing.Size(100, 22);
            this.tbValueA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Val A";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(159, 64);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 32);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbMethods
            // 
            this.lbMethods.FormattingEnabled = true;
            this.lbMethods.ItemHeight = 16;
            this.lbMethods.Location = new System.Drawing.Point(12, 12);
            this.lbMethods.Name = "lbMethods";
            this.lbMethods.Size = new System.Drawing.Size(120, 100);
            this.lbMethods.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Val B";
            // 
            // tbValueB
            // 
            this.tbValueB.Location = new System.Drawing.Point(190, 36);
            this.tbValueB.Name = "tbValueB";
            this.tbValueB.Size = new System.Drawing.Size(100, 22);
            this.tbValueB.TabIndex = 4;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(190, 102);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 22);
            this.tbResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "result";
            // 
            // recursiveFunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 130);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValueB);
            this.Controls.Add(this.lbMethods);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValueA);
            this.Name = "recursiveFunctionsForm";
            this.Text = "Recursive Functions Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValueA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lbMethods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValueB;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
    }
}

