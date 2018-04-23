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
    public partial class recording : Form
    {
        public recording()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            record.Hide();
        }
    }
}
