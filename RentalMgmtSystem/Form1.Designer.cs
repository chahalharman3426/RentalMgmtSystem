namespace RentalMgmtSystem
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
            this.btn_customerMaster = new System.Windows.Forms.Button();
            this.btn_videoMaster = new System.Windows.Forms.Button();
            this.btn_rentalVideo = new System.Windows.Forms.Button();
            this.btn_mostRentalCustomeList = new System.Windows.Forms.Button();
            this.btn_popularVideoList = new System.Windows.Forms.Button();
            this.btn_returnVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_customerMaster
            // 
            this.btn_customerMaster.BackColor = System.Drawing.Color.DarkRed;
            this.btn_customerMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerMaster.ForeColor = System.Drawing.Color.White;
            this.btn_customerMaster.Location = new System.Drawing.Point(84, 165);
            this.btn_customerMaster.Name = "btn_customerMaster";
            this.btn_customerMaster.Size = new System.Drawing.Size(253, 86);
            this.btn_customerMaster.TabIndex = 0;
            this.btn_customerMaster.Text = "Customer Master";
            this.btn_customerMaster.UseVisualStyleBackColor = false;
            this.btn_customerMaster.Click += new System.EventHandler(this.btn_customerMaster_Click);
            // 
            // btn_videoMaster
            // 
            this.btn_videoMaster.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_videoMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_videoMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_videoMaster.ForeColor = System.Drawing.Color.White;
            this.btn_videoMaster.Location = new System.Drawing.Point(337, 165);
            this.btn_videoMaster.Name = "btn_videoMaster";
            this.btn_videoMaster.Size = new System.Drawing.Size(253, 86);
            this.btn_videoMaster.TabIndex = 1;
            this.btn_videoMaster.Text = "Video Master";
            this.btn_videoMaster.UseVisualStyleBackColor = false;
            this.btn_videoMaster.Click += new System.EventHandler(this.btn_videoMaster_Click);
            // 
            // btn_rentalVideo
            // 
            this.btn_rentalVideo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_rentalVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rentalVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rentalVideo.ForeColor = System.Drawing.Color.White;
            this.btn_rentalVideo.Location = new System.Drawing.Point(590, 165);
            this.btn_rentalVideo.Name = "btn_rentalVideo";
            this.btn_rentalVideo.Size = new System.Drawing.Size(138, 172);
            this.btn_rentalVideo.TabIndex = 2;
            this.btn_rentalVideo.Text = "Rental Video";
            this.btn_rentalVideo.UseVisualStyleBackColor = false;
            this.btn_rentalVideo.Click += new System.EventHandler(this.btn_rentalVideo_Click);
            // 
            // btn_mostRentalCustomeList
            // 
            this.btn_mostRentalCustomeList.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_mostRentalCustomeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostRentalCustomeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostRentalCustomeList.ForeColor = System.Drawing.Color.White;
            this.btn_mostRentalCustomeList.Location = new System.Drawing.Point(84, 251);
            this.btn_mostRentalCustomeList.Name = "btn_mostRentalCustomeList";
            this.btn_mostRentalCustomeList.Size = new System.Drawing.Size(253, 174);
            this.btn_mostRentalCustomeList.TabIndex = 3;
            this.btn_mostRentalCustomeList.Text = "Most Rental Customer List";
            this.btn_mostRentalCustomeList.UseVisualStyleBackColor = false;
            this.btn_mostRentalCustomeList.Click += new System.EventHandler(this.btn_mostRentalCustomeList_Click);
            // 
            // btn_popularVideoList
            // 
            this.btn_popularVideoList.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_popularVideoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_popularVideoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_popularVideoList.ForeColor = System.Drawing.Color.White;
            this.btn_popularVideoList.Location = new System.Drawing.Point(337, 251);
            this.btn_popularVideoList.Name = "btn_popularVideoList";
            this.btn_popularVideoList.Size = new System.Drawing.Size(253, 86);
            this.btn_popularVideoList.TabIndex = 4;
            this.btn_popularVideoList.Text = "Popular Video\'s List";
            this.btn_popularVideoList.UseVisualStyleBackColor = false;
            this.btn_popularVideoList.Click += new System.EventHandler(this.btn_popularVideoList_Click);
            // 
            // btn_returnVideo
            // 
            this.btn_returnVideo.BackColor = System.Drawing.Color.Crimson;
            this.btn_returnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_returnVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnVideo.ForeColor = System.Drawing.Color.White;
            this.btn_returnVideo.Location = new System.Drawing.Point(338, 338);
            this.btn_returnVideo.Name = "btn_returnVideo";
            this.btn_returnVideo.Size = new System.Drawing.Size(390, 86);
            this.btn_returnVideo.TabIndex = 5;
            this.btn_returnVideo.Text = "ReturnVideo";
            this.btn_returnVideo.UseVisualStyleBackColor = false;
            this.btn_returnVideo.Click += new System.EventHandler(this.btn_returnVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Video Rental Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentalMgmtSystem.Properties.Resources._140870431_dark_black_galaxy_star;
            this.ClientSize = new System.Drawing.Size(838, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_returnVideo);
            this.Controls.Add(this.btn_popularVideoList);
            this.Controls.Add(this.btn_mostRentalCustomeList);
            this.Controls.Add(this.btn_rentalVideo);
            this.Controls.Add(this.btn_videoMaster);
            this.Controls.Add(this.btn_customerMaster);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_customerMaster;
        private System.Windows.Forms.Button btn_videoMaster;
        private System.Windows.Forms.Button btn_rentalVideo;
        private System.Windows.Forms.Button btn_mostRentalCustomeList;
        private System.Windows.Forms.Button btn_popularVideoList;
        private System.Windows.Forms.Button btn_returnVideo;
        private System.Windows.Forms.Label label1;
    }
}

