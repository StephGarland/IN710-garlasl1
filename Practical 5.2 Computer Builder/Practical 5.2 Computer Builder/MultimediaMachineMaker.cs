using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._2_Computer_Builder
{
    class MultimediaMachineMaker : IMachineMaker
    {
        public CPU makeCPU()
        {
            string description = "MultimediaCore 2.4 GHz";
            double price = 286.99;
            CPU cpu = new CPU(description, price);
            return cpu;
        }

        public GraphicsCard makeGraphicsCard()
        {
            string description = "Radeon 376";
            double price = 946.92;
            GraphicsCard graphicsCard = new GraphicsCard(description, price);
            return graphicsCard;
        }

        public Memory makeMemory()
        {
            string description = "12GB RAM";
            double price = 678.23;
            Memory memory = new Memory(description, price);
            return memory;
        }

        public Monitor makeMonitor()
        {
            string description = "68inch LCD";
            double price = 2299.99;
            Monitor monitor = new Monitor(description, price);
            return monitor;
        }
    }
}
