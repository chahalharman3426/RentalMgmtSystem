namespace RentalMgmtSystem
{
    partial class frmRentalVideo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_RentedDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_selectVideo = new System.Windows.Forms.ComboBox();
            this.cmb_selectCustomer = new System.Windows.Forms.ComboBox();
            this.btn_videoBack = new System.Windows.Forms.Button();
            this.btn_rentalVideo = new System.Windows.Forms.Button();
            this.gridRentedMovie = new System.Windows.Forms.DataGridView();
            this.RMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentedMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 46);
            this.label1.TabIndex = 45;
            this.label1.Text = "Video On Rental";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Select Video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Rental Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Select Customer";
            // 
            // dtp_RentedDate
            // 
            this.dtp_RentedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtp_RentedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_RentedDate.Location = new System.Drawing.Point(279, 222);
            this.dtp_RentedDate.Name = "dtp_RentedDate";
            this.dtp_RentedDate.Size = new System.Drawing.Size(230, 20);
            this.dtp_RentedDate.TabIndex = 63;
            // 
            // cmb_selectVideo
            // 
            this.cmb_selectVideo.FormattingEnabled = true;
            this.cmb_selectVideo.Location = new System.Drawing.Point(279, 173);
            this.cmb_selectVideo.Name = "cmb_selectVideo";
            this.cmb_selectVideo.Size = new System.Drawing.Size(230, 21);
            this.cmb_selectVideo.TabIndex = 62;
            // 
            // cmb_selectCustomer
            // 
            this.cmb_selectCustomer.FormattingEnabled = true;
            this.cmb_selectCustomer.Location = new System.Drawing.Point(279, 121);
            this.cmb_selectCustomer.Name = "cmb_selectCustomer";
            this.cmb_selectCustomer.Size = new System.Drawing.Size(230, 21);
            this.cmb_selectCustomer.TabIndex = 61;
            // 
            // btn_videoBack
            // 
            this.btn_videoBack.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_videoBack.CausesValidation = false;
            this.btn_videoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_videoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_videoBack.ForeColor = System.Drawing.Color.White;
            this.btn_videoBack.Location = new System.Drawing.Point(414, 283);
            this.btn_videoBack.Name = "btn_videoBack";
            this.btn_videoBack.Size = new System.Drawing.Size(95, 64);
            this.btn_videoBack.TabIndex = 65;
            this.btn_videoBack.Text = "<<Back";
            this.btn_videoBack.UseVisualStyleBackColor = false;
            this.btn_videoBack.Click += new System.EventHandler(this.btn_videoBack_Click);
            // 
            // btn_rentalVideo
            // 
            this.btn_rentalVideo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_rentalVideo.CausesValidation = false;
            this.btn_rentalVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rentalVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rentalVideo.ForeColor = System.Drawing.Color.White;
            this.btn_rentalVideo.Location = new System.Drawing.Point(279, 283);
            this.btn_rentalVideo.Name = "btn_rentalVideo";
            this.btn_rentalVideo.Size = new System.Drawing.Size(107, 64);
            this.btn_rentalVideo.TabIndex = 64;
            this.btn_rentalVideo.Text = "Save Rental";
            this.btn_rentalVideo.UseVisualStyleBackColor = false;
            this.btn_rentalVideo.Click += new System.EventHandler(this.btn_rentalVideo_Click);
            // 
            // gridRentedMovie
            // 
            this.gridRentedMovie.AllowUserToAddRows = false;
            this.gridRentedMovie.AllowUserToDeleteRows = false;
            this.gridRentedMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRentedMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMID,
            this.CustId,
            this.FirstName,
            this.Address,
            this.Phone,
            this.MovieId,
            this.Title,
            this.ReleaseDate,
            this.RentalCost,
            this.Genre,
            this.DateRented,
            this.DateReturned});
            this.gridRentedMovie.Location = new System.Drawing.Point(12, 385);
            this.gridRentedMovie.Name = "gridRentedMovie";
            this.gridRentedMovie.ReadOnly = true;
            this.gridRentedMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRentedMovie.Size = new System.Drawing.Size(975, 332);
            this.gridRentedMovie.TabIndex = 66;
            // 
            // RMID
            // 
            this.RMID.DataPropertyName = "rentalVideoId";
            this.RMID.HeaderText = "RMID";
            this.RMID.Name = "RMID";
            this.RMID.ReadOnly = true;
            this.RMID.Width = 50;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "customer_id";
            this.CustId.HeaderText = "CustId";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            this.CustId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "name";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "mobile_no";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "video_id";
            this.MovieId.HeaderText = "VideoId";
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "video_title";
            this.Title.HeaderText = "Video Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "releaseDate";
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Visible = false;
            // 
            // RentalCost
            // 
            this.RentalCost.DataPropertyName = "rental_cost";
            this.RentalCost.HeaderText = "Rental Cost";
            this.RentalCost.Name = "RentalCost";
            this.RentalCost.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Visible = false;
            // 
            // DateRented
            // 
            this.DateRented.DataPropertyName = "rentalDate";
            this.DateRented.HeaderText = "Date Rented";
            this.DateRented.Name = "DateRented";
            this.DateRented.ReadOnly = true;
            this.DateRented.Width = 150;
            // 
            // DateReturned
            // 
            this.DateReturned.DataPropertyName = "returnDate";
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            this.DateReturned.Width = 150;
            // 
            // frmRentalVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1016, 729);
            this.Controls.Add(this.gridRentedMovie);
            this.Controls.Add(this.btn_videoBack);
            this.Controls.Add(this.btn_rentalVideo);
            this.Controls.Add(this.dtp_RentedDate);
            this.Controls.Add(this.cmb_selectVideo);
            this.Controls.Add(this.cmb_selectCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRentalVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRentalVideo";
            this.Load += new System.EventHandler(this.frmRentalVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRentedMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_RentedDate;
        private System.Windows.Forms.ComboBox cmb_selectVideo;
        private System.Windows.Forms.ComboBox cmb_selectCustomer;
        private System.Windows.Forms.Button btn_videoBack;
        private System.Windows.Forms.Button btn_rentalVideo;
        private System.Windows.Forms.DataGridView gridRentedMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
    }
}