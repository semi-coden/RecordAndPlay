﻿namespace RecordAndPlay
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
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            Form1.textBox1 = new System.Windows.Forms.TextBox();
            Form1.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnStop);
            this.btnPanel.Controls.Add(this.btnPlay);
            this.btnPanel.Controls.Add(this.btnRecord);
            this.btnPanel.Location = new System.Drawing.Point(51, 32);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(530, 105);
            this.btnPanel.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(221, 34);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 38);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(396, 34);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(104, 38);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(31, 31);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(105, 41);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // textBox1
            // 
            Form1.textBox1.Location = new System.Drawing.Point(51, 191);
            Form1.textBox1.Multiline = true;
            Form1.textBox1.Name = "textBox1";
            Form1.textBox1.Size = new System.Drawing.Size(260, 542);
            Form1.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            Form1.textBox2.Location = new System.Drawing.Point(317, 191);
            Form1.textBox2.Multiline = true;
            Form1.textBox2.Name = "textBox2";
            Form1.textBox2.Size = new System.Drawing.Size(264, 542);
            Form1.textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 766);
            this.Controls.Add(Form1.textBox2);
            this.Controls.Add(Form1.textBox1);
            this.Controls.Add(this.btnPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnStop;
        public static System.Windows.Forms.TextBox textBox1;
        public static System.Windows.Forms.TextBox textBox2;
    }
}

