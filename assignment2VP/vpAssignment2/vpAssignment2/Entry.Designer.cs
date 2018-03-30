namespace vpAssignment2
{
    partial class Entry
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
            this.label2 = new System.Windows.Forms.Label();
            this.getName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.getEnroll = new System.Windows.Forms.TextBox();
            this.getClass = new System.Windows.Forms.TextBox();
            this.getSem = new System.Windows.Forms.TextBox();
            this.getGpa = new System.Windows.Forms.TextBox();
            this.statusP = new System.Windows.Forms.RadioButton();
            this.statusA = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.ToolTip(this.components);
            this.enroll = new System.Windows.Forms.ToolTip(this.components);
            this.className = new System.Windows.Forms.ToolTip(this.components);
            this.semester = new System.Windows.Forms.ToolTip(this.components);
            this.gpa = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter student data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // getName
            // 
            this.getName.Location = new System.Drawing.Point(319, 46);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(100, 20);
            this.getName.TabIndex = 2;
            this.name.SetToolTip(this.getName, "first name");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enrollment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ClassName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Semester:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gpa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "attendance";
            // 
            // getEnroll
            // 
            this.getEnroll.Location = new System.Drawing.Point(319, 78);
            this.getEnroll.Name = "getEnroll";
            this.getEnroll.Size = new System.Drawing.Size(100, 20);
            this.getEnroll.TabIndex = 8;
            this.enroll.SetToolTip(this.getEnroll, "**-******-***");
            // 
            // getClass
            // 
            this.getClass.Location = new System.Drawing.Point(319, 110);
            this.getClass.Name = "getClass";
            this.getClass.Size = new System.Drawing.Size(100, 20);
            this.getClass.TabIndex = 9;
            this.className.SetToolTip(this.getClass, "bs**");
            // 
            // getSem
            // 
            this.getSem.Location = new System.Drawing.Point(319, 143);
            this.getSem.Name = "getSem";
            this.getSem.Size = new System.Drawing.Size(100, 20);
            this.getSem.TabIndex = 10;
            this.semester.SetToolTip(this.getSem, "single digit");
            // 
            // getGpa
            // 
            this.getGpa.Location = new System.Drawing.Point(319, 180);
            this.getGpa.Name = "getGpa";
            this.getGpa.Size = new System.Drawing.Size(100, 20);
            this.getGpa.TabIndex = 11;
            this.gpa.SetToolTip(this.getGpa, "upto one floating point");
            // 
            // statusP
            // 
            this.statusP.AutoSize = true;
            this.statusP.Location = new System.Drawing.Point(319, 221);
            this.statusP.Name = "statusP";
            this.statusP.Size = new System.Drawing.Size(60, 17);
            this.statusP.TabIndex = 12;
            this.statusP.Text = "present";
            this.statusP.UseVisualStyleBackColor = true;
            // 
            // statusA
            // 
            this.statusA.AutoSize = true;
            this.statusA.Checked = true;
            this.statusA.Location = new System.Drawing.Point(435, 219);
            this.statusA.Name = "statusA";
            this.statusA.Size = new System.Drawing.Size(57, 17);
            this.statusA.TabIndex = 13;
            this.statusA.TabStop = true;
            this.statusA.Text = "absent";
            this.statusA.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusA);
            this.Controls.Add(this.statusP);
            this.Controls.Add(this.getGpa);
            this.Controls.Add(this.getSem);
            this.Controls.Add(this.getClass);
            this.Controls.Add(this.getEnroll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getName;
        private System.Windows.Forms.ToolTip name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox getEnroll;
        private System.Windows.Forms.TextBox getClass;
        private System.Windows.Forms.TextBox getSem;
        private System.Windows.Forms.TextBox getGpa;
        private System.Windows.Forms.RadioButton statusP;
        private System.Windows.Forms.RadioButton statusA;
        private System.Windows.Forms.ToolTip enroll;
        private System.Windows.Forms.ToolTip className;
        private System.Windows.Forms.ToolTip semester;
        private System.Windows.Forms.ToolTip gpa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}