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

            var largest3 = lightningDb.tblFires
                    .OrderByDescending(f => f.fireArea)
                    .Take(3);

            listBox1.Items.Add("Top 3 Largest Fires:");
            listBox1.Items.Add("");
            listBox1.Items.Add("ID:\tDate:\t\t\tLatitude:\t      Longitude:\tArea:");
            foreach (var fire in largest3)
            {
                listBox1.Items.Add(fire.fireID + "\t" + fire.fireDate + "\t" + fire.fireLatitude + "\t     " + fire.fireLongitude + "\t" + fire.fireArea);
            }

        }

        private void btn_imageInfo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var imageInfoSets = from image in lightningDb.tblPictures
                                join strike in lightningDb.tblStrikes
                                on image.strikeID equals strike.strikeID
                                select new { strike.strikeLatitude, strike.strikeLongitude, image.pictureFileName};

            listBox1.Items.Add("Longitude and Latitude of Strike Images:");
            listBox1.Items.Add("");
            listBox1.Items.Add("Longitude:       Latitude:\tImage filename:");
            foreach (var set in imageInfoSets)
            {
                listBox1.Items.Add(set.strikeLatitude + "\t        " + set.strikeLongitude + "\t" + set.pictureFileName);
            }
        }

        private void btn_FiresCaused_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var firesCausedByStrike = from fire in lightningDb.tblFires
                                      join strike in lightningDb.tblStrikes
                                      on fire.fireLongitude equals strike.strikeLongitude                                   
                                      where fire.fireDate == strike.strikeDate 
                                            &&  fire.fireLatitude == strike.strikeLatitude
                                      select new {fire.fireID, fire.fireDate, fire.fireLatitude, fire.fireLongitude, fire.fireArea, strike.strikeID};

            listBox1.Items.Add("Fires caused by Lightning Strikes:");
            listBox1.Items.Add("");
            listBox1.Items.Add("Fire ID:\tStrike ID:\t  Date:\t\t\tLatitude:\t  Longitude:\tArea:");
            foreach (var f in firesCausedByStrike)
            {
                listBox1.Items.Add(f.fireID + "\t" + f.strikeID + "\t  " + f.fireDate + "\t" + f.fireLatitude + "\t   " + f.fireLongitude + "\t\t" + f.fireArea);
            }

        }
    }
}
