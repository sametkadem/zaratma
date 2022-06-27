using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaratmaprogrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int zar1 = rand.Next(0,6);
            int zar2 = rand.Next(0,6);

            pictureBox1.Image = ımageList1.Images[zar1];
            pictureBox2.Image = ımageList1.Images[zar2];
            sayac++;
            if(sayac >= 15)
            {
                timer1.Stop();
                button1.Enabled = true;
                sayac = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;


        }
    }
}
