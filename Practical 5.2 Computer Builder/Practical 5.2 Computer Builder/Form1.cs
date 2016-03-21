using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_5._2_Computer_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IMachineMaker machineMaker;

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if(rb_game.Checked)
            {
                machineMaker = new GameMachineMaker();
            }
            else if(rb_business.Checked)
            {
                machineMaker = new BusinessMachineMaker();
            }
            else if(rb_laptop.Checked)
            {
                machineMaker = new LaptopMachineMaker();
            }
            else
            {
                machineMaker = new MultimediaMachineMaker();
            }

            MachineSpecPrinter specPrinter = new MachineSpecPrinter(machineMaker, lb_specs);
            specPrinter.printSpec();
        }
    }
}
