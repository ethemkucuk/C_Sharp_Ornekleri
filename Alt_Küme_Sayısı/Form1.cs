using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alt_Küme_Sayısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1,sayi2,sayi3;
        int[] dizi;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToInt32(sayi1);
            
        }
    }
}
