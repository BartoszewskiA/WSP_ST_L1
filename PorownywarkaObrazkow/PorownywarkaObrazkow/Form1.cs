using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorownywarkaObrazkow
{
    public partial class Form1 : Form
    {
        Form2 oknoTAK; 
        Form3 oknoNIE;
        
        public Form1()
        {
            InitializeComponent();
            oknoTAK = new Form2();
            oknoNIE = new Form3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == openFileDialog2.FileName) //porównujemy wczyane pliki
            {
                oknoTAK.ShowDialog();
            }
            else
            {
                oknoNIE.ShowDialog();
            }
        }
    }
}

// Pliki JPEG (*.jpg)|*.jpg|Pliki BMP (*.bmp)|*.bmp|Wszystkie pliki (*.*)|*.*
