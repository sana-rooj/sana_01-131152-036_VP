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
    public partial class searchspace : Form
    {
        public searchspace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            searchByName obj1 = new searchByName();
          
            obj1.Show();
            
          



        }

        private void searchspace_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchByEnroll obj = new searchByEnroll();
            obj.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchByDep obj1 = new searchByDep();
            obj1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            main obj = new main();
            obj.Show();
        }

       
        
    }
}
