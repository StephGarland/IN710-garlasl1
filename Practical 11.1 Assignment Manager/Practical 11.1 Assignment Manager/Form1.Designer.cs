namespace Practical_11._1_Assignment_Manager
{
    partial class Form1
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
            this.btn_Papers = new System.Windows.Forms.Button();
            this.btn_Grades = new System.Windows.Forms.Button();
            this.btn_Assignments = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Papers
            // 
            this.btn_Papers.Location = new System.Drawing.Point(13, 13);
            this.btn_Papers.Name = "btn_Papers";
            this.btn_Papers.Size = new System.Drawing.Size(148, 23);
            this.btn_Papers.TabIndex = 0;
            this.btn_Papers.Text = "Papers";
            this.btn_Papers.UseVisualStyleBackColor = true;
            this.btn_Papers.Click += new System.EventHandler(this.btn_Papers_Click);
            // 
            // btn_Grades
            // 
            this.btn_Grades.Location = new System.Drawing.Point(12, 42);
            this.btn_Grades.Name = "btn_Grades";
            this.btn_Grades.Size = new System.Drawing.Size(149, 23);
            this.btn_Grades.TabIndex = 1;
            this.btn_Grades.Text = "Grades";
            this.btn_Grades.UseVisualStyleBackColor = true;
            this.btn_Grades.Click += new System.EventHandler(this.btn_Grades_Click);
            // 
            // btn_Assignments
            // 
            this.btn_Assignments.Location = new System.Drawing.Point(13, 72);
            this.btn_Assignments.Name = "btn_Assignments";
            this.btn_Assignments.Size = new System.Drawing.Size(148, 23);
            this.btn_Assignments.TabIndex = 2;
            this.btn_Assignments.Text = "Upcoming Assignments";
            this.btn_Assignments.UseVisualStyleBackColor = true;
            this.btn_Assignments.Click += new System.EventHandler(this.btn_Assignments_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(179, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 290);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 316);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Assignments);
            this.Controls.Add(this.btn_Grades);
            this.Controls.Add(this.btn_Papers);
            this.Name = "Form1";
            this.Text = "Assignment Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Papers;
        private System.Windows.Forms.Button btn_Grades;
        private System.Windows.Forms.Button btn_Assignments;
        private System.Windows.Forms.ListBox listBox1;
    }
}

