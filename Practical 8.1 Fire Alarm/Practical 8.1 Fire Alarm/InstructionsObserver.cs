﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_8._1_Fire_Alarm
{
    public class InstructionsObserver : FireAlarmObserverBase
    {
        public InstructionsObserver(FireAlarmSubject subject)
            : base(subject)
        {

        }

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            String message = "Fire is " + fe.FireCategory.ToString() + ". ";
            switch(fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    message += "Use a fire extinguisher.";
                    break;
                case EFireCategory.SERIOUS:
                    message += "Call the Fire Department.";
                    break;
                case EFireCategory.INFERNO:
                    message += "Evacuate Immediately.";
                    break;
            }

            MessageBox.Show(message);
        }
    }
}
