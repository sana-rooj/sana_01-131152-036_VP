namespace securityMotiondetection
{
    partial class images
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(images));
            this.Library = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setImage = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Library
            // 
            this.Library.AutoSize = true;
            this.Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library.Location = new System.Drawing.Point(247, 19);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(66, 24);
            this.Library.TabIndex = 37;
            this.Library.Text = "Library";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(471, 1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 36;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Location = new System.Drawing.Point(-1, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(58, 34);
            this.back.TabIndex = 35;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 42);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Date :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 40;
            // 
            // setImage
            // 
            this.setImage.Location = new System.Drawing.Point(300, 88);
            this.setImage.Name = "setImage";
            this.setImage.Size = new System.Drawing.Size(214, 152);
            this.setImage.TabIndex = 41;
            this.setImage.TabStop = false;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(122, 165);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 42;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(549, 341);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.setImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Library);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.back);
            this.Name = "images";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "images";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Library;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox setImage;
        private System.Windows.Forms.Button Search;
    }
}