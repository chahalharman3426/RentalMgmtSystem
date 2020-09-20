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
    public partial class frmPopularVideo : Form
    {
        Global rentalDb = new Global();
        public frmPopularVideo()
        {
            InitializeComponent();
        }

        private void frmPopularVideo_Load(object sender, EventArgs e)
        {
            PopularVideoList();
        }
        private void PopularVideoList()
        {
            DataTable dt = new DataTable();
            dt = rentalDb.PopularVideoList();

            gridPopularVideo.DataSource = dt;
        }

        
    }
}
