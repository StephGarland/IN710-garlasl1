namespace Practical_5._1_Animal_World
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
            this.listBox_animalDescriptions = new System.Windows.Forms.ListBox();
            this.btn_NorthAmerica = new System.Windows.Forms.Button();
            this.btn_Australia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_animalDescriptions
            // 
            this.listBox_animalDescriptions.FormattingEnabled = true;
            this.listBox_animalDescriptions.Location = new System.Drawing.Point(210, 12);
            this.listBox_animalDescriptions.Name = "listBox_animalDescriptions";
            this.listBox_animalDescriptions.Size = new System.Drawing.Size(238, 316);
            this.listBox_animalDescriptions.TabIndex = 0;
            // 
            // btn_NorthAmerica
            // 
            this.btn_NorthAmerica.Location = new System.Drawing.Point(210, 352);
            this.btn_NorthAmerica.Name = "btn_NorthAmerica";
            this.btn_NorthAmerica.Size = new System.Drawing.Size(103, 23);
            this.btn_NorthAmerica.TabIndex = 1;
            this.btn_NorthAmerica.Text = "North America";
            this.btn_NorthAmerica.UseVisualStyleBackColor = true;
            this.btn_NorthAmerica.Click += new System.EventHandler(this.btn_NorthAmerica_Click);
            // 
            // btn_Australia
            // 
            this.btn_Australia.Location = new System.Drawing.Point(373, 352);
            this.btn_Australia.Name = "btn_Australia";
            this.btn_Australia.Size = new System.Drawing.Size(75, 23);
            this.btn_Australia.TabIndex = 2;
            this.btn_Australia.Text = "Australia";
            this.btn_Australia.UseVisualStyleBackColor = true;
            this.btn_Australia.Click += new System.EventHandler(this.btn_Australia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 511);
            this.Controls.Add(this.btn_Australia);
            this.Controls.Add(this.btn_NorthAmerica);
            this.Controls.Add(this.listBox_animalDescriptions);
            this.Name = "Form1";
            this.Text = "Animal World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_animalDescriptions;
        private System.Windows.Forms.Button btn_NorthAmerica;
        private System.Windows.Forms.Button btn_Australia;
    }
}

