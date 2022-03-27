using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Fonksiyonu_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] takimlar = { "gs", "fb", "ts", "bjk" };
            int sayi1=rnd.Next(0,6);
            int sayi2=rnd.Next(0,6);
            int takim1 = rnd.Next(takimlar.Length);
            int takim2 = rnd.Next(takimlar.Length);
           if(takim1 != takim2)
            {
                label1.Text = takimlar[takim1] + " VS " + takimlar[takim2] ;

            }
           List<string> list = new List<string>();
            list.Add(takimlar[takim1]);
            list.Add(" --------- VS---------- ");
            list.Add(takimlar[takim2]);



        }
    }
}
