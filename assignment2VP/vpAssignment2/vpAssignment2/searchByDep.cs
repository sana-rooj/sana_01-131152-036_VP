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
    public partial class searchByDep : Form
    {
        public searchByDep()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            studentProfile obj = new studentProfile();
            int semNo = Convert.ToInt32(deptFeild.Text);
            string[] result = obj.checkSemester(semNo);
            for (int j = 0; j < result.Length; j++)
            {
                string[] words = result[j].Split(' ');

                ListViewItem objL = new ListViewItem(words[1]);
                objL.SubItems.Add(words[2]);
                objL.SubItems.Add(words[3]);
                objL.SubItems.Add(words[4]);
                objL.SubItems.Add(words[5]);
                objL.SubItems.Add(words[6]);
                objL.SubItems.Add(words[0]);
                listViewDept.Items.Add(objL);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main obj1 = new main();
            obj1.Show();
        }
    }
}
