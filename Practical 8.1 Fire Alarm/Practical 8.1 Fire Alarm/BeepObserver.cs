using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8._1_Fire_Alarm
{
    public class BeepObserver : InstructionsObserver
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        public BeepObserver(FireAlarmSubject subject)
            : base(subject)
        {

        }

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    Beep(200, 1000);
                    break;
                case EFireCategory.SERIOUS:
                    Beep(300, 1000);
                    break;
                case EFireCategory.INFERNO:
                    Beep(400, 1000);
                    break;
            }       
        }
    }
}
