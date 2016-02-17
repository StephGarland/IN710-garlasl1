using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoToOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TwoToOne();
        }

        public void TwoToOne()
        {
            const int columnCount = 4;
            const int rowCount = 2;

            Char[] oneDimensional = new Char[columnCount * rowCount]; //size 8
            Char[,] twoDimensional = new Char[columnCount, rowCount]
                  { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };

            // convert to one dimension
            for (int c = 0; c < columnCount; c++) //cycle through each column (4)

                for (int r = 0; r < rowCount; r++) //go through each row (2)
                {
                   //current one dimensional array slot = twoDimensional[current column, current row]
                    oneDimensional[rowCount * c + r] = twoDimensional[c, r];
                }

            //printing one dimensional array
            for (int i = 0; i < columnCount * rowCount; i++)
                listBox1.Items.Add(oneDimensional[i]);
    }
    }
}
