using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Kontrolü
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void klavye_yakala(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pictureBox1.Top -= 10;
            }
            if (e.KeyCode == Keys.S)
            {
                pictureBox1.Top += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                pictureBox1.Left -= 10;
            }
            if (e.KeyCode == Keys.D)
            {
                pictureBox1.Left += 10;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
