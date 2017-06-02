namespace Assignment_3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCreateLottery = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDrawNextNumber = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonDrawAllNumbers = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.textBoxNumbersOfWantedNrs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxResults);
            this.panel1.Location = new System.Drawing.Point(260, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 355);
            this.panel1.TabIndex = 0;
            // 
            // listBoxResults
            // 
            this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(0, 0);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(200, 355);
            this.listBoxResults.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCreateLottery);
            this.panel3.Location = new System.Drawing.Point(12, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 30);
            this.panel3.TabIndex = 2;
            // 
            // buttonCreateLottery
            // 
            this.buttonCreateLottery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateLottery.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateLottery.Name = "buttonCreateLottery";
            this.buttonCreateLottery.Size = new System.Drawing.Size(242, 30);
            this.buttonCreateLottery.TabIndex = 0;
            this.buttonCreateLottery.Text = "Create Lottery Object";
            this.buttonCreateLottery.UseVisualStyleBackColor = true;
            this.buttonCreateLottery.Click += new System.EventHandler(this.buttonCreateLottery_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonDrawNextNumber);
            this.panel4.Location = new System.Drawing.Point(12, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 30);
            this.panel4.TabIndex = 3;
            // 
            // buttonDrawNextNumber
            // 
            this.buttonDrawNextNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDrawNextNumber.Enabled = false;
            this.buttonDrawNextNumber.Location = new System.Drawing.Point(0, 0);
            this.buttonDrawNextNumber.Name = "buttonDrawNextNumber";
            this.buttonDrawNextNumber.Size = new System.Drawing.Size(242, 30);
            this.buttonDrawNextNumber.TabIndex = 0;
            this.buttonDrawNextNumber.Text = "Draw Next Number";
            this.buttonDrawNextNumber.UseVisualStyleBackColor = true;
            this.buttonDrawNextNumber.Click += new System.EventHandler(this.buttonDrawNextNumber_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonDrawAllNumbers);
            this.panel5.Location = new System.Drawing.Point(12, 325);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 30);
            this.panel5.TabIndex = 3;
            // 
            // buttonDrawAllNumbers
            // 
            this.buttonDrawAllNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDrawAllNumbers.Enabled = false;
            this.buttonDrawAllNumbers.Location = new System.Drawing.Point(0, 0);
            this.buttonDrawAllNumbers.Name = "buttonDrawAllNumbers";
            this.buttonDrawAllNumbers.Size = new System.Drawing.Size(242, 30);
            this.buttonDrawAllNumbers.TabIndex = 0;
            this.buttonDrawAllNumbers.Text = "Draw All Numbers";
            this.buttonDrawAllNumbers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.56199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.43801F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxMaxValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNumbersOfWantedNrs, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 113);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMaxValue.Location = new System.Drawing.Point(106, 3);
            this.textBoxMaxValue.Multiline = true;
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(133, 31);
            this.textBoxMaxValue.TabIndex = 0;
            // 
            // textBoxNumbersOfWantedNrs
            // 
            this.textBoxNumbersOfWantedNrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumbersOfWantedNrs.Location = new System.Drawing.Point(106, 40);
            this.textBoxNumbersOfWantedNrs.Multiline = true;
            this.textBoxNumbersOfWantedNrs.Name = "textBoxNumbersOfWantedNrs";
            this.textBoxNumbersOfWantedNrs.Size = new System.Drawing.Size(133, 31);
            this.textBoxNumbersOfWantedNrs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Value: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nr of Wanted Numbers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lottery Raffle";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCreateLottery;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDrawNextNumber;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonDrawAllNumbers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxMaxValue;
        private System.Windows.Forms.TextBox textBoxNumbersOfWantedNrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

