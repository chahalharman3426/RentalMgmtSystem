using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMgmtSystem
{
    public partial class frmRenturnVideo : Form
    {
        Global rentalDb = new Global();
        string rentalVideoId = "";
        string VideoId = "";
        public frmRenturnVideo()
        {
            InitializeComponent();
        }

        private void gridRentedMovie_Click(object sender, EventArgs e)
        {
           
        }

        private void frmRenturnVideo_Load(object sender, EventArgs e)
        {
            AllRentedOutVideo();
        }
        private void AllRentedOutVideo()
        {
            DataTable dt = new DataTable();

            dt = rentalDb.AllRentedOutVideo();
            gridRentedMovie.DataSource = dt;
        }

        private void btn_ReturnVideo_Click(object sender, EventArgs e)
        {
            if (gridRentedMovie.Rows.Count > 0)
            {
                rentalVideoId = gridRentedMovie.CurrentRow.Cells["RMID"].Value.ToString();

                VideoId = gridRentedMovie.CurrentRow.Cells["MovieId"].Value.ToString();
            }
            if (string.IsNullOrEmpty(rentalVideoId))
            {
                MessageBox.Show("Please Select the Rented Movie");
                return;
            }



            string returnVideo = rentalDb.ReturnedRentalVideo(Convert.ToInt32(rentalVideoId));
            if (returnVideo == "Success")
            {
                string StatusChange = rentalDb.ChangedOnRentalStatus(Convert.ToInt32(VideoId), "Yes");
                MessageBox.Show("Movie Returned successfully");
                rentalVideoId = "";
                VideoId = "";
                AllRentedOutVideo();
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
