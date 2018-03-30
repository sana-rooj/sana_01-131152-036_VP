namespace vpAssignment2
{
    partial class status
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewAtt = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enrollment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Attendance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.attendace = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewAtt
            // 
            this.listViewAtt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.enrollment,
            this.Attendance});
            this.listViewAtt.GridLines = true;
            this.listViewAtt.Location = new System.Drawing.Point(91, 88);
            this.listViewAtt.Name = "listViewAtt";
            this.listViewAtt.Size = new System.Drawing.Size(369, 178);
            this.listViewAtt.TabIndex = 2;
            this.listViewAtt.UseCompatibleStateImageBehavior = false;
            this.listViewAtt.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 106;
            // 
            // enrollment
            // 
            this.enrollment.Text = "enrollment";
            this.enrollment.Width = 125;
            // 
            // Attendance
            // 
            this.Attendance.Text = "Attendance";
            this.Attendance.Width = 137;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the semester number:";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(267, 54);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(134, 20);
            this.className.TabIndex = 5;
            this.attendace.SetToolTip(this.className, "single digit");
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.className);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewAtt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listViewAtt;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader enrollment;
        private System.Windows.Forms.ColumnHeader Attendance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.ToolTip attendace;
    }
}