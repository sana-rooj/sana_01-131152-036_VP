namespace vpAssignment2
{
    partial class toppers
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTop = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enroll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.className = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toppers";
            // 
            // listViewTop
            // 
            this.listViewTop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.enroll,
            this.className,
            this.semester,
            this.gpa});
            this.listViewTop.GridLines = true;
            this.listViewTop.Location = new System.Drawing.Point(113, 82);
            this.listViewTop.Name = "listViewTop";
            this.listViewTop.Size = new System.Drawing.Size(344, 146);
            this.listViewTop.TabIndex = 1;
            this.listViewTop.UseCompatibleStateImageBehavior = false;
            this.listViewTop.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "name";
            // 
            // enroll
            // 
            this.enroll.Text = "enroll";
            this.enroll.Width = 90;
            // 
            // className
            // 
            this.className.Text = "className";
            this.className.Width = 71;
            // 
            // semester
            // 
            this.semester.Text = "semester";
            // 
            // gpa
            // 
            this.gpa.Text = "gpa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toppers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewTop);
            this.Controls.Add(this.label1);
            this.Name = "toppers";
            this.Text = "toppers";
            this.Load += new System.EventHandler(this.toppers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader enroll;
        private System.Windows.Forms.ColumnHeader className;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.ColumnHeader gpa;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listViewTop;
    }
}