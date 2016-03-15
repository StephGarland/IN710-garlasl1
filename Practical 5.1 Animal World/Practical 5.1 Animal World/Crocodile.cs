using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._1_Animal_World
{
    class Crocodile : Animal
    {
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "Children";
            image = new Bitmap("bison.jpg");
        }
    }
}
