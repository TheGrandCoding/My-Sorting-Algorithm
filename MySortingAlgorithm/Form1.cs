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
        bool resetNeeded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVal.Text != "")
            {
                string item = txtVal.Text;
                int value;
                if (int.TryParse(item, out value))
                {
                    unsorted.Add(value);
                    listBox1.Items.Add("Added the value " + value.ToString());
                }
                else
                {
                    listBox1.Items.Add("That's not a valid input");
                }
            }
            else
            {
                listBox1.Items.Add("That's not a valid input");
            }
            txtVal.Clear();
            txtVal.Focus();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            foreach (int z in unsorted)
            {
                sorted.Add(z);
            }

            foreach (int x in unsorted)
            {
                int i = 0;
                int oddCounter = 0;
                foreach (int y in unsorted)
                {
                    if (x > y)
                    {
                        i += 1;
                    }
                    else if (x == y)
                    {
                        if (oddCounter > 1)
                        {
                            //odd.Add(x);
                        }
                    }
                }
                sorted[i] = x;
            }          

            listBox1.Items.Add("The sorted list is :");
            foreach (int j in sorted)
            {
                listBox1.Items.Add(j);
            }
            resetNeeded = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (resetNeeded)
            {
                btnAdd.Visible = false;
                btnSort.Visible = false;
                btnReset.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnSort.Visible = true;
            btnReset.Visible = false;
            resetNeeded = false;

            unsorted.Clear();
            sorted.Clear();
            //odd.Clear();
        }
    }
}