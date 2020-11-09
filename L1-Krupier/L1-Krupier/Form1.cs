using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_Krupier
{
    public partial class Form1 : Form
    {
        Krupier krupier;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = krupier.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = krupier.wezKarte();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            krupier.potasuj();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                krupier = new Krupier(1);
            else
                krupier = new Krupier(2);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> l = krupier.wezKarty(hScrollBar1.Value);
            string s = "";
            for (int i = 0; i < l.Count(); i++)
                s = s + l[i] + " ";
            textBox1.Text = s;
        }
    }
}
