using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMgmtSystem
{
    public class Global
    {
        SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["RentalMgmtSystemDb"].ConnectionString);
        public string InsertVideoMaster(string title, DateTime releaseDate, decimal cost, string genre)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("insert into tbl_video(video_title,release_date,rental_cost,genre,isAvailable)values(@video_title,@release_date,@rental_cost,@genre,@isAvailable)", connectionString))
                {
                    cmd.Parameters.AddWithValue("@video_title", title);
                    cmd.Parameters.AddWithValue("@release_date", releaseDate);
                    cmd.Parameters.AddWithValue("@rental_cost", cost);
                    cmd.Parameters.AddWithValue("@genre", genre);

                    cmd.Parameters.AddWithValue("@isAvailable", "Yes");
                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
                return "Success";
            }
            catch (Exception exp)
            {

                return exp.Message.ToString();
            }
        }
        public string EditVideoMaster(string title, DateTime releaseDate, decimal cost, string genre, int video_Id)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("update tbl_video set video_title=@video_title,release_date=@release_date,rental_cost=@rental_cost,genre=@genre where video_id=@video_id", connectionString))
                {
                    cmd.Parameters.AddWithValue("@video_id", video_Id);
                    cmd.Parameters.AddWithValue("@video_title", title);
                    cmd.Parameters.AddWithValue("@release_date", releaseDate);
                    cmd.Parameters.AddWithValue("@rental_cost", cost);
                    cmd.Parameters.AddWithValue("@genre", genre);

                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
                return "Success";
            }
            catch (Exception exp)
            {

                return exp.Message.ToString();
            }
        }
        public string DeleteVideoMaster(int video_id)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("delete from tbl_video where video_id=@video_id", connectionString))
                {
                    cmd.Parameters.AddWithValue("@video_id", video_id);

                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
                return "Success";
            }
            catch (Exception exp)
            {

                return exp.Message.ToString();
            }
        }
        public void InsertCustomerMaster(string Name, string mobile_no, string address)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("insert into tbl_customer(name,mobile_no,address)values(@name,@mobile_no,@address)", connectionString))
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@mobile_no", mobile_no);
                    cmd.Parameters.AddWithValue("@address", address);

                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }
        public void EditCustomerMaster(string Name, string mobile_no, string address, int cutomer_id)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("update tbl_customer set name=@name,mobile_no=@mobile_no,address=@address  where customer_id=@customer_id", connectionString))
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@mobile_no", mobile_no);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@customer_id", cutomer_id);

                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }
        public void DeleteCustomer(int customer_id)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("delete from tbl_customer where customer_id=@customer_id", connectionString))
                {
                    cmd.Parameters.AddWithValue("@customer_id", customer_id);

                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }
        public DataTable GetCustomerMasterList()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("sp_getCustomer", connectionString))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {


                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable AllVideoList()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from tbl_video", connectionString))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
       
        public DataTable AllNotOnRentalVideo()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from tbl_video where isAvailable='Yes'", connectionString))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public string AddNewRentalVideo( int customer_id, int video_id, DateTime rentedDate)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("insert into tbl_rentalVideo(customerId,videoId,rentalDate)values(@customerId,@videoId,@rentalDate)", connectionString))
                {
                    cmd.Parameters.AddWithValue("@customerId", customer_id);
                    cmd.Parameters.AddWithValue("@videoId", video_id);
                    cmd.Parameters.AddWithValue("@rentalDate", rentedDate);

                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
                return "Success";
            }
            catch (Exception exp)
            {
              return exp.Message.ToString();
            }
        }
        public DataTable SelectAllRentedMovie()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from viewRentalVideo", connectionString))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public string ChangedOnRentalStatus(int video_id, string status)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("update tbl_video set isAvailable=@isAvailable where video_id=@video_id", connectionString))
                {
                    cmd.Parameters.AddWithValue("@video_id", video_id);
                    cmd.Parameters.AddWithValue("@isAvailable", status);

                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
                return "Success";
            }
            catch (Exception exp)
            {
                return exp.Message.ToString();
            }

        }
        public DataTable AllRentedOutVideo()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from viewRentalVideo where returnDate is Null", connectionString))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public string ReturnedRentalVideo(int rental_id)
        {

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand("update tbl_rentalVideo set returnDate=@returnDate where rentalVideoId=@rentalVideoId", connectionString))
                {
                    cmd.Parameters.AddWithValue("@rentalVideoId", rental_id);
                    cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                connectionString.Close();
                return "Success";
            }
            catch (Exception exp)
            {
                return exp.Message.ToString();
            }

        }
        public DataTable MostBuyerList()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select customer_id,name,mobile_no,Count(*) as 'Total Borrows' from viewRentalVideo group by customer_id,name,mobile_no order by 'Total Borrows' desc", connectionString))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable PopularVideoList()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select video_id,video_title,release_date,rental_cost,Count(*) as 'Total Rented' from viewRentalVideo group by video_id,video_title,release_date,rental_cost order by 'Total Rented' desc", connectionString))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
    }
}
