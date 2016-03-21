using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_5._2_Computer_Builder
{
    public class MachineSpecPrinter
    {
        private IMachineMaker machineMaker;
        private ListBox listbox;

        public MachineSpecPrinter(IMachineMaker machineMaker, ListBox listbox)
        {
            this.machineMaker = machineMaker;
            this.listbox = listbox;
        }

        public void printSpec()
        {
            CPU currentCPU = machineMaker.makeCPU();
            Memory currentMemory = machineMaker.makeMemory();
            GraphicsCard currentGraphicsCard = machineMaker.makeGraphicsCard();

            double totalPrice = currentCPU.Price + currentMemory.Price + currentGraphicsCard.Price;

            listbox.Items.Clear();
            listbox.Items.Add("Price\tComponent");
            listbox.Items.Add("-----------------------------");

            listbox.Items.Add(currentCPU.Price + "\t" + currentCPU.ToString());
            listbox.Items.Add(currentMemory.Price + "\t" + currentMemory.ToString());
            listbox.Items.Add(currentGraphicsCard.Price + "\t" + currentGraphicsCard.ToString());

            listbox.Items.Add("-----------------------------");
            listbox.Items.Add("Total Price: " + totalPrice.ToString());
        }
    }
}
