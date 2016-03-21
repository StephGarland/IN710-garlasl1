using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_5._1_Animal_World
{
    public partial class Form1 : Form
    {
        Random rGen;
        Graphics canvas;

        int nAnimalTypes = 4;

        Continent northAmerica;
        Continent australia;

        public Form1()
        {
            InitializeComponent();
            rGen = new Random();
            canvas = CreateGraphics();
            
            northAmerica = new NorthAmerica(listBox_animalDescriptions, rGen, nAnimalTypes, canvas);
            australia = new Australia(listBox_animalDescriptions, rGen, nAnimalTypes, canvas);
        }

        private void btn_NorthAmerica_Click(object sender, EventArgs e)
        {
            this.Refresh();
            listBox_animalDescriptions.Items.Clear();
            northAmerica.runSimulation();
        }

        private void btn_Australia_Click(object sender, EventArgs e)
        {
            this.Refresh();
            listBox_animalDescriptions.Items.Clear();
            australia.runSimulation();
        }
    }
}
