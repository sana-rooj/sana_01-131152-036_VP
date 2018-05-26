﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CameraCapture
{
    public partial class sign_up : Form
    {
        public string userIdCheckSignUp;
        public sign_up()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            database objData = new database();
            if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(usertext.Text)|| string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(mobiletext.Text) || string.IsNullOrEmpty(password.Text))
                MessageBox.Show("Please fill all the feilds", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (objData.checkAvailability(ID.Text))
                {
                    if (checkEmail(email.Text))
                    {
                        userIdCheckSignUp = ID.Text;
                        Menu objM = new Menu();
                        objM.userIdMenu = userIdCheckSignUp;
                        int idValue = Convert.ToInt32(ID.Text);
                        objData.register(idValue,usertext.Text,email.Text,mobiletext.Text,password.Text);
                        MessageBox.Show("You are successfully registered", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        objM.Show();
                        this.Hide();

                    }
                    else
                        MessageBox.Show("Enter a valid Gmail account", "SORRY", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                }
                else
                    MessageBox.Show("ID already taken", "SORRY", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           

        
        }
        private bool checkEmail(string emailCheck)

        {
            if (email.Text.Contains("@gmail.com"))
                return true;
            else
                return false;

        }
            private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
