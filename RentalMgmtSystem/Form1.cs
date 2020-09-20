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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_customerMaster_Click(object sender, EventArgs e)
        {
            CustomerMaster obj = new CustomerMaster();
            obj.Show();
        }

        private void btn_videoMaster_Click(object sender, EventArgs e)
        {
            VideoMaster obj = new VideoMaster();
            obj.Show();
        }

        private void btn_rentalVideo_Click(object sender, EventArgs e)
        {
            frmRentalVideo obj = new frmRentalVideo();
            obj.Show();
        }

        private void btn_returnVideo_Click(object sender, EventArgs e)
        {
            frmRenturnVideo obj = new frmRenturnVideo();
            obj.Show();
        }

        private void btn_mostRentalCustomeList_Click(object sender, EventArgs e)
        {
            frmMostBuyerList obj = new frmMostBuyerList();
            obj.Show();
        }

        private void btn_popularVideoList_Click(object sender, EventArgs e)
        {
            frmPopularVideo obj = new frmPopularVideo();
            obj.Show();
        }
    }
}
