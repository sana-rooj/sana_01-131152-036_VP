using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CameraCapture
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
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=true;
        }
    }
}
