using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CameraCapture
{
    public partial class images : Form
    {
        public int index;
        public string userIdImages;
        public images()
        {
            InitializeComponent();
            index = 1;
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
            obj.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Text;
           // MessageBox.Show(date + userIdImages);
            int indexPass = index;
            MessageBox.Show(indexPass.ToString());
            database objData = new database();
            MemoryStream ms = objData.loadimage(indexPass,date,userIdImages);
            if (ms == null)  
                Search.Enabled = false;
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
    }
}
