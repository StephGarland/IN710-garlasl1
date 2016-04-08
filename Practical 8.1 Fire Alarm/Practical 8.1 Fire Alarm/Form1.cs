using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_8._1_Fire_Alarm
{
    public partial class Form1 : Form
    {
        FireAlarmSubject subject;
        BeepObserver beep;
        InstructionsObserver instruct;

        public Form1()
        {
            InitializeComponent();
            subject = new FireAlarmSubject();
            beep = new BeepObserver(subject);
            instruct = new InstructionsObserver(subject);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EFireCategory fireIntensity = EFireCategory.SERIOUS;
            if (rb_minor.Checked == true)
            {
                fireIntensity = EFireCategory.MINOR;
            }
            else if (rb_serious.Checked == true)
            {
                fireIntensity = EFireCategory.SERIOUS;
            }
            else if (rb_inferno.Checked == true)
            {
                fireIntensity = EFireCategory.INFERNO;
            }

            subject.OnFireEvent(fireIntensity);
        }
    }
}
