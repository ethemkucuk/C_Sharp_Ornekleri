using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm_Yapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = "Alarm Kuruldu";
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime alarmTime = dateTimePicker1.Value;

            if(dateTime.Hour == alarmTime.Hour && dateTime.Minute == alarmTime.Minute && dateTime.Second == alarmTime.Second)
            {
                timer1.Stop();
                label2.Text = "ALARM ÇALIYOR !!!! ";

                player.SoundLocation = @"D:\Downloads\Music\alarm.wav";
                player.PlayLooping();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            label2.Text = "Alarm Durduruldu";
            button1.Enabled=true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "...........................";
        }
    }
}
