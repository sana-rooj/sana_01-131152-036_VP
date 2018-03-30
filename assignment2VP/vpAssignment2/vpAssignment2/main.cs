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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
          //  studentProfile obj = new studentProfile();
            //obj.createfile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            toppers obj1 = new toppers();
            obj1.Show();
            studentProfile obj = new studentProfile();
            string[] result1 = obj.topers();
            for (int j = 0; j < result1.Length; j++)
            {
                string[] words = result1[j].Split(' ');

                ListViewItem objL = new ListViewItem(words[0]);
                objL.SubItems.Add(words[1]);
                objL.SubItems.Add(words[2]);
                objL.SubItems.Add(words[3]);
                objL.SubItems.Add(words[4]);
                obj1.listViewTop.Items.Add(objL);
                // listViewTop.Items.Add(objL);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchspace obj = new searchspace();
            obj.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry obj1 = new Entry();
            obj1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete obj = new delete();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            status obj = new status();
            obj.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            markAttendance obj = new markAttendance();
            obj.Show();
        }

       
    }
}
