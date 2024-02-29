using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_olusdurma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Oluşturacaginiz Kodu Giriniz", "EROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Zen.Barcode.Code128BarcodeDraw bar = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = bar.Draw(textBox1.Text, 35);
                timer1.Start();
                label2.Visible = true;
            }
           
            
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if(a == 5)
            {
                label2.Visible = false;
            }
        }
    }
}
