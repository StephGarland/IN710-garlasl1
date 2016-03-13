namespace Practical_4._0_Encryption_Tool
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
            this.gb_EncryptionAlg = new System.Windows.Forms.GroupBox();
            this.rb_StringReverse = new System.Windows.Forms.RadioButton();
            this.rb_ROT13 = new System.Windows.Forms.RadioButton();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.gb_EncryptionAlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_EncryptionAlg
            // 
            this.gb_EncryptionAlg.Controls.Add(this.rb_StringReverse);
            this.gb_EncryptionAlg.Controls.Add(this.rb_ROT13);
            this.gb_EncryptionAlg.Location = new System.Drawing.Point(12, 12);
            this.gb_EncryptionAlg.Name = "gb_EncryptionAlg";
            this.gb_EncryptionAlg.Size = new System.Drawing.Size(167, 105);
            this.gb_EncryptionAlg.TabIndex = 0;
            this.gb_EncryptionAlg.TabStop = false;
            this.gb_EncryptionAlg.Text = "Encryption Algorithm";
            // 
            // rb_StringReverse
            // 
            this.rb_StringReverse.AutoSize = true;
            this.rb_StringReverse.Location = new System.Drawing.Point(7, 61);
            this.rb_StringReverse.Name = "rb_StringReverse";
            this.rb_StringReverse.Size = new System.Drawing.Size(95, 17);
            this.rb_StringReverse.TabIndex = 1;
            this.rb_StringReverse.TabStop = true;
            this.rb_StringReverse.Text = "String Reverse";
            this.rb_StringReverse.UseVisualStyleBackColor = true;
            this.rb_StringReverse.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_ROT13
            // 
            this.rb_ROT13.AutoSize = true;
            this.rb_ROT13.Location = new System.Drawing.Point(6, 28);
            this.rb_ROT13.Name = "rb_ROT13";
            this.rb_ROT13.Size = new System.Drawing.Size(60, 17);
            this.rb_ROT13.TabIndex = 0;
            this.rb_ROT13.TabStop = true;
            this.rb_ROT13.Text = "ROT13";
            this.rb_ROT13.UseVisualStyleBackColor = true;
            this.rb_ROT13.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(197, 158);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 1;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(282, 158);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 2;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(68, 132);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(287, 20);
            this.tb_Input.TabIndex = 3;
            // 
            // tb_Output
            // 
            this.tb_Output.Location = new System.Drawing.Point(68, 229);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.ReadOnly = true;
            this.tb_Output.Size = new System.Drawing.Size(287, 20);
            this.tb_Output.TabIndex = 4;
            // 
            // lbl_Input
            // 
            this.lbl_Input.Location = new System.Drawing.Point(30, 135);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(38, 23);
            this.lbl_Input.TabIndex = 5;
            this.lbl_Input.Text = "Input";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(23, 232);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(39, 13);
            this.lbl_Output.TabIndex = 6;
            this.lbl_Output.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 261);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.gb_EncryptionAlg);
            this.Name = "Form1";
            this.Text = "Encryption Tool";
            this.gb_EncryptionAlg.ResumeLayout(false);
            this.gb_EncryptionAlg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_EncryptionAlg;
        private System.Windows.Forms.RadioButton rb_StringReverse;
        private System.Windows.Forms.RadioButton rb_ROT13;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label lbl_Output;
    }
}

