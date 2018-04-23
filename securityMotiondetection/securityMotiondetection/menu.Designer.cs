namespace securityMotiondetection
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.logout = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.view_image = new System.Windows.Forms.Button();
            this.secure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(473, -1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 26;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Location = new System.Drawing.Point(1, -1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(58, 34);
            this.back.TabIndex = 25;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "We Secure You";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 285);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // view_image
            // 
            this.view_image.Location = new System.Drawing.Point(288, 157);
            this.view_image.Name = "view_image";
            this.view_image.Size = new System.Drawing.Size(116, 46);
            this.view_image.TabIndex = 30;
            this.view_image.Text = "View Images";
            this.view_image.UseVisualStyleBackColor = true;
            this.view_image.Click += new System.EventHandler(this.view_image_Click);
            // 
            // secure
            // 
            this.secure.Location = new System.Drawing.Point(288, 76);
            this.secure.Name = "secure";
            this.secure.Size = new System.Drawing.Size(116, 46);
            this.secure.TabIndex = 31;
            this.secure.Text = "Enter Secure Mode";
            this.secure.UseVisualStyleBackColor = true;
            this.secure.Click += new System.EventHandler(this.secure_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(549, 341);
            this.Controls.Add(this.secure);
            this.Controls.Add(this.view_image);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.back);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button view_image;
        private System.Windows.Forms.Button secure;
    }
}