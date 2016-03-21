using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._1_Animal_World
{
    class Echidna : Animal
    {
        public Echidna()
        {
            name = "Echidna";
            family = "Insectivore";
            food = "Ants";
            image = new Bitmap("echidna.jpg");
        }
    }
}
