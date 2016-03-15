using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._1_Animal_World
{
    class Bison : Animal
    {
        public Bison()
        {
            name = "Bison";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("bison.jpg");
        }
    }
}
