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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            sign_up obj = new sign_up();
            obj.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Hide();
        }
    }
}
