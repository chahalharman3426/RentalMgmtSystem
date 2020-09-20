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
    public partial class VideoMaster : Form
    {
        Global rentalDb = new Global();
        string video_id = "";
        public VideoMaster()
        {
            InitializeComponent();
        }

        private void text_videoTitle_Validating(object sender, CancelEventArgs e)
        {
            titleValidation();
        }
        public bool titleValidation()
        {
            if (string.IsNullOrWhiteSpace(text_videoTitle.Text))
            {
                text_videoTitle.Focus();
                errorProvider1.SetError(text_videoTitle, "Video Title should not be left blank!");
                return false;
            }
            else
            {
                errorProvider1.SetError(text_videoTitle, "");
                return true;
            }
        }

        private void text_rentalCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox_genre_Validating(object sender, CancelEventArgs e)
        {
            genreValidation();
        }
        public bool genreValidation()
        {
            if (string.IsNullOrWhiteSpace(comboBox_genre.SelectedItem.ToString()))
            {
                comboBox_genre.Focus();
                errorProvider1.SetError(comboBox_genre, "Genre should not be Select!");
                return false;
            }
            else
            {
                errorProvider1.SetError(comboBox_genre, "");
                return true;
            }
        }

        private void text_rentalCost_Validating(object sender, CancelEventArgs e)
        {
            costValidation();
        }
        public bool costValidation()
        {
            if (string.IsNullOrWhiteSpace(text_rentalCost.Text))
            {
                text_rentalCost.Focus();
                errorProvider1.SetError(text_rentalCost, "Rental Cost should not be left blank!");
                return false;
            }
            else
            {
                errorProvider1.SetError(text_rentalCost, "");
                return true;
            }
        }
        public bool ValidateForm()
        {
            bool bValidTitle = titleValidation();
            bool bValidCost = costValidation();
            bool bValidGenre = genreValidation();
            if (bValidTitle && bValidCost && bValidGenre)
                return true;
            else
                return false;
        }

        private void btn_videoAdd_Click(object sender, EventArgs e)
        {
            bool isValidForm = ValidateForm();
            if (isValidForm)
            {
                string dbVideo = rentalDb.InsertVideoMaster(text_videoTitle.Text, dtp_releaseDate.Value.Date, Convert.ToDecimal(text_rentalCost.Text), comboBox_genre.SelectedItem.ToString());
                if (dbVideo == "Success")
                {
                    video_id = "";

                    TextBoxesEmpty();
                    AllVideoList();

                    MessageBox.Show("Successfully Add Video");
                    btn_videoAdd.Enabled = true;
                    btn_videoEdit.Enabled = false;
                    btn_videoDelete.Enabled = false;
                    if (dtp_releaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                    {
                        text_rentalCost.Text = "2";
                    }
                    else
                    {
                        text_rentalCost.Text = "5";
                    }
                }
                else
                {
                    MessageBox.Show(dbVideo);
                }
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
       
        private void grid_VideoMaster_Click(object sender, EventArgs e)
        {
            if (grid_VideoMaster.Rows.Count > 0)
            {
                video_id = grid_VideoMaster.CurrentRow.Cells[0].Value.ToString();
                text_videoTitle.Text = grid_VideoMaster.CurrentRow.Cells[1].Value.ToString();
                dtp_releaseDate.Text = grid_VideoMaster.CurrentRow.Cells[2].Value.ToString();
                text_rentalCost.Text = grid_VideoMaster.CurrentRow.Cells[3].Value.ToString();
                comboBox_genre.SelectedItem = grid_VideoMaster.CurrentRow.Cells[4].Value.ToString();
               
                btn_videoAdd.Enabled = false;
                btn_videoEdit.Enabled = true;
                btn_videoDelete.Enabled = true;

            }
        }
        public void AllVideoList()
        {
            DataTable dt = new DataTable();

            dt = rentalDb.AllVideoList();
            grid_VideoMaster.DataSource = dt;
        }

        private void VideoMaster_Load(object sender, EventArgs e)
        {
            AllVideoList();
            btn_videoAdd.Enabled = true;
            btn_videoEdit.Enabled = false;
            btn_videoDelete.Enabled = false;
            if (dtp_releaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                text_rentalCost.Text = "2";
            }
            else
            {
                text_rentalCost.Text = "5";
            }
            comboBox_genre.SelectedIndex = 0;
        }

        private void btn_videoEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(video_id))
            {
                MessageBox.Show("Please Select the Video");
                return;
            }
            bool isValidForm = ValidateForm();
            if (isValidForm)
            {
                string dbVideo = rentalDb.EditVideoMaster(text_videoTitle.Text, dtp_releaseDate.Value.Date, Convert.ToDecimal(text_rentalCost.Text), comboBox_genre.SelectedItem.ToString(), Convert.ToInt32(video_id));
                if (dbVideo == "Success")
                {
                    video_id = "";

                    TextBoxesEmpty();
                    AllVideoList();

                    MessageBox.Show("Successfully Update Movie");
                    btn_videoAdd.Enabled = true;
                    btn_videoEdit.Enabled = false;
                    btn_videoDelete.Enabled = false;
                    if (dtp_releaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                    {
                        text_rentalCost.Text = "2";
                    }
                    else
                    {
                        text_rentalCost.Text = "5";
                    }
                }
                else
                {
                    MessageBox.Show(dbVideo);
                }
            }
        }

        private void btn_videoDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(video_id))
            {
                MessageBox.Show("Please Select the Video");
                return;
            }
           
                string dbVideo = rentalDb.DeleteVideoMaster(Convert.ToInt32(video_id));
                if (dbVideo == "Success")
                {
                    video_id = "";

                    TextBoxesEmpty();
                    AllVideoList();

                    MessageBox.Show("Successfully Delete Movie");
                    btn_videoAdd.Enabled = true;
                    btn_videoEdit.Enabled = false;
                    btn_videoDelete.Enabled = false;
                    if (dtp_releaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                    {
                        text_rentalCost.Text = "2";
                    }
                    else
                    {
                    text_rentalCost.Text = "5";
                    }
                }
                else
                {
                    MessageBox.Show(dbVideo);
                }
           
        }

        private void dtp_releaseDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_releaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                text_rentalCost.Text = "2";
            }
            else
            {
                text_rentalCost.Text = "5";
            }
        }

        private void btn_videoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
