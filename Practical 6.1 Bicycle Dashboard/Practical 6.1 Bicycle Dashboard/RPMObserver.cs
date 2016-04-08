using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_6._1_Bicycle_Dashboard
{
    public class RPMObserver : BicycleObserver
    {
        public RPMObserver(Label displayLabel, Bicycle bikeSubject)
            : base(displayLabel, bikeSubject)
        {
        }
    }
}
