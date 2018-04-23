using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace securityMotiondetection
{
    public partial class images : Form
    {
        public images()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            setImage.Image = Image.FromFile(@"C:\Users\Iftikhar\Downloads\download.jpg");
        }
    }
}
