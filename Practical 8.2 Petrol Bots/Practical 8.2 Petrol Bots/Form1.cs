using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_8._2_Petrol_Bots
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Ship ship;

        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            ship = new Ship();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            ship.Update();
            ship.Draw(graphics);
        }

        
    }
}
