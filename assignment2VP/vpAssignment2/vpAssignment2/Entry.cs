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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (getName.Text =="" || getEnroll.Text == "" || getClass.Text =="" || getSem.Text == "" || getGpa.Text == "")
                MessageBox.Show("please fill all feilds");
            else
            {
                int sem = 0;
                string name = getName.Text.ToLower();

                string enroll = getEnroll.Text;

                string classN = getClass.Text.ToLower();


                sem = Convert.ToInt32(getSem.Text);


                float gpa = float.Parse(getGpa.Text);

                string status = " ";
                Boolean check = statusP.Checked;
                if (check == true)
                    status = "present";
                else
                    status = "absent";

                studentProfile obj = new studentProfile();
                obj.enterStudent(name, enroll, classN, sem, gpa, status);
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
