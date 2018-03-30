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

       
        
    }
}
