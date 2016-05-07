namespace Practical_10._2_Lightning_Strikes
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
            this.btn_avgIntensity = new System.Windows.Forms.Button();
            this.btn_3LargestFires = new System.Windows.Forms.Button();
            this.btn_imageInfo = new System.Windows.Forms.Button();
            this.btn_FiresCaused = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_avgIntensity
            // 
            this.btn_avgIntensity.Location = new System.Drawing.Point(13, 12);
            this.btn_avgIntensity.Name = "btn_avgIntensity";
            this.btn_avgIntensity.Size = new System.Drawing.Size(213, 23);
            this.btn_avgIntensity.TabIndex = 0;
            this.btn_avgIntensity.Text = "Average Strike Intensity";
            this.btn_avgIntensity.UseVisualStyleBackColor = true;
            this.btn_avgIntensity.Click += new System.EventHandler(this.btn_avgIntensity_Click);
            // 
            // btn_3LargestFires
            // 
            this.btn_3LargestFires.Location = new System.Drawing.Point(13, 42);
            this.btn_3LargestFires.Name = "btn_3LargestFires";
            this.btn_3LargestFires.Size = new System.Drawing.Size(213, 23);
            this.btn_3LargestFires.TabIndex = 1;
            this.btn_3LargestFires.Text = "Three Largest Fires";
            this.btn_3LargestFires.UseVisualStyleBackColor = true;
            this.btn_3LargestFires.Click += new System.EventHandler(this.btn_3LargestFires_Click);
            // 
            // btn_imageInfo
            // 
            this.btn_imageInfo.Location = new System.Drawing.Point(12, 71);
            this.btn_imageInfo.Name = "btn_imageInfo";
            this.btn_imageInfo.Size = new System.Drawing.Size(214, 23);
            this.btn_imageInfo.TabIndex = 2;
            this.btn_imageInfo.Text = "Strike Info associated with Images";
            this.btn_imageInfo.UseVisualStyleBackColor = true;
            this.btn_imageInfo.Click += new System.EventHandler(this.btn_imageInfo_Click);
            // 
            // btn_FiresCaused
            // 
            this.btn_FiresCaused.Location = new System.Drawing.Point(13, 100);
            this.btn_FiresCaused.Name = "btn_FiresCaused";
            this.btn_FiresCaused.Size = new System.Drawing.Size(213, 23);
            this.btn_FiresCaused.TabIndex = 3;
            this.btn_FiresCaused.Text = "Fires Caused by Strikes";
            this.btn_FiresCaused.UseVisualStyleBackColor = true;
            this.btn_FiresCaused.Click += new System.EventHandler(this.btn_FiresCaused_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(255, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 199);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 227);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_FiresCaused);
            this.Controls.Add(this.btn_imageInfo);
            this.Controls.Add(this.btn_3LargestFires);
            this.Controls.Add(this.btn_avgIntensity);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_avgIntensity;
        private System.Windows.Forms.Button btn_3LargestFires;
        private System.Windows.Forms.Button btn_imageInfo;
        private System.Windows.Forms.Button btn_FiresCaused;
        private System.Windows.Forms.ListBox listBox1;
    }
}

