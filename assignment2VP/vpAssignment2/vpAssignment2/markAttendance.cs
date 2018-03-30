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
    public partial class markAttendance : Form
    {
        public markAttendance()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string className = text_Class.Text.ToLower();
            string semester = text_Sem.Text.ToLower();
            attendance obj = new attendance();
            obj.markAttendance(className, semester);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main obj = new main();
            obj.Show();
        }
    }
}
