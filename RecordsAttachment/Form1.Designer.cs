﻿namespace RecordsAttachment
{
    partial class Frm_Main
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
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Prg_Attach = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Brows = new System.Windows.Forms.Button();
            this.Txt_FileAddrress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackColor = System.Drawing.Color.Silver;
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Start.Location = new System.Drawing.Point(30, 23);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(109, 72);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Prg_Attach
            // 
            this.Prg_Attach.Location = new System.Drawing.Point(30, 129);
            this.Prg_Attach.Name = "Prg_Attach";
            this.Prg_Attach.Size = new System.Drawing.Size(650, 23);
            this.Prg_Attach.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Brows
            // 
            this.Brows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Brows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Brows.Location = new System.Drawing.Point(224, 47);
            this.Brows.Name = "Brows";
            this.Brows.Size = new System.Drawing.Size(75, 23);
            this.Brows.TabIndex = 2;
            this.Brows.Text = "Brows";
            this.Brows.UseVisualStyleBackColor = true;
            this.Brows.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_FileAddrress
            // 
            this.Txt_FileAddrress.Location = new System.Drawing.Point(301, 49);
            this.Txt_FileAddrress.Name = "Txt_FileAddrress";
            this.Txt_FileAddrress.Size = new System.Drawing.Size(296, 20);
            this.Txt_FileAddrress.TabIndex = 3;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 190);
            this.Controls.Add(this.Txt_FileAddrress);
            this.Controls.Add(this.Brows);
            this.Controls.Add(this.Prg_Attach);
            this.Controls.Add(this.Btn_Start);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.Text = "Record Attachment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.ProgressBar Prg_Attach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Brows;
        private System.Windows.Forms.TextBox Txt_FileAddrress;
    }
}
