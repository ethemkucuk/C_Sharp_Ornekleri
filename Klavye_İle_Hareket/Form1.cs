using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klavye_İle_Hareket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void klavye_yakala(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                panel1.Top -= 20;
            }
            if(e.KeyCode == Keys.S)
            {
                panel1.Top += 20;

            }
            if (e.KeyCode == Keys.D)
            {
                panel1.Left += 20;
            }
            if(e.KeyCode == Keys.A)
            {
                panel1.Left -= 20;
            }
        }
    }
}
