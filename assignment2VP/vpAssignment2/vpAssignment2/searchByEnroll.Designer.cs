namespace vpAssignment2
{
    partial class searchByEnroll
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
            this.enrollFeild = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewEnroll = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enroll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.className = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter to search";
            // 
            // enrollFeild
            // 
            this.enrollFeild.Location = new System.Drawing.Point(202, 46);
            this.enrollFeild.Name = "enrollFeild";
            this.enrollFeild.Size = new System.Drawing.Size(137, 20);
            this.enrollFeild.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewEnroll
            // 
            this.listViewEnroll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.enroll,
            this.className,
            this.semester,
            this.gpa,
            this.status});
            this.listViewEnroll.GridLines = true;
            this.listViewEnroll.Location = new System.Drawing.Point(79, 88);
            this.listViewEnroll.Name = "listViewEnroll";
            this.listViewEnroll.Size = new System.Drawing.Size(395, 163);
            this.listViewEnroll.TabIndex = 3;
            this.listViewEnroll.UseCompatibleStateImageBehavior = false;
            this.listViewEnroll.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "name";
            // 
            // enroll
            // 
            this.enroll.Text = "enroll";
            this.enroll.Width = 93;
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
            // status
            // 
            this.status.Text = "status";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchByEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewEnroll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enrollFeild);
            this.Controls.Add(this.label1);
            this.Name = "searchByEnroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchByEnroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enrollFeild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewEnroll;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader enroll;
        private System.Windows.Forms.ColumnHeader className;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.ColumnHeader gpa;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button button2;

    }
}