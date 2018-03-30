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
    public partial class searchByName : Form
    {
        public searchByName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            studentProfile obj = new studentProfile();
            string name = nameFeild.Text.ToLower();
            string[] result = obj.checkRecord(name);
            for (int j = 0; j < result.Length; j++)
            {
                string[] words = result[j].Split(' ');

                ListViewItem objL = new ListViewItem(words[0]);
                objL.SubItems.Add(words[1]);
                objL.SubItems.Add(words[2]);
                objL.SubItems.Add(words[3]);
                objL.SubItems.Add(words[4]);
                objL.SubItems.Add(words[5]);
                listView.Items.Add(objL);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main obj = new main();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameFeild_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
