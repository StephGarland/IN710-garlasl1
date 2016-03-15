using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._1_Animal_World
{
    public interface IAnimalFactory
    {
        Animal createAnimal(int animalCode);
    }
}
