﻿namespace Датамер
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RefreshEnterYear = new System.Windows.Forms.Button();
            this.TextBoxNowMinute = new System.Windows.Forms.TextBox();
            this.TextBoxNowSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNowHour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxNowMonth = new System.Windows.Forms.TextBox();
            this.TextBoxNowYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxNowDay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxEnterMonth = new System.Windows.Forms.TextBox();
            this.TextBoxEnterDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxEnterSecond = new System.Windows.Forms.TextBox();
            this.TextBoxEnterMinute = new System.Windows.Forms.TextBox();
            this.TextBoxEnterHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxEnterYear = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RefreshEnterYear
            // 
            this.RefreshEnterYear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefreshEnterYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshEnterYear.Location = new System.Drawing.Point(12, 212);
            this.RefreshEnterYear.Name = "RefreshEnterYear";
            this.RefreshEnterYear.Size = new System.Drawing.Size(311, 56);
            this.RefreshEnterYear.TabIndex = 75;
            this.RefreshEnterYear.Text = "Обновить дату отчёта";
            this.RefreshEnterYear.UseVisualStyleBackColor = false;
            this.RefreshEnterYear.Click += new System.EventHandler(this.RefreshEnterYear_Click);
            // 
            // TextBoxNowMinute
            // 
            this.TextBoxNowMinute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxNowMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNowMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNowMinute.Location = new System.Drawing.Point(583, 116);
            this.TextBoxNowMinute.Name = "TextBoxNowMinute";
            this.TextBoxNowMinute.ReadOnly = true;
            this.TextBoxNowMinute.Size = new System.Drawing.Size(54, 55);
            this.TextBoxNowMinute.TabIndex = 72;
            this.TextBoxNowMinute.TabStop = false;
            this.TextBoxNowMinute.Text = "00";
            // 
            // TextBoxNowSecond
            // 
            this.TextBoxNowSecond.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxNowSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNowSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNowSecond.Location = new System.Drawing.Point(643, 116);
            this.TextBoxNowSecond.Name = "TextBoxNowSecond";
            this.TextBoxNowSecond.ReadOnly = true;
            this.TextBoxNowSecond.Size = new System.Drawing.Size(54, 55);
            this.TextBoxNowSecond.TabIndex = 74;
            this.TextBoxNowSecond.TabStop = false;
            this.TextBoxNowSecond.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(623, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 55);
            this.label2.TabIndex = 73;
            this.label2.Text = ":";
            // 
            // TextBoxNowHour
            // 
            this.TextBoxNowHour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxNowHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNowHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNowHour.Location = new System.Drawing.Point(520, 116);
            this.TextBoxNowHour.Name = "TextBoxNowHour";
            this.TextBoxNowHour.ReadOnly = true;
            this.TextBoxNowHour.Size = new System.Drawing.Size(54, 55);
            this.TextBoxNowHour.TabIndex = 70;
            this.TextBoxNowHour.TabStop = false;
            this.TextBoxNowHour.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(562, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 55);
            this.label8.TabIndex = 71;
            this.label8.Text = ":";
            // 
            // TextBoxNowMonth
            // 
            this.TextBoxNowMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxNowMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNowMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNowMonth.Location = new System.Drawing.Point(555, 60);
            this.TextBoxNowMonth.Name = "TextBoxNowMonth";
            this.TextBoxNowMonth.ReadOnly = true;
            this.TextBoxNowMonth.Size = new System.Drawing.Size(54, 55);
            this.TextBoxNowMonth.TabIndex = 67;
            this.TextBoxNowMonth.TabStop = false;
            this.TextBoxNowMonth.Text = "00";
            // 
            // TextBoxNowYear
            // 
            this.TextBoxNowYear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxNowYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNowYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNowYear.Location = new System.Drawing.Point(622, 60);
            this.TextBoxNowYear.Name = "TextBoxNowYear";
            this.TextBoxNowYear.ReadOnly = true;
            this.TextBoxNowYear.Size = new System.Drawing.Size(109, 55);
            this.TextBoxNowYear.TabIndex = 69;
            this.TextBoxNowYear.TabStop = false;
            this.TextBoxNowYear.Text = "0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(599, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 55);
            this.label9.TabIndex = 68;
            this.label9.Text = ".";
            // 
            // TextBoxNowDay
            // 
            this.TextBoxNowDay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxNowDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNowDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNowDay.Location = new System.Drawing.Point(492, 60);
            this.TextBoxNowDay.Name = "TextBoxNowDay";
            this.TextBoxNowDay.ReadOnly = true;
            this.TextBoxNowDay.Size = new System.Drawing.Size(54, 55);
            this.TextBoxNowDay.TabIndex = 65;
            this.TextBoxNowDay.TabStop = false;
            this.TextBoxNowDay.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(534, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 55);
            this.label11.TabIndex = 66;
            this.label11.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(543, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 37);
            this.label10.TabIndex = 64;
            this.label10.Text = "Сейчас";
            // 
            // TextBoxEnterMonth
            // 
            this.TextBoxEnterMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxEnterMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEnterMonth.Location = new System.Drawing.Point(105, 63);
            this.TextBoxEnterMonth.MaxLength = 2;
            this.TextBoxEnterMonth.Name = "TextBoxEnterMonth";
            this.TextBoxEnterMonth.Size = new System.Drawing.Size(61, 62);
            this.TextBoxEnterMonth.TabIndex = 47;
            this.TextBoxEnterMonth.Text = "00";
            // 
            // TextBoxEnterDay
            // 
            this.TextBoxEnterDay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxEnterDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEnterDay.Location = new System.Drawing.Point(38, 63);
            this.TextBoxEnterDay.MaxLength = 2;
            this.TextBoxEnterDay.Name = "TextBoxEnterDay";
            this.TextBoxEnterDay.Size = new System.Drawing.Size(61, 62);
            this.TextBoxEnterDay.TabIndex = 46;
            this.TextBoxEnterDay.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 55;
            this.label4.Text = "Прошло";
            // 
            // TextBoxEnterSecond
            // 
            this.TextBoxEnterSecond.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxEnterSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEnterSecond.Location = new System.Drawing.Point(202, 129);
            this.TextBoxEnterSecond.MaxLength = 2;
            this.TextBoxEnterSecond.Name = "TextBoxEnterSecond";
            this.TextBoxEnterSecond.Size = new System.Drawing.Size(61, 62);
            this.TextBoxEnterSecond.TabIndex = 52;
            this.TextBoxEnterSecond.Text = "00";
            // 
            // TextBoxEnterMinute
            // 
            this.TextBoxEnterMinute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxEnterMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEnterMinute.Location = new System.Drawing.Point(135, 129);
            this.TextBoxEnterMinute.MaxLength = 2;
            this.TextBoxEnterMinute.Name = "TextBoxEnterMinute";
            this.TextBoxEnterMinute.Size = new System.Drawing.Size(61, 62);
            this.TextBoxEnterMinute.TabIndex = 51;
            this.TextBoxEnterMinute.Text = "00";
            // 
            // TextBoxEnterHour
            // 
            this.TextBoxEnterHour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxEnterHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEnterHour.Location = new System.Drawing.Point(68, 129);
            this.TextBoxEnterHour.MaxLength = 2;
            this.TextBoxEnterHour.Name = "TextBoxEnterHour";
            this.TextBoxEnterHour.Size = new System.Drawing.Size(61, 62);
            this.TextBoxEnterHour.TabIndex = 50;
            this.TextBoxEnterHour.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 37);
            this.label1.TabIndex = 49;
            this.label1.Text = "Дата отчета";
            // 
            // TextBoxEnterYear
            // 
            this.TextBoxEnterYear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxEnterYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEnterYear.Location = new System.Drawing.Point(172, 63);
            this.TextBoxEnterYear.MaxLength = 4;
            this.TextBoxEnterYear.Name = "TextBoxEnterYear";
            this.TextBoxEnterYear.Size = new System.Drawing.Size(115, 62);
            this.TextBoxEnterYear.TabIndex = 48;
            this.TextBoxEnterYear.Text = "0000";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LabelLast
            // 
            this.LabelLast.AutoSize = true;
            this.LabelLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLast.Location = new System.Drawing.Point(12, 424);
            this.LabelLast.Name = "LabelLast";
            this.LabelLast.Size = new System.Drawing.Size(36, 39);
            this.LabelLast.TabIndex = 76;
            this.LabelLast.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 470);
            this.Controls.Add(this.LabelLast);
            this.Controls.Add(this.RefreshEnterYear);
            this.Controls.Add(this.TextBoxNowMinute);
            this.Controls.Add(this.TextBoxNowSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNowHour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxNowMonth);
            this.Controls.Add(this.TextBoxNowYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxNowDay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxEnterMonth);
            this.Controls.Add(this.TextBoxEnterDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxEnterSecond);
            this.Controls.Add(this.TextBoxEnterMinute);
            this.Controls.Add(this.TextBoxEnterHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxEnterYear);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Датамер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshEnterYear;
        private System.Windows.Forms.TextBox TextBoxNowMinute;
        private System.Windows.Forms.TextBox TextBoxNowSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNowHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxNowMonth;
        private System.Windows.Forms.TextBox TextBoxNowYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxNowDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxEnterMonth;
        private System.Windows.Forms.TextBox TextBoxEnterDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxEnterSecond;
        private System.Windows.Forms.TextBox TextBoxEnterMinute;
        private System.Windows.Forms.TextBox TextBoxEnterHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxEnterYear;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelLast;
    }
}

