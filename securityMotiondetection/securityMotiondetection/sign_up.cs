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
    public partial class sign_up : Form
    {
        public sign_up()
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

        private void signup_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Hide();
        }
    }
}
