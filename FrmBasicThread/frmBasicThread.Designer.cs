﻿namespace FrmBasicThread
{
    partial class FrmBasicThread
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
            this.lblThread = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread.ForeColor = System.Drawing.Color.Black;
            this.lblThread.Location = new System.Drawing.Point(91, 64);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(237, 24);
            this.lblThread.TabIndex = 1;
            this.lblThread.Text = "* before starting thread *";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnRun.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(105, 95);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(146, 42);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // FrmBasicThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(362, 206);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblThread);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBasicThread";
            this.Text = "Basic Thread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.Button btnRun;
    }
}

