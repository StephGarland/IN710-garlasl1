using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5._2_Computer_Builder
{
    public abstract class Component
    {
        string description;
        public double Price { get; }

        public Component(string description, double price)
        {
            this.description = description;
            Price = price;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
