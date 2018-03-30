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
    public partial class status : Form
    {
        public status()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attendance obj1 = new attendance();
            
            string classN = className.Text.ToLower();
            string[] result = obj1.viewAttendance(classN);


            for (int j = 0; j < result.Length; j++)
            {
                string[] words = result[j].Split(' ');

                ListViewItem objL = new ListViewItem(words[0]);
                objL.SubItems.Add(words[1]);
                objL.SubItems.Add(words[2]);
                listViewAtt.Items.Add(objL);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main obj = new main();
            obj.Show();
        }
    }
}
