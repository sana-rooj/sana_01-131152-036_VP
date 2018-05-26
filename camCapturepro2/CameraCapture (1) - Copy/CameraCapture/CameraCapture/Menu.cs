using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CameraCapture
{
    public partial class Menu : Form
    {
        public string userIdMenu;
        public Menu()
        {
            InitializeComponent();
        }

        private void secure_Click(object sender, EventArgs e)
        {
            Recording obj = new Recording();
            obj.userIdCapture = userIdMenu;
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void view_image_Click(object sender, EventArgs e)
        {
            images obj = new images();
            obj.userIdImages = userIdMenu;
            obj.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
