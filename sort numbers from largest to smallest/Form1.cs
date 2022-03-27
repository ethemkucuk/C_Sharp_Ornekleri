using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort_numbers_from_largest_to_smallest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        // error u bulamadım
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(textBox3.Text);
            if (x >= y)
            {
                if (y >= z)
                {
                    label7.Text = "Üç sayının sıralaması: " + z + " " + y + " " + x;
                }
                else if (z >= x)
                {
                    label7.Text = "Üç sayının sıralaması: " + y + " " + x + " " + z;
                }
                else if (x > z)
                {
                    label7.Text = "Üç sayının sıralaması: " + y + " " + z + " " + x;
                }
            }
            if (y > x)
            {
                if (z >= y)
                {
                    label7.Text = "Üç sayının sıralaması: " + x + " " + y + " " + z;
                }
                else if (z >= x)
                {
                    label7.Text = "Üç sayının sıralaması: " + x + " " + z + " " + y;
                }
                else if (x > z)
                {
                    label7.Text = "Üç sayının sıralaması: " + z + " " + x + " " + y;
                }

            }
        }
    }
}
