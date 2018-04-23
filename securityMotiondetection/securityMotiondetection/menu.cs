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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void secure_Click(object sender, EventArgs e)
        {
            recording obj = new recording();
            obj.Show();
            this.Hide();
        }

        private void view_image_Click(object sender, EventArgs e)
        {
            images obj = new images();
            obj.Show();
            this.Hide();
        }
    }
}
