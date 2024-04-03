using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciat, ikinciat, ucuncuat;
        Random rastgele = new Random();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciat = pictureBox1.Left;
            ikinciat = pictureBox2.Left;
            ucuncuat = pictureBox3.Left;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;

            int bitisuzakligi = panel1.Left;


            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (birinciatgenislik + pictureBox1.Left >= bitisuzakligi)
            {            
                timer1.Enabled = false;
                MessageBox.Show("1 numaralı at yarışı kazandı.!!!!");
            }
            if (ikinciatgenislik + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at yarışı kazandı.!!!!");
            }
            if (ucuncuatgenislik + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at yarışı kazandı.!!!!");
            }
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
