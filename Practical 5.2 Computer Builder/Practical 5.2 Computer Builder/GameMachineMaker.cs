using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._2_Computer_Builder
{
    class GameMachineMaker : IMachineMaker
    {
        public CPU makeCPU()
        {
            string description = "GameCore 8.9 GHz";
            double price = 599.99;
            CPU cpu = new CPU(description, price);
            return cpu;
        }

        public GraphicsCard makeGraphicsCard()
        {
            string description = "GeForce 378";
            double price = 199.99;
            GraphicsCard graphicsCard = new GraphicsCard(description, price);
            return graphicsCard;
        }

        public Memory makeMemory()
        {
            string description = "16GB RAM";
            double price = 599.99;
            Memory memory = new Memory(description, price);
            return memory;
        }

        public Monitor makeMonitor()
        {
            string description = "38inch LCD";
            double price = 299.99;
            Monitor monitor = new Monitor(description, price);
            return monitor;
        }
    }
}
