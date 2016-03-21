using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._2_Computer_Builder
{
    public interface IMachineMaker
    {
        CPU makeCPU();
        Memory makeMemory();
        GraphicsCard makeGraphicsCard();
    }
}
