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
        Graphics g;
        Brush b;
        Pen p;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();

            b = Brushes.Red;
            p = new Pen(b, 6);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawLine(p, new Point(0, 0), new Point(100, 100));
        }
    }
}
