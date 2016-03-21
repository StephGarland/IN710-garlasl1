using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._2_Computer_Builder
{
    class BusinessMachineMaker : IMachineMaker
    {
        public CPU makeCPU()
        {
            string description = "BusinessCore 1.2 GHz";
            double price = 746.99;
            CPU cpu = new CPU(description, price);
            return cpu;
        }

        public GraphicsCard makeGraphicsCard()
        {
            string description = "GeForce 338";
            double price = 150.92;
            GraphicsCard graphicsCard = new GraphicsCard(description, price);
            return graphicsCard;
        }

        public Memory makeMemory()
        {
            string description = "2GB RAM";
            double price = 678.23;
            Memory memory = new Memory(description, price);
            return memory;
        }

        public Monitor makeMonitor()
        {
            string description = "18inch LCD";
            double price = 129.99;
            Monitor monitor = new Monitor(description, price);
            return monitor;
        }
    }
}
