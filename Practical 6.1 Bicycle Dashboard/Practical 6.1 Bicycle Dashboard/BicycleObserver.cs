using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_6._1_Bicycle_Dashboard
{
    public abstract class BicycleObserver : IObserver
    {
        protected double currentComputedValue;
        protected Label displayLabel;
        protected Bicycle bikeSubject;

        public BicycleObserver(Label displayLabel, Bicycle bikeSubject)
        {
            this.displayLabel = displayLabel;
            currentComputedValue = 0;
            this.bikeSubject = bikeSubject;

            bikeSubject.AddObserver(this);
        }

        public virtual void Update(int currentSpeed)
        {
            currentComputedValue = currentSpeed;
        }

        public void DisplayData()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }
}
