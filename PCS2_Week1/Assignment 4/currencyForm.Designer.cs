namespace Assignment_4
{
    partial class CurrencyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertFrom = new System.Windows.Forms.Button();
            this.btnConvertTo = new System.Windows.Forms.Button();
            this.tbValue2 = new System.Windows.Forms.TextBox();
            this.tbValue1 = new System.Windows.Forms.TextBox();
            this.nmudExchangeValue = new System.Windows.Forms.NumericUpDown();
            this.btnInfo = new System.Windows.Forms.Button();
            this.cbToCurrency = new System.Windows.Forms.ComboBox();
            this.cbFromCurrency = new System.Windows.Forms.ComboBox();
            this.lbCurrencySign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudExchangeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(510, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exchange rate 1 euro = ";
            // 
            // btnConvertFrom
            // 
            this.btnConvertFrom.Location = new System.Drawing.Point(323, 86);
            this.btnConvertFrom.Name = "btnConvertFrom";
            this.btnConvertFrom.Size = new System.Drawing.Size(75, 23);
            this.btnConvertFrom.TabIndex = 3;
            this.btnConvertFrom.Text = ">";
            this.btnConvertFrom.UseVisualStyleBackColor = true;
            this.btnConvertFrom.Click += new System.EventHandler(this.btnConvertFrom_Click);
            // 
            // btnConvertTo
            // 
            this.btnConvertTo.Location = new System.Drawing.Point(242, 86);
            this.btnConvertTo.Name = "btnConvertTo";
            this.btnConvertTo.Size = new System.Drawing.Size(75, 23);
            this.btnConvertTo.TabIndex = 4;
            this.btnConvertTo.Text = "<";
            this.btnConvertTo.UseVisualStyleBackColor = true;
            this.btnConvertTo.Click += new System.EventHandler(this.btnConvertTo_Click);
            // 
            // tbValue2
            // 
            this.tbValue2.Location = new System.Drawing.Point(404, 87);
            this.tbValue2.Name = "tbValue2";
            this.tbValue2.Size = new System.Drawing.Size(100, 22);
            this.tbValue2.TabIndex = 5;
            // 
            // tbValue1
            // 
            this.tbValue1.Location = new System.Drawing.Point(130, 87);
            this.tbValue1.Name = "tbValue1";
            this.tbValue1.Size = new System.Drawing.Size(100, 22);
            this.tbValue1.TabIndex = 6;
            // 
            // nmudExchangeValue
            // 
            this.nmudExchangeValue.DecimalPlaces = 2;
            this.nmudExchangeValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nmudExchangeValue.Location = new System.Drawing.Point(323, 133);
            this.nmudExchangeValue.Name = "nmudExchangeValue";
            this.nmudExchangeValue.Size = new System.Drawing.Size(120, 22);
            this.nmudExchangeValue.TabIndex = 7;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(521, 181);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(101, 36);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Made by";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // cbToCurrency
            // 
            this.cbToCurrency.FormattingEnabled = true;
            this.cbToCurrency.Location = new System.Drawing.Point(510, 15);
            this.cbToCurrency.Name = "cbToCurrency";
            this.cbToCurrency.Size = new System.Drawing.Size(112, 24);
            this.cbToCurrency.TabIndex = 9;
            // 
            // cbFromCurrency
            // 
            this.cbFromCurrency.FormattingEnabled = true;
            this.cbFromCurrency.Location = new System.Drawing.Point(12, 15);
            this.cbFromCurrency.Name = "cbFromCurrency";
            this.cbFromCurrency.Size = new System.Drawing.Size(112, 24);
            this.cbFromCurrency.TabIndex = 10;
            // 
            // lbCurrencySign
            // 
            this.lbCurrencySign.AutoSize = true;
            this.lbCurrencySign.Location = new System.Drawing.Point(301, 135);
            this.lbCurrencySign.Name = "lbCurrencySign";
            this.lbCurrencySign.Size = new System.Drawing.Size(16, 17);
            this.lbCurrencySign.TabIndex = 11;
            this.lbCurrencySign.Text = "$";
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 232);
            this.Controls.Add(this.lbCurrencySign);
            this.Controls.Add(this.cbFromCurrency);
            this.Controls.Add(this.cbToCurrency);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.nmudExchangeValue);
            this.Controls.Add(this.tbValue1);
            this.Controls.Add(this.tbValue2);
            this.Controls.Add(this.btnConvertTo);
            this.Controls.Add(this.btnConvertFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CurrencyForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudExchangeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertFrom;
        private System.Windows.Forms.Button btnConvertTo;
        private System.Windows.Forms.TextBox tbValue2;
        private System.Windows.Forms.TextBox tbValue1;
        private System.Windows.Forms.NumericUpDown nmudExchangeValue;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ComboBox cbToCurrency;
        private System.Windows.Forms.ComboBox cbFromCurrency;
        private System.Windows.Forms.Label lbCurrencySign;
    }
}

