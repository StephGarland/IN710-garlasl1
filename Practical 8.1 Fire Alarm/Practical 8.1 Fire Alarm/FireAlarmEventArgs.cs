using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8._1_Fire_Alarm
{
    public enum EFireCategory { MINOR, SERIOUS, INFERNO };
    public class FireAlarmEventArgs : EventArgs
    {
        public EFireCategory FireCategory { get; set; }

        public FireAlarmEventArgs(EFireCategory currentCategory)
        {
            FireCategory = currentCategory;
        }
    }
}
