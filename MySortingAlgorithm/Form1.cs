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
        List<int> same = new List<int>();
        bool resetNeeded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                listBox2.Items.Add("Unsorted List :");
            }

            if (txtVal.Text != "")
            {
                string item = txtVal.Text;
                int value;

                if (int.TryParse(item, out value))
                {
                    if (!unsorted.Contains(value))
                    {
                        unsorted.Add(value);
                        listBox1.Items.Add("Added the value " + value.ToString());
                        listBox2.Items.Add(value.ToString());
                    }
                    else
                    {
                        listBox1.Items.Add(value.ToString() + " is alreay in the list");
                    }
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
            sorted = unsorted.Distinct().ToList();

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
            listBox2.Items.Clear();
            listBox2.Items.Add("Sorted List :");

            for (int j =0; j < unsorted.Count();j++)
            {
                listBox2.Items.Add(sorted[j]);
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
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            btnAdd.Visible = true;
            btnSort.Visible = true;
            btnReset.Visible = false;
            resetNeeded = false;

            unsorted.Clear();
            sorted.Clear();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {}
    }
}