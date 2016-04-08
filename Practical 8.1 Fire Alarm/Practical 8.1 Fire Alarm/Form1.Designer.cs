namespace Practical_8._1_Fire_Alarm
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
            this.button1 = new System.Windows.Forms.Button();
            this.rb_minor = new System.Windows.Forms.RadioButton();
            this.rb_serious = new System.Windows.Forms.RadioButton();
            this.rb_inferno = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fire Alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_minor
            // 
            this.rb_minor.AutoSize = true;
            this.rb_minor.Location = new System.Drawing.Point(12, 12);
            this.rb_minor.Name = "rb_minor";
            this.rb_minor.Size = new System.Drawing.Size(51, 17);
            this.rb_minor.TabIndex = 1;
            this.rb_minor.TabStop = true;
            this.rb_minor.Text = "Minor";
            this.rb_minor.UseVisualStyleBackColor = true;
            // 
            // rb_serious
            // 
            this.rb_serious.AutoSize = true;
            this.rb_serious.Location = new System.Drawing.Point(12, 47);
            this.rb_serious.Name = "rb_serious";
            this.rb_serious.Size = new System.Drawing.Size(60, 17);
            this.rb_serious.TabIndex = 2;
            this.rb_serious.TabStop = true;
            this.rb_serious.Text = "Serious";
            this.rb_serious.UseVisualStyleBackColor = true;
            // 
            // rb_inferno
            // 
            this.rb_inferno.AutoSize = true;
            this.rb_inferno.Location = new System.Drawing.Point(12, 83);
            this.rb_inferno.Name = "rb_inferno";
            this.rb_inferno.Size = new System.Drawing.Size(58, 17);
            this.rb_inferno.TabIndex = 3;
            this.rb_inferno.TabStop = true;
            this.rb_inferno.Text = "Inferno";
            this.rb_inferno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 192);
            this.Controls.Add(this.rb_inferno);
            this.Controls.Add(this.rb_serious);
            this.Controls.Add(this.rb_minor);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Fire Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_minor;
        private System.Windows.Forms.RadioButton rb_serious;
        private System.Windows.Forms.RadioButton rb_inferno;
    }
}

