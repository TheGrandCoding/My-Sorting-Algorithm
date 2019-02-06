using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySortingAlgorithm
{
    public partial class Form1 : Form
    {
        List<int> unsorted = new List<int>();
        List<int> sorted = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            unsorted.Add(5);
            unsorted.Add(4);
            unsorted.Add(3);
            unsorted.Add(2);
            unsorted.Add(1);
            unsorted.Add(0);

            foreach (int a in unsorted)
            {
                sorted.Add(a);
            }

            foreach (int x in unsorted) 
            {
                int i = 0;
                foreach (int y in unsorted)
                {
                    if (x > y) 
                    {
                        i += 1;
                    }
                }
                sorted[i] = x;
            }

            foreach (int z in sorted)
            {
                listBox1.Items.Add(z);
            }
        }
    }
}
