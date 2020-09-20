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
    public partial class CustomerMaster : Form
    {
        Global rentalDb = new Global();
        string customer_id = "";
        public CustomerMaster()
        {
            InitializeComponent();
        }

        private void text_name_Validating(object sender, CancelEventArgs e)
        {
            nameValidation();
        }
        public bool nameValidation()
        {
            if (string.IsNullOrWhiteSpace(text_name.Text))
            {
                //e.Cancel = true;
                text_name.Focus();
                errorProvider1.SetError(text_name, "Name should not be left blank!");
                return false;
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(text_name, "");
                return true;
            }
        }
        public bool ValidateForm()
        {
            bool bValidName = nameValidation();
            bool bValidMobile = mobileValidation();
            bool bValidAddress = addressValidation();
            if (bValidName && bValidMobile && bValidAddress)
                return true;
            else
                return false;
        }
        private void btn_customerAdd_Click(object sender, EventArgs e)
        {
            bool isValidForm = ValidateForm();
            if (isValidForm)
            {
                rentalDb.InsertCustomerMaster(text_name.Text, text_mobile_no.Text, text_address.Text);

                customer_id = "";

                TextBoxesEmpty();
                gridCustomerMasterBind();

                MessageBox.Show("Successfully Add Customer");
                btn_customerAdd.Enabled = true;
                btn_customerEdit.Enabled = false;
                btn_customerDelete.Enabled = false;
            }
           
        }

        private void text_mobile_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void text_mobile_no_Validating(object sender, CancelEventArgs e)
        {
            mobileValidation();
        }
        public bool mobileValidation()
        {
            if(string.IsNullOrWhiteSpace(text_mobile_no.Text))
            {
                //e.Cancel = true;
                text_mobile_no.Focus();
                errorProvider1.SetError(text_mobile_no, "Mobile No. should not be left blank!");
                return false;
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(text_mobile_no, "");
                return true;
            }
        }
        private void text_address_Validating(object sender, CancelEventArgs e)
        {
            addressValidation();
        }
        public bool addressValidation()
        {
            if (string.IsNullOrWhiteSpace(text_address.Text))
            {
                
                text_address.Focus();
                errorProvider1.SetError(text_address, "Address should not be left blank!");
                return false;
            }
            else
            {
                
                errorProvider1.SetError(text_address, "");
                return true;
            }
        }
        private void TextBoxesEmpty()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void gridCustomerMasterBind()
        {
            DataTable dt = new DataTable();

            dt = rentalDb.GetCustomerMasterList();

            grid_CustomerMaster.DataSource = dt;
        }

        private void CustomerMaster_Load(object sender, EventArgs e)
        {
            gridCustomerMasterBind();
            btn_customerAdd.Enabled = true;
            btn_customerEdit.Enabled = false;
            btn_customerDelete.Enabled = false;
        }

        private void grid_CustomerMaster_Click(object sender, EventArgs e)
        {
            if (grid_CustomerMaster.Rows.Count > 0)
            {
                customer_id = grid_CustomerMaster.CurrentRow.Cells[0].Value.ToString();
                text_name.Text = grid_CustomerMaster.CurrentRow.Cells[1].Value.ToString();
                text_mobile_no.Text = grid_CustomerMaster.CurrentRow.Cells[3].Value.ToString();
                text_address.Text = grid_CustomerMaster.CurrentRow.Cells[2].Value.ToString();
                btn_customerAdd.Enabled = false;
                btn_customerEdit.Enabled = true;
                btn_customerDelete.Enabled = true;
            }
        }

        private void btn_customerEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customer_id))
            {
                MessageBox.Show("Please Select the Customer");
                return;
            }
            rentalDb.EditCustomerMaster(text_name.Text, text_mobile_no.Text, text_address.Text,Convert.ToInt32(customer_id));
            
                customer_id = "";

                TextBoxesEmpty();
                gridCustomerMasterBind();

                MessageBox.Show("Successfully Edit Customer");
                btn_customerAdd.Enabled = true;
                btn_customerEdit.Enabled = false;
                btn_customerDelete.Enabled = false;
            
        }

        private void btn_customerDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customer_id))
            {
                MessageBox.Show("Please Select the Customer");
                return;
            }
            rentalDb.DeleteCustomer(Convert.ToInt32(customer_id));

            customer_id = "";

            TextBoxesEmpty();
            gridCustomerMasterBind();

            MessageBox.Show("Successfully Delete Customer");
            btn_customerAdd.Enabled = true;
            btn_customerEdit.Enabled = false;
            btn_customerDelete.Enabled = false;

        }

        private void btn_customerBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
