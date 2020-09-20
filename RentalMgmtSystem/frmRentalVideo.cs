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
    public partial class frmRentalVideo : Form
    {
        Global rentalDb = new Global();
        public frmRentalVideo()
        {
            InitializeComponent();
        }

        private void frmRentalVideo_Load(object sender, EventArgs e)
        {
            GetCustomerMasterList();
            AllNotOnRentalVideo();
            SelectAllRentedMovie();
        }
        private void GetCustomerMasterList()
        {

            DataTable dt = new DataTable();

            dt = rentalDb.GetCustomerMasterList();
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Customer";
            dt.Rows.InsertAt(row, 0);
            cmb_selectCustomer.DataSource = dt;
                cmb_selectCustomer.ValueMember = "customer_id";
                cmb_selectCustomer.DisplayMember = "name";

            
        }
        private void AllNotOnRentalVideo()
        {

            DataTable dt = new DataTable();
            dt.Clear();
            dt = rentalDb.AllNotOnRentalVideo();
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Video";
            dt.Rows.InsertAt(row, 0);
            cmb_selectVideo.DataSource = dt;
                cmb_selectVideo.ValueMember = "video_id";
            cmb_selectVideo.DisplayMember = "video_title";
        }

        private void btn_rentalVideo_Click(object sender, EventArgs e)
        {
            if (cmb_selectCustomer.SelectedValue == null || cmb_selectVideo.SelectedValue == null)
            {
                MessageBox.Show("Please Select the Customer and Video");
                return;
            }
            if (cmb_selectCustomer.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Customer");
                return;
            }
            if (cmb_selectVideo.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Video");
                return;
            }
            if (string.IsNullOrEmpty(cmb_selectCustomer.SelectedValue.ToString()) || string.IsNullOrEmpty(cmb_selectVideo.SelectedValue.ToString()))
            {
                MessageBox.Show("Please Select the Customer and Video for rental");
                return;
            }


            string rentedVideo = rentalDb.AddNewRentalVideo(Convert.ToInt32(cmb_selectCustomer.SelectedValue.ToString()), Convert.ToInt32(cmb_selectVideo.SelectedValue.ToString()), dtp_RentedDate.Value.Date);

            if (rentedVideo == "Success")
            {
                string StatusChange = rentalDb.ChangedOnRentalStatus(Convert.ToInt32(cmb_selectVideo.SelectedValue.ToString()), "No");
                MessageBox.Show("Video Rented successfully");
                GetCustomerMasterList();
                AllNotOnRentalVideo();
                SelectAllRentedMovie();

            }
            else
            {
                MessageBox.Show(rentedVideo);
            }
        }
        private void SelectAllRentedMovie()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = rentalDb.SelectAllRentedMovie();
            gridRentedMovie.DataSource = dt;
        }

        private void btn_videoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
