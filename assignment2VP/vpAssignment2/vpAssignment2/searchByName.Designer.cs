namespace vpAssignment2
{
    partial class searchByName
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
            this.button1 = new System.Windows.Forms.Button();
            this.nameFeild = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enrollment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.className = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameFeild
            // 
            this.nameFeild.Location = new System.Drawing.Point(184, 37);
            this.nameFeild.Name = "nameFeild";
            this.nameFeild.Size = new System.Drawing.Size(137, 20);
            this.nameFeild.TabIndex = 1;
            this.nameFeild.TextChanged += new System.EventHandler(this.nameFeild_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter to search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.enrollment,
            this.className,
            this.semester,
            this.gpa,
            this.status});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(79, 88);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(395, 163);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 48;
            // 
            // enrollment
            // 
            this.enrollment.Text = "enrollment";
            this.enrollment.Width = 104;
            // 
            // className
            // 
            this.className.Text = "className";
            this.className.Width = 65;
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
            // back
            // 
            this.back.Location = new System.Drawing.Point(457, 257);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(62, 22);
            this.back.TabIndex = 4;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.back);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameFeild);
            this.Controls.Add(this.button1);
            this.Name = "searchByName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchByName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox nameFeild;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader enrollment;
        private System.Windows.Forms.ColumnHeader className;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.ColumnHeader gpa;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button back;
    }
}