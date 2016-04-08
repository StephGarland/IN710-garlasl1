using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8._1_Fire_Alarm
{
    public class FireAlarmSubject
    {
        public delegate void FireEventHandler(object fireSubject, FireAlarmEventArgs fe);
        public event FireEventHandler FireEvent;

        public void OnFireEvent(EFireCategory fCat)
        {
            FireAlarmEventArgs fe = new FireAlarmEventArgs(fCat);

            if(FireEvent != null)
            {
                FireEvent(this, fe);
            }
        }
    }
}
