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
            this.lbFamily = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTrouble = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.nudWeekDays = new System.Windows.Forms.NumericUpDown();
            this.lbGoAway = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGoodMorning = new System.Windows.Forms.Button();
            this.btnGoodNight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeekDays)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFamily
            // 
            this.lbFamily.FormattingEnabled = true;
            this.lbFamily.ItemHeight = 16;
            this.lbFamily.Location = new System.Drawing.Point(3, 37);
            this.lbFamily.Name = "lbFamily";
            this.lbFamily.Size = new System.Drawing.Size(145, 116);
            this.lbFamily.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Family:";
            // 
            // lbTrouble
            // 
            this.lbTrouble.AutoSize = true;
            this.lbTrouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrouble.Location = new System.Drawing.Point(611, 97);
            this.lbTrouble.Name = "lbTrouble";
            this.lbTrouble.Size = new System.Drawing.Size(97, 17);
            this.lbTrouble.TabIndex = 2;
            this.lbTrouble.Text = "Empty Label";
            this.lbTrouble.Visible = false;
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(363, 95);
            this.nudHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(120, 22);
            this.nudHours.TabIndex = 3;
            this.nudHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudWeekDays
            // 
            this.nudWeekDays.Location = new System.Drawing.Point(363, 58);
            this.nudWeekDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudWeekDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeekDays.Name = "nudWeekDays";
            this.nudWeekDays.Size = new System.Drawing.Size(120, 22);
            this.nudWeekDays.TabIndex = 4;
            this.nudWeekDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbGoAway
            // 
            this.lbGoAway.AutoSize = true;
            this.lbGoAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoAway.Location = new System.Drawing.Point(611, 60);
            this.lbGoAway.Name = "lbGoAway";
            this.lbGoAway.Size = new System.Drawing.Size(97, 17);
            this.lbGoAway.TabIndex = 5;
            this.lbGoAway.Text = "Empty Label";
            this.lbGoAway.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours ( 1, 2, 3 ..... 24) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Day of the week (1 ,2 ,3 .... 7) :";
            // 
            // btnGoodMorning
            // 
            this.btnGoodMorning.Location = new System.Drawing.Point(489, 50);
            this.btnGoodMorning.Name = "btnGoodMorning";
            this.btnGoodMorning.Size = new System.Drawing.Size(116, 37);
            this.btnGoodMorning.TabIndex = 9;
            this.btnGoodMorning.Text = "Good Morning";
            this.btnGoodMorning.UseVisualStyleBackColor = true;
            this.btnGoodMorning.Click += new System.EventHandler(this.btnGoodMorning_Click);
            // 
            // btnGoodNight
            // 
            this.btnGoodNight.Location = new System.Drawing.Point(489, 87);
            this.btnGoodNight.Name = "btnGoodNight";
            this.btnGoodNight.Size = new System.Drawing.Size(116, 37);
            this.btnGoodNight.TabIndex = 10;
            this.btnGoodNight.Text = "Good Night";
            this.btnGoodNight.UseVisualStyleBackColor = true;
            this.btnGoodNight.Click += new System.EventHandler(this.btnGoodNight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 156);
            this.Controls.Add(this.btnGoodNight);
            this.Controls.Add(this.btnGoodMorning);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbGoAway);
            this.Controls.Add(this.nudWeekDays);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.lbTrouble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFamily);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeekDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTrouble;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.NumericUpDown nudWeekDays;
        private System.Windows.Forms.Label lbGoAway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGoodMorning;
        private System.Windows.Forms.Button btnGoodNight;
    }
}

