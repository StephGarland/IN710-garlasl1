﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._1_Animal_World
{
    class Kangaroo : Animal
    {
        public Kangaroo()
        {
            name = "Kangaroo";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("kangaroo.jpg");
        }
    }
}
