using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SortedList1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sortedSet = new SortedSet<string>();
            sortedSet.Add("c#");
            sortedSet.Add("phyton");
            sortedSet.Add("C++");
            sortedSet.Add("Java");
            sortedSet.Add("Visual Basic");
            sortedSet.Add("C");

            foreach (var item in sortedSet)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
