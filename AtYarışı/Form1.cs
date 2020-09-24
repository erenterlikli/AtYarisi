using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciuzaklik, ikinciuzaklik, ucuncuuzaklik;
        Random rnd = new Random();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label6.Text);
            derece++;
            label6.Text = derece.ToString();

            int birincigenislik, ikincigenislik, ucuncugenislik;
            birincigenislik = pictureBox1.Width;
            ikincigenislik = pictureBox2.Width;
            ucuncugenislik = pictureBox3.Width;

            int bitisuzaklik = label4.Left;

            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 15);

            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox3.Left+5)
            {
                label5.Text = "1.At Liderliği Aldı!";
            }

            if(pictureBox2.Left>pictureBox1.Left+5 && pictureBox2.Left>pictureBox3.Left+5)
            {
                label5.Text = "2.At Önde Gidiyor!";
            }
            if(pictureBox3.Left>pictureBox2.Left+5 && pictureBox3.Left>pictureBox1.Left+5)
            {
                label5.Text = "3.At Atağa Geçti!";
            }
            if(birincigenislik+pictureBox1.Left>=bitisuzaklik)
                {
                timer1.Enabled = false;
                label5.Text = "1.At Yarışı Kazandı!";
            }
            if(ikincigenislik+pictureBox2.Left>=bitisuzaklik)
            {
              timer1.Enabled = false;
            label5.Text = "2.At Yarışı Kazandı!";
            }

            if(ucuncugenislik+pictureBox3.Left>=bitisuzaklik)
            {
             timer1.Enabled = false;
                label5.Text = "3.At Yarışı Kazandı!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciuzaklik = pictureBox1.Left;
            ikinciuzaklik = pictureBox2.Left;
            ucuncuuzaklik = pictureBox3.Left;
          
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             }
    }
}
