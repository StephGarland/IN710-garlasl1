namespace Practical_5._2_Computer_Builder
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
            this.btn_Print = new System.Windows.Forms.Button();
            this.gb_MachineType = new System.Windows.Forms.GroupBox();
            this.rb_multimedia = new System.Windows.Forms.RadioButton();
            this.rb_business = new System.Windows.Forms.RadioButton();
            this.rb_game = new System.Windows.Forms.RadioButton();
            this.lb_specs = new System.Windows.Forms.ListBox();
            this.gb_MachineType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(13, 13);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "Print Spec";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // gb_MachineType
            // 
            this.gb_MachineType.Controls.Add(this.rb_multimedia);
            this.gb_MachineType.Controls.Add(this.rb_business);
            this.gb_MachineType.Controls.Add(this.rb_game);
            this.gb_MachineType.Location = new System.Drawing.Point(13, 85);
            this.gb_MachineType.Name = "gb_MachineType";
            this.gb_MachineType.Size = new System.Drawing.Size(156, 171);
            this.gb_MachineType.TabIndex = 1;
            this.gb_MachineType.TabStop = false;
            this.gb_MachineType.Text = "Machine Type";
            // 
            // rb_multimedia
            // 
            this.rb_multimedia.AutoSize = true;
            this.rb_multimedia.Location = new System.Drawing.Point(7, 103);
            this.rb_multimedia.Name = "rb_multimedia";
            this.rb_multimedia.Size = new System.Drawing.Size(75, 17);
            this.rb_multimedia.TabIndex = 2;
            this.rb_multimedia.TabStop = true;
            this.rb_multimedia.Text = "Multimedia";
            this.rb_multimedia.UseVisualStyleBackColor = true;
            // 
            // rb_business
            // 
            this.rb_business.AutoSize = true;
            this.rb_business.Location = new System.Drawing.Point(7, 66);
            this.rb_business.Name = "rb_business";
            this.rb_business.Size = new System.Drawing.Size(67, 17);
            this.rb_business.TabIndex = 1;
            this.rb_business.TabStop = true;
            this.rb_business.Text = "Business";
            this.rb_business.UseVisualStyleBackColor = true;
            // 
            // rb_game
            // 
            this.rb_game.AutoSize = true;
            this.rb_game.Location = new System.Drawing.Point(7, 33);
            this.rb_game.Name = "rb_game";
            this.rb_game.Size = new System.Drawing.Size(53, 17);
            this.rb_game.TabIndex = 0;
            this.rb_game.TabStop = true;
            this.rb_game.Text = "Game";
            this.rb_game.UseVisualStyleBackColor = true;
            // 
            // lb_specs
            // 
            this.lb_specs.FormattingEnabled = true;
            this.lb_specs.Location = new System.Drawing.Point(187, 13);
            this.lb_specs.Name = "lb_specs";
            this.lb_specs.Size = new System.Drawing.Size(220, 238);
            this.lb_specs.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 269);
            this.Controls.Add(this.lb_specs);
            this.Controls.Add(this.gb_MachineType);
            this.Controls.Add(this.btn_Print);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_MachineType.ResumeLayout(false);
            this.gb_MachineType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.GroupBox gb_MachineType;
        private System.Windows.Forms.RadioButton rb_multimedia;
        private System.Windows.Forms.RadioButton rb_business;
        private System.Windows.Forms.RadioButton rb_game;
        private System.Windows.Forms.ListBox lb_specs;
    }
}

