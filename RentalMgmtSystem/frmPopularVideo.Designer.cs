﻿namespace RentalMgmtSystem
{
    partial class frmPopularVideo
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridPopularVideo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 46);
            this.label1.TabIndex = 48;
            this.label1.Text = "Popular Video\'s List";
            // 
            // gridPopularVideo
            // 
            this.gridPopularVideo.AllowUserToAddRows = false;
            this.gridPopularVideo.AllowUserToDeleteRows = false;
            this.gridPopularVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopularVideo.Location = new System.Drawing.Point(132, 112);
            this.gridPopularVideo.Name = "gridPopularVideo";
            this.gridPopularVideo.ReadOnly = true;
            this.gridPopularVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPopularVideo.Size = new System.Drawing.Size(556, 293);
            this.gridPopularVideo.TabIndex = 49;
            // 
            // frmPopularVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridPopularVideo);
            this.Controls.Add(this.label1);
            this.Name = "frmPopularVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopularVideo";
            this.Load += new System.EventHandler(this.frmPopularVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPopularVideo;
    }
}