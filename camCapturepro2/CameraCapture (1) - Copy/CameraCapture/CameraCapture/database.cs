using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace CameraCapture
{
    public class database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=database;Sslmode=none");
        public string timeCaptured;
        public database()
        {
           
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);   
                
            }
            finally
            {
                connection.Close();
            }
        }
        public bool authenticate(string id, string password)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users_data where ID='"+id+"'",connection);
            DataTable retrive = new DataTable();
            adapter.Fill(retrive);
            if (retrive.Rows.Count == 0)
                return false;
            else
            {
                if (retrive.Rows[0][0].ToString() == id && retrive.Rows[0][4].ToString() == password)
                {
                    return true;
                }
                else
                    return false;
            }
           
        }
       
        public bool checkAvailability(string id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users_data where ID='" + id + "'", connection);
            DataTable retrive = new DataTable();
            adapter.Fill(retrive);
            int rows = retrive.Rows.Count;
            if (rows!=0)
            {
                return false;
            }
            else
                return true;
        }
        public void register(int id,string username,string email,string mobileno,string password)
        {
            using (connection)
            {
                string query = "insert into users_data (id,username,email,mobileno,password) values (@id,@username,@email,@mobileno,@password)";
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@mobileno", mobileno);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();

                }
                 
            }

        }
        public void saveImage(byte[] imageSave, string userIdImage)
        {
            int nextId = 0;
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from images", connection);
            DataTable retrive = new DataTable();
            adapter.Fill(retrive);
            if (retrive.Rows.Count != 0)
            {

                nextId = retrive.Rows.Count;
                MessageBox.Show(nextId.ToString());

            }
            string query = "insert into images(image_id,imageCaptured,user_id,date,time) values (@id,@img,@userID,@date,@time)";
            DateTime sysDateTime = DateTime.Now;
            string dateTime = sysDateTime.ToString();
            string[] dateAndTime = dateTime.Split(' ');
            connection.Open();
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", ++nextId);
                command.Parameters.AddWithValue("@img",imageSave );
                command.Parameters.AddWithValue("@userID",userIdImage);
                command.Parameters.AddWithValue("@date", dateAndTime[0]);
                command.Parameters.AddWithValue("@time", dateAndTime[1]);
                command.ExecuteNonQuery();

            }
        }


        public MemoryStream loadimage(int indexP,string dateGiven,string userLogged)
        {

            MemoryStream defaultreturn = null;
            try
            {
                connection.Open();
                int bufferSize = 1000;
                string query = "Select imageCaptured from images where user_id ='" + userLogged + "'&& date='"+dateGiven+"'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "imageCaptured");

                int c = ds.Tables["imageCaptured"].Rows.Count;
                
                if (indexP > c)
                    MessageBox.Show("No images to show","Images", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                else if (c > 0)
                {
                    Byte[] byteBLOBData = new Byte[bufferSize];
                    byteBLOBData = (Byte[])(ds.Tables["imageCaptured"].Rows[c - indexP]["imageCaptured"]);
                   // MessageBox.Show(byteBLOBData.ToString());
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);

                    return stmBLOBData;

                }
                return defaultreturn;
            }
            catch(OutOfMemoryException mem)
            {
                MessageBox.Show(mem.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            finally
            {
                connection.Close();
            }
            return defaultreturn;
        }
        public void getTime(int indexP,string dateGiven, string userLogged)
        {
            try
            {
                connection.Open();
                
                string query = "Select time from images where user_id ='" + userLogged + "'&& date='" + dateGiven + "'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "time");
                int c = ds.Tables["time"].Rows.Count;
                if (indexP > c)
                    timeCaptured = null;
                else if (c > 0)
                    timeCaptured = (ds.Tables["time"].Rows[c - indexP]["time"]).ToString();


            }
            catch(IndexOutOfRangeException IOR)
            {
                MessageBox.Show(IOR.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        public string getEmailId(string idlogged)
        {
          
            string query = "select email from users_data where id='" + idlogged + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "email");
            MessageBox.Show(ds.Tables["email"].Rows[0][0].ToString());
            return ds.Tables["email"].Rows[0][0].ToString();
        }
        public string getSmsDetails(string id)
        {
            string data = null;
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users_data where ID='" + id + "'", connection);
            DataTable retrive = new DataTable();
            adapter.Fill(retrive);
            if (retrive.Rows.Count == 0)
                return data;
            else
                data = retrive.Rows[0][1].ToString() + "," + retrive.Rows[0][3].ToString() + "," + retrive.Rows[0][4].ToString();
            return data;

        }
    }
}
