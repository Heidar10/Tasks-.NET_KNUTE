using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int mill, cek, min;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            cek = 0;
            mill = 0;
            min = 0;
            label2.Text = "Время : " + min + " : " + cek + " : " + mill;
            timer2.Enabled = false;
           

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mill += 1;
            if (mill == 10)
            {
                mill = 0;
                cek += 1;

            }
            if (cek == 60)
            {
                cek = 0;
                min += 1;

            }
            // label2.Text = "Время:Минуты" + min + "Секунды" + cek + "Миллисекунды" + mill;
            label2.Text = "Время : " + min + " : " + cek + " : " + mill;

        }
    }
}
