using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_10._2_Lightning_Strikes
{
    public partial class Form1 : Form
    {
        LightningStrikeDbDataContext lightningDb;

        public Form1()
        {
            InitializeComponent();
            lightningDb = new LightningStrikeDbDataContext();
        }

        private void btn_avgIntensity_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            double average = lightningDb.tblStrikes
                    .Average(s => (double)s.strikeIntensity);

            listBox1.Items.Add("Average Intensity:\t" + average);         
        }

        private void btn_3LargestFires_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_imageInfo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_FiresCaused_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
