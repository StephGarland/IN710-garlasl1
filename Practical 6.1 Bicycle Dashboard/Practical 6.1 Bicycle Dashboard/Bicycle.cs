using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6._1_Bicycle_Dashboard
{
    public class Bicycle : ISubject
    {
        private List<IObserver> observerList;
        private int currentSpeed;

        public Bicycle()
        {
            observerList = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver current in observerList)
            {
                {
                    current.Update(currentSpeed);
                }
            }
        }
    }
}
