using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Color c = Color.Red;
            Brush b = Brushes.Black;
            Pen p = new Pen(b, 2);
            g.DrawLine(p, new Point(0, 0), new Point(100, 100));

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color c = Color.Red;
            Brush b = Brushes.Black;
            Pen p = new Pen(b, 2);
            g.DrawLine(p, new Point(0, 0), new Point(100, 100));
        }
    }
}
