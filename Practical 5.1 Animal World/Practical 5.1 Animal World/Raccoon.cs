using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._1_Animal_World
{
    class Raccoon : Animal
    {
        public Raccoon()
        {
            name = "Raccoon";
            family = "Omnivore";
            food = "Garbage";
            image = new Bitmap("raccoon.jpg");
        }
    }
}
