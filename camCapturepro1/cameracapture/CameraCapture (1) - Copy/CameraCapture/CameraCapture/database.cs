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
        }
        public bool authenticate(string id, string password)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users where ID='"+id+"'",connection);
            DataTable retrive = new DataTable();
            adapter.Fill(retrive);
            if (retrive.Rows.Count == 0)
                return false;
            else
            {
                if (retrive.Rows[0][0].ToString() == id && retrive.Rows[0][1].ToString() == password)
                {
                    return true;
                }
                else
                    return false;
            }
           
        }
        public bool checkAvailability(string id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from users where ID='" + id + "'", connection);
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
        public void register(int id,string password,string email)
        {
            using (connection)
            {
                string query = "insert into users (ID,password,email) values (@id,@password,@email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
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

        
    }
}
