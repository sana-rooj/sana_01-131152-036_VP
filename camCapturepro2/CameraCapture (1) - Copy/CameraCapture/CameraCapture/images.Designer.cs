namespace CameraCapture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(images));
            this.Search = new System.Windows.Forms.Button();
            this.setImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Library = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timerbutton = new System.Windows.Forms.Timer(this.components);
            this.timeLeft = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search.Location = new System.Drawing.Point(54, 165);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 50;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // setImage
            // 
            this.setImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.setImage.Image = ((System.Drawing.Image)(resources.GetObject("setImage.Image")));
            this.setImage.Location = new System.Drawing.Point(228, 82);
            this.setImage.Name = "setImage";
            this.setImage.Size = new System.Drawing.Size(309, 231);
            this.setImage.TabIndex = 49;
            this.setImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Date :";
            // 
            // Library
            // 
            this.Library.AutoSize = true;
            this.Library.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library.Location = new System.Drawing.Point(248, 19);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(66, 24);
            this.Library.TabIndex = 45;
            this.Library.Text = "Library";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 42);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logout.Location = new System.Drawing.Point(472, 1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 44;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Location = new System.Drawing.Point(0, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(54, 32);
            this.back.TabIndex = 43;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(236, 90);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 51;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(76, 111);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker.TabIndex = 52;
            // 
            // timerbutton
            // 
            this.timerbutton.Tick += new System.EventHandler(this.timerbutton_Tick);
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.BackColor = System.Drawing.SystemColors.Highlight;
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.Location = new System.Drawing.Point(140, 220);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(0, 24);
            this.timeLeft.TabIndex = 53;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(236, 66);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 20);
            this.labelTime.TabIndex = 54;
            // 
            // images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(549, 341);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.setImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Library);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.back);
            this.Name = "images";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "images";
            this.Load += new System.EventHandler(this.images_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox setImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Library;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timerbutton;
        private System.Windows.Forms.Label timeLeft;
        public System.Windows.Forms.Label labelTime;
    }
}