﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_6._1_Bicycle_Dashboard
{
    class KMsObserver : BicycleObserver
    {
        public KMsObserver(Label displayLabel, Bicycle bikeSubject)
            : base(displayLabel, bikeSubject)
        {
        }

        public override void Update(int currentSpeed)
        {
            currentComputedValue = 0.000205 * currentSpeed * 60;
        }
    }
}
