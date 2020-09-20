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
    public partial class frmMostBuyerList : Form
    {
        Global rentalDb = new Global();
        public frmMostBuyerList()
        {
            InitializeComponent();
        }

        private void frmMostBuyerList_Load(object sender, EventArgs e)
        {
            MostBuyerList();
        }
        private void MostBuyerList()
        {
            DataTable dt = new DataTable();
            dt = rentalDb.MostBuyerList();

            gridMostBuyer.DataSource = dt;
        }
    }
}
