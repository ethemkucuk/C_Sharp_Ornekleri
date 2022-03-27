using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgen_Alan_Cevre_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisaKenar, uzunKenar, sonuc = 0;
            kisaKenar = Convert.ToInt32(textBox1.Text);
            uzunKenar = Convert.ToInt32(textBox2.Text);

            if(radioButton1.Checked)
            {
               sonuc= kisaKenar* uzunKenar;
            }
            else if(radioButton2.Checked)
            {
                sonuc = (uzunKenar + kisaKenar) * 2;
            }
            else
            {
                MessageBox.Show("Geçerli bir sayı giriniz! ");
            }
            label3.Text = "Sonuç : " + sonuc;
        }
    }
}
