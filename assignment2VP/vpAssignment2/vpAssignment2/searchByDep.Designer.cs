namespace vpAssignment2
{
    partial class searchByDep
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
            this.label1 = new System.Windows.Forms.Label();
            this.deptFeild = new System.Windows.Forms.TextBox();
            this.listViewDept = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enroll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.className = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Semester No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deptFeild
            // 
            this.deptFeild.Location = new System.Drawing.Point(222, 43);
            this.deptFeild.Name = "deptFeild";
            this.deptFeild.Size = new System.Drawing.Size(137, 20);
            this.deptFeild.TabIndex = 2;
            // 
            // listViewDept
            // 
            this.listViewDept.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.enroll,
            this.className,
            this.semester,
            this.gpa,
            this.status,
            this.index});
            this.listViewDept.GridLines = true;
            this.listViewDept.Location = new System.Drawing.Point(79, 88);
            this.listViewDept.Name = "listViewDept";
            this.listViewDept.Size = new System.Drawing.Size(410, 163);
            this.listViewDept.TabIndex = 3;
            this.listViewDept.UseCompatibleStateImageBehavior = false;
            this.listViewDept.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.DisplayIndex = 1;
            this.name.Text = "name";
            // 
            // enroll
            // 
            this.enroll.DisplayIndex = 2;
            this.enroll.Text = "enroll";
            this.enroll.Width = 84;
            // 
            // className
            // 
            this.className.DisplayIndex = 3;
            this.className.Text = "className";
            this.className.Width = 72;
            // 
            // semester
            // 
            this.semester.DisplayIndex = 4;
            this.semester.Text = "semester";
            // 
            // gpa
            // 
            this.gpa.DisplayIndex = 5;
            this.gpa.Text = "gpa";
            // 
            // status
            // 
            this.status.DisplayIndex = 6;
            this.status.Text = "status";
            // 
            // index
            // 
            this.index.DisplayIndex = 0;
            this.index.Text = "index";
            this.index.Width = 19;
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
            // searchByDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewDept);
            this.Controls.Add(this.deptFeild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "searchByDep";
            this.Text = "searchByDep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deptFeild;
        private System.Windows.Forms.ListView listViewDept;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader enroll;
        private System.Windows.Forms.ColumnHeader className;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.ColumnHeader gpa;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.Button button2;
    }
}