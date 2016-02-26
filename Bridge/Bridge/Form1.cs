using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public partial class Form1 : Form
    {
        Manager manager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new Manager();
            PrintResults();
        }

        public void PrintResults()
        {
            List<string> results = manager.RevealHands();
            listBox1.Items.Add("***************");
            for (int i = 0; i < results.Count; i++)
            {
                listBox1.Items.Add(results[i]);
            }
            //add player Name
            //add 4 lines of score, one for each suit
            //add HCP

            //int nPlayers = manager.
            //manager.RevealHand();
        }
    }
}
