using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_6._1_Bicycle_Dashboard
{
    public partial class Form1 : Form
    {
        Bicycle subject;
        BicycleObserver rpm_observer;
        BicycleObserver calorie_observer;
        BicycleObserver kms_observer;

        public Form1()
        {
            InitializeComponent();
            subject = new Bicycle();

            rpm_observer = new RPMObserver(lbl_RPM, subject);
            calorie_observer = new CalorieObserver(lbl_Calories, subject);
            kms_observer = new KMsObserver(lbl_KMs, subject);
        }

        private void btn_ChangeSpeed_Click(object sender, EventArgs e)
        {
            int speed = Int32.Parse(tb_speedInput.Text);
            
            
            rpm_observer.Update(speed);
            rpm_observer.DisplayData();
            calorie_observer.Update(speed);
            calorie_observer.DisplayData();
            kms_observer.Update(speed);
            kms_observer.DisplayData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
