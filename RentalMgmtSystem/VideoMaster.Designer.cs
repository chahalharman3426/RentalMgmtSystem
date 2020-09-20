namespace RentalMgmtSystem
{
    partial class VideoMaster
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
            this.btn_videoBack = new System.Windows.Forms.Button();
            this.grid_VideoMaster = new System.Windows.Forms.DataGridView();
            this.btn_videoDelete = new System.Windows.Forms.Button();
            this.btn_videoEdit = new System.Windows.Forms.Button();
            this.btn_videoAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_rentalCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_videoTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_releaseDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_VideoMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_videoBack
            // 
            this.btn_videoBack.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_videoBack.CausesValidation = false;
            this.btn_videoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_videoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_videoBack.ForeColor = System.Drawing.Color.White;
            this.btn_videoBack.Location = new System.Drawing.Point(387, 389);
            this.btn_videoBack.Name = "btn_videoBack";
            this.btn_videoBack.Size = new System.Drawing.Size(95, 37);
            this.btn_videoBack.TabIndex = 55;
            this.btn_videoBack.Text = "<<Back";
            this.btn_videoBack.UseVisualStyleBackColor = false;
            this.btn_videoBack.Click += new System.EventHandler(this.btn_videoBack_Click);
            // 
            // grid_VideoMaster
            // 
            this.grid_VideoMaster.AllowUserToAddRows = false;
            this.grid_VideoMaster.AllowUserToDeleteRows = false;
            this.grid_VideoMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_VideoMaster.Location = new System.Drawing.Point(410, 116);
            this.grid_VideoMaster.Name = "grid_VideoMaster";
            this.grid_VideoMaster.ReadOnly = true;
            this.grid_VideoMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_VideoMaster.Size = new System.Drawing.Size(610, 262);
            this.grid_VideoMaster.TabIndex = 54;
            this.grid_VideoMaster.Click += new System.EventHandler(this.grid_VideoMaster_Click);
            // 
            // btn_videoDelete
            // 
            this.btn_videoDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_videoDelete.CausesValidation = false;
            this.btn_videoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_videoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_videoDelete.ForeColor = System.Drawing.Color.White;
            this.btn_videoDelete.Location = new System.Drawing.Point(282, 389);
            this.btn_videoDelete.Name = "btn_videoDelete";
            this.btn_videoDelete.Size = new System.Drawing.Size(86, 37);
            this.btn_videoDelete.TabIndex = 53;
            this.btn_videoDelete.Text = "Delete";
            this.btn_videoDelete.UseVisualStyleBackColor = false;
            this.btn_videoDelete.Click += new System.EventHandler(this.btn_videoDelete_Click);
            // 
            // btn_videoEdit
            // 
            this.btn_videoEdit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_videoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_videoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_videoEdit.ForeColor = System.Drawing.Color.White;
            this.btn_videoEdit.Location = new System.Drawing.Point(173, 389);
            this.btn_videoEdit.Name = "btn_videoEdit";
            this.btn_videoEdit.Size = new System.Drawing.Size(91, 37);
            this.btn_videoEdit.TabIndex = 52;
            this.btn_videoEdit.Text = "Edit";
            this.btn_videoEdit.UseVisualStyleBackColor = false;
            this.btn_videoEdit.Click += new System.EventHandler(this.btn_videoEdit_Click);
            // 
            // btn_videoAdd
            // 
            this.btn_videoAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_videoAdd.CausesValidation = false;
            this.btn_videoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_videoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_videoAdd.ForeColor = System.Drawing.Color.White;
            this.btn_videoAdd.Location = new System.Drawing.Point(61, 389);
            this.btn_videoAdd.Name = "btn_videoAdd";
            this.btn_videoAdd.Size = new System.Drawing.Size(91, 37);
            this.btn_videoAdd.TabIndex = 51;
            this.btn_videoAdd.Text = "Add";
            this.btn_videoAdd.UseVisualStyleBackColor = false;
            this.btn_videoAdd.Click += new System.EventHandler(this.btn_videoAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Genre";
            // 
            // text_rentalCost
            // 
            this.text_rentalCost.Location = new System.Drawing.Point(164, 223);
            this.text_rentalCost.Name = "text_rentalCost";
            this.text_rentalCost.Size = new System.Drawing.Size(230, 20);
            this.text_rentalCost.TabIndex = 48;
            this.text_rentalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_rentalCost_KeyPress);
            this.text_rentalCost.Validating += new System.ComponentModel.CancelEventHandler(this.text_rentalCost_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Rental Cost";
            // 
            // text_videoTitle
            // 
            this.text_videoTitle.Location = new System.Drawing.Point(164, 121);
            this.text_videoTitle.Name = "text_videoTitle";
            this.text_videoTitle.Size = new System.Drawing.Size(230, 20);
            this.text_videoTitle.TabIndex = 46;
            this.text_videoTitle.Validating += new System.ComponentModel.CancelEventHandler(this.text_videoTitle_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Video Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 46);
            this.label1.TabIndex = 44;
            this.label1.Text = "Video Master";
            // 
            // dtp_releaseDate
            // 
            this.dtp_releaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtp_releaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_releaseDate.Location = new System.Drawing.Point(164, 174);
            this.dtp_releaseDate.Name = "dtp_releaseDate";
            this.dtp_releaseDate.Size = new System.Drawing.Size(230, 20);
            this.dtp_releaseDate.TabIndex = 56;
            this.dtp_releaseDate.ValueChanged += new System.EventHandler(this.dtp_releaseDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Release Date";
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Items.AddRange(new object[] {
            "Action",
            "Horror",
            "Comedy",
            "Drama",
            "Science Fiction",
            "Romance",
            "Animation",
            "Crime Film"});
            this.comboBox_genre.Location = new System.Drawing.Point(164, 262);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(230, 21);
            this.comboBox_genre.TabIndex = 58;
            this.comboBox_genre.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_genre_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // VideoMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_releaseDate);
            this.Controls.Add(this.btn_videoBack);
            this.Controls.Add(this.grid_VideoMaster);
            this.Controls.Add(this.btn_videoDelete);
            this.Controls.Add(this.btn_videoEdit);
            this.Controls.Add(this.btn_videoAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_rentalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_videoTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VideoMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoMaster";
            this.Load += new System.EventHandler(this.VideoMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_VideoMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_videoBack;
        private System.Windows.Forms.DataGridView grid_VideoMaster;
        private System.Windows.Forms.Button btn_videoDelete;
        private System.Windows.Forms.Button btn_videoEdit;
        private System.Windows.Forms.Button btn_videoAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_rentalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_videoTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_releaseDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}