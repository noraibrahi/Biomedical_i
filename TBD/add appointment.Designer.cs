﻿namespace TBD
{
    partial class add_appointment
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(18, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 46);
            this.panel1.TabIndex = 42;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(662, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 45);
            this.button4.TabIndex = 43;
            this.button4.Text = "add patient";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 46);
            this.button3.TabIndex = 42;
            this.button3.Text = "add doctor";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 45);
            this.button2.TabIndex = 41;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Location = new System.Drawing.Point(295, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 43);
            this.label9.TabIndex = 41;
            this.label9.Text = "ADD APOINTMENT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // add_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_appointment";
            this.Text = "add_appointment";
            this.Load += new System.EventHandler(this.add_appointment_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}