using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CameraCapture
{
    public partial class login : Form 
    {
        public string userIdCheckLogin;
        public login()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
           database objdata = new database();
            
            if (string.IsNullOrEmpty(ID.Text)|| string.IsNullOrEmpty(password.Text))
                MessageBox.Show("Please fill all the feilds", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (objdata.authenticate(ID.Text, password.Text))
                {
                    userIdCheckLogin = ID.Text;
                    Menu objM = new Menu();
                    objM.userIdMenu = userIdCheckLogin;
                    //byte[] file;
                    //string path = @"C: \Users\sanaa\Downloads\download.jpg";

                    //using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    //{
                    //    using (var reader = new BinaryReader(stream))
                    //    {
                    //        file = reader.ReadBytes((int)stream.Length);
                    //    }
                    //}
                    //database obj = new database();
                    //MessageBox.Show(userIdCheckLogin);
                    //obj.saveImage(file, userIdCheckLogin);
                    objM.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Please enter correct combination of ID and Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
           


        }

        private void signup_Click(object sender, EventArgs e)
        {
            sign_up obj = new sign_up();
            obj.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
