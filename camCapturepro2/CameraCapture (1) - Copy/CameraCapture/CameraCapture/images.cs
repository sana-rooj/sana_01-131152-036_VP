using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Collections.Specialized;
namespace CameraCapture
{
    public partial class images : Form
    {
        public int index;
        public string userIdImages;
        public int countdown;
        private MemoryStream ms;
        public images()
        {
            InitializeComponent();
            index = 1;
            countdown=20;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.userIdMenu = userIdImages;
            obj.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (index >= 1)
                Search.Text = "Next";
            string date = dateTimePicker.Text;
            int indexPass = index;
            database objData = new database();
            //  MemoryStream ms = objData.loadimage(indexPass,date,userIdImages);
            ms = objData.loadimage(indexPass, date, userIdImages);



            objData.getTime(indexPass, date, userIdImages);
            labelTime.Text = objData.timeCaptured;
            if (ms == null)
            {
                timerbutton.Interval = 1000; // one second
                timerbutton.Tick += timerbutton_Tick;
                timerbutton.Start();
                Search.Enabled = false;
            }
                
            else
            {
                setImage.Visible = true;
                setImage.Image = Image.FromStream(ms);
                

            }
              
          
            index = index + 1;
          

        }

        private void images_Load(object sender, EventArgs e)
        {
            setImage.Visible = false;
        }

        private void timerbutton_Tick(object sender, EventArgs e)
        {
            if (--countdown <= 0)
            {
                Search.Enabled = true;
                timeLeft.Visible = false;
                timerbutton.Stop();
                timerbutton.Tick -= timerbutton_Tick;
            }
            else
            {
               timeLeft.Text=(string.Format("you can serach after: {0}s", countdown));
            }
        }

        //private void download_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show(imageToDownload.ToString());

            
         
         
          
       


        //}
    }
}
