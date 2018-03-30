using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vpAssignment2
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string enroll = deleteEnroll.Text;
            studentProfile obj = new studentProfile();
            obj.deleteRecord(enroll);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main obj = new main();
            obj.Show();
        }
    }
}
