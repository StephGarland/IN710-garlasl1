using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6._1_Bicycle_Dashboard
{
    public interface IObserver
    {
        void Update(int currentSpeed);
        void DisplayData();
    }
}
