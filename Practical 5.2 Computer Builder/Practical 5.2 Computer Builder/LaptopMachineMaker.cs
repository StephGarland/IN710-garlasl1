using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._2_Computer_Builder
{
    public class LaptopMachineMaker : IMachineMaker
    {
        public CPU makeCPU()
        {
            string description = "LaptopCore 1.3 GHz";
            double price = 399.99;
            CPU cpu = new CPU(description, price);
            return cpu;
        }

        public GraphicsCard makeGraphicsCard()
        {
            string description = "Radeon 123";
            double price = 139.92;
            GraphicsCard graphicsCard = new GraphicsCard(description, price);
            return graphicsCard;
        }

        public Memory makeMemory()
        {
            string description = "12GB RAM";
            double price = 578.23;
            Memory memory = new Memory(description, price);
            return memory;
        }

        public Monitor makeMonitor()
        {
            string description = "22inch LCD";
            double price = 229.99;
            Monitor monitor = new Monitor(description, price);
            return monitor;
        }
    }
}
