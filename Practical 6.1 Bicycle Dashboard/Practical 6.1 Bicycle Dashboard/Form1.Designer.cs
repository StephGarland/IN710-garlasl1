namespace Practical_6._1_Bicycle_Dashboard
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
            this.btn_ChangeSpeed = new System.Windows.Forms.Button();
            this.tb_speedInput = new System.Windows.Forms.TextBox();
            this.gb_RPM = new System.Windows.Forms.GroupBox();
            this.gb_Calories = new System.Windows.Forms.GroupBox();
            this.gb_KMs = new System.Windows.Forms.GroupBox();
            this.lbl_RPM = new System.Windows.Forms.Label();
            this.lbl_Calories = new System.Windows.Forms.Label();
            this.lbl_KMs = new System.Windows.Forms.Label();
            this.gb_RPM.SuspendLayout();
            this.gb_Calories.SuspendLayout();
            this.gb_KMs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ChangeSpeed
            // 
            this.btn_ChangeSpeed.Location = new System.Drawing.Point(132, 12);
            this.btn_ChangeSpeed.Name = "btn_ChangeSpeed";
            this.btn_ChangeSpeed.Size = new System.Drawing.Size(75, 39);
            this.btn_ChangeSpeed.TabIndex = 0;
            this.btn_ChangeSpeed.Text = "Change Speed";
            this.btn_ChangeSpeed.UseVisualStyleBackColor = true;
            this.btn_ChangeSpeed.Click += new System.EventHandler(this.btn_ChangeSpeed_Click);
            // 
            // tb_speedInput
            // 
            this.tb_speedInput.Location = new System.Drawing.Point(12, 22);
            this.tb_speedInput.Name = "tb_speedInput";
            this.tb_speedInput.Size = new System.Drawing.Size(114, 20);
            this.tb_speedInput.TabIndex = 1;
            // 
            // gb_RPM
            // 
            this.gb_RPM.Controls.Add(this.lbl_RPM);
            this.gb_RPM.Location = new System.Drawing.Point(12, 87);
            this.gb_RPM.Name = "gb_RPM";
            this.gb_RPM.Size = new System.Drawing.Size(195, 72);
            this.gb_RPM.TabIndex = 2;
            this.gb_RPM.TabStop = false;
            this.gb_RPM.Text = "RPM";
            // 
            // gb_Calories
            // 
            this.gb_Calories.Controls.Add(this.lbl_Calories);
            this.gb_Calories.Location = new System.Drawing.Point(12, 165);
            this.gb_Calories.Name = "gb_Calories";
            this.gb_Calories.Size = new System.Drawing.Size(195, 72);
            this.gb_Calories.TabIndex = 3;
            this.gb_Calories.TabStop = false;
            this.gb_Calories.Text = "Calories per Hour";
            // 
            // gb_KMs
            // 
            this.gb_KMs.Controls.Add(this.lbl_KMs);
            this.gb_KMs.Location = new System.Drawing.Point(12, 243);
            this.gb_KMs.Name = "gb_KMs";
            this.gb_KMs.Size = new System.Drawing.Size(195, 72);
            this.gb_KMs.TabIndex = 4;
            this.gb_KMs.TabStop = false;
            this.gb_KMs.Text = "Kms per Hour";
            // 
            // lbl_RPM
            // 
            this.lbl_RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RPM.Location = new System.Drawing.Point(6, 20);
            this.lbl_RPM.Name = "lbl_RPM";
            this.lbl_RPM.Size = new System.Drawing.Size(183, 49);
            this.lbl_RPM.TabIndex = 0;
            this.lbl_RPM.Text = "0";
            this.lbl_RPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Calories
            // 
            this.lbl_Calories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calories.Location = new System.Drawing.Point(6, 16);
            this.lbl_Calories.Name = "lbl_Calories";
            this.lbl_Calories.Size = new System.Drawing.Size(183, 49);
            this.lbl_Calories.TabIndex = 1;
            this.lbl_Calories.Text = "0";
            this.lbl_Calories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KMs
            // 
            this.lbl_KMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KMs.Location = new System.Drawing.Point(6, 16);
            this.lbl_KMs.Name = "lbl_KMs";
            this.lbl_KMs.Size = new System.Drawing.Size(183, 49);
            this.lbl_KMs.TabIndex = 2;
            this.lbl_KMs.Text = "0";
            this.lbl_KMs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 321);
            this.Controls.Add(this.gb_KMs);
            this.Controls.Add(this.gb_Calories);
            this.Controls.Add(this.gb_RPM);
            this.Controls.Add(this.tb_speedInput);
            this.Controls.Add(this.btn_ChangeSpeed);
            this.Name = "Form1";
            this.Text = "Bicycle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_RPM.ResumeLayout(false);
            this.gb_Calories.ResumeLayout(false);
            this.gb_KMs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeSpeed;
        private System.Windows.Forms.TextBox tb_speedInput;
        private System.Windows.Forms.GroupBox gb_RPM;
        private System.Windows.Forms.Label lbl_RPM;
        private System.Windows.Forms.GroupBox gb_Calories;
        private System.Windows.Forms.Label lbl_Calories;
        private System.Windows.Forms.GroupBox gb_KMs;
        private System.Windows.Forms.Label lbl_KMs;
    }
}

