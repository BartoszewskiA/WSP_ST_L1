using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03p01
{
    public partial class Form1 : Form
    {
        //string u1 = "Kowalski";
        //int p1 = 111;
        string[] users = new string[] {"Kowalski",
                                       "Nowak",
                                       "Iksiński",
                                       "Ktoś",
                                       "KtośInny"};

        int[] pin = new int[] { 111, 222, 333, 444, 555 };

         
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            //int p = int.Parse(textBox2.Text);
            int p, temp;
            if (int.TryParse(textBox2.Text, out temp)) p = temp;
            else p = 0;
            //if (s == u1 && p == p1)
            //    label3.Text = "YES";
            //else
            //   label3.Text = "NO";
            bool dostep = false;
            for(int i=0; i<users.Length; i++)
                if (s==users[i] && p==pin[i])
                {
                    dostep = true;
                    break;
                }
            if(dostep)
            {
                label3.Text = "YES";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.Text = "NO";
                label3.ForeColor = Color.Red;
            }

        }
    }
}
