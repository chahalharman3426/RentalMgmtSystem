namespace RentalMgmtSystem
{
    partial class frmRenturnVideo
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
            this.btn_ReturnVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentedMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 46);
            this.label1.TabIndex = 46;
            this.label1.Text = "Return Video";
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
            this.gridRentedMovie.Location = new System.Drawing.Point(29, 139);
            this.gridRentedMovie.Name = "gridRentedMovie";
            this.gridRentedMovie.ReadOnly = true;
            this.gridRentedMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRentedMovie.Size = new System.Drawing.Size(975, 332);
            this.gridRentedMovie.TabIndex = 67;
            this.gridRentedMovie.Click += new System.EventHandler(this.gridRentedMovie_Click);
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
            // btn_ReturnVideo
            // 
            this.btn_ReturnVideo.BackColor = System.Drawing.Color.Crimson;
            this.btn_ReturnVideo.CausesValidation = false;
            this.btn_ReturnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReturnVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnVideo.ForeColor = System.Drawing.Color.White;
            this.btn_ReturnVideo.Location = new System.Drawing.Point(29, 96);
            this.btn_ReturnVideo.Name = "btn_ReturnVideo";
            this.btn_ReturnVideo.Size = new System.Drawing.Size(154, 37);
            this.btn_ReturnVideo.TabIndex = 68;
            this.btn_ReturnVideo.Text = "Return Video";
            this.btn_ReturnVideo.UseVisualStyleBackColor = false;
            this.btn_ReturnVideo.Click += new System.EventHandler(this.btn_ReturnVideo_Click);
            // 
            // frmRenturnVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1016, 526);
            this.Controls.Add(this.btn_ReturnVideo);
            this.Controls.Add(this.gridRentedMovie);
            this.Controls.Add(this.label1);
            this.Name = "frmRenturnVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenturnVideo";
            this.Load += new System.EventHandler(this.frmRenturnVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRentedMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btn_ReturnVideo;
    }
}