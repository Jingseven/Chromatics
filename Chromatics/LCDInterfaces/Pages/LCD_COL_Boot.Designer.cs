﻿namespace Chromatics.LCDInterfaces
{
    partial class LCD_COL_Boot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pB_logo1 = new System.Windows.Forms.PictureBox();
            this.lbl_boot_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_logo1
            // 
            this.pB_logo1.BackColor = System.Drawing.Color.Transparent;
            this.pB_logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pB_logo1.Image = global::Chromatics.Properties.Resources.chromatics_white_sm;
            this.pB_logo1.InitialImage = global::Chromatics.Properties.Resources.chromatics_white_sm;
            this.pB_logo1.Location = new System.Drawing.Point(15, 15);
            this.pB_logo1.Name = "pB_logo1";
            this.pB_logo1.Size = new System.Drawing.Size(292, 140);
            this.pB_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_logo1.TabIndex = 3;
            this.pB_logo1.TabStop = false;
            // 
            // lbl_boot_txt
            // 
            this.lbl_boot_txt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_boot_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_boot_txt.ForeColor = System.Drawing.Color.White;
            this.lbl_boot_txt.Location = new System.Drawing.Point(40, 153);
            this.lbl_boot_txt.Name = "lbl_boot_txt";
            this.lbl_boot_txt.Size = new System.Drawing.Size(243, 56);
            this.lbl_boot_txt.TabIndex = 4;
            this.lbl_boot_txt.Text = "Loading";
            this.lbl_boot_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LCD_COL_Boot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pB_logo1);
            this.Controls.Add(this.lbl_boot_txt);
            this.Name = "LCD_COL_Boot";
            this.Size = new System.Drawing.Size(320, 220);
            ((System.ComponentModel.ISupportInitialize)(this.pB_logo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_logo1;
        private System.Windows.Forms.Label lbl_boot_txt;
    }
}
