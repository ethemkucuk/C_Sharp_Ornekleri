using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metot_Kullanarak_Yazılı_Ortalaması_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public float OrtalamaHesapla(float not1, float not2)
        {
            float sonuc = (not1 + not2) / 2;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float yazili1 = Convert.ToSingle(textBox1.Text);
            float yazili2 = Convert.ToSingle(textBox2.Text);

            float ortalama = OrtalamaHesapla(yazili1, yazili2);

            label3.Text = " Ortalama  " + ortalama.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enter_click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
