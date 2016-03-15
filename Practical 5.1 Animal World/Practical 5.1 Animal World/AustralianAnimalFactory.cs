using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._1_Animal_World
{
    class AustralianAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;
            switch (animalCode)
            {
                case 0:
                    newAnimal = new Crocodile();
                    break;
                case 1:
                    newAnimal = new Koala();
                    break;
                case 2:
                    newAnimal = new Kangaroo();
                    break;
            }
            return newAnimal;
        }
    }
}
