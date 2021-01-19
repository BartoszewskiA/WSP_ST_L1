using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprawdzaniePoprawnDanychOknaDial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool sprawdzNazwisko()
        {
            bool wynik = true;
            string s = textBox2.Text;

            if(s.Length==0) 
            {
                MessageBox.Show("Pole Nazwisko jest obowiązkowe", "Błąd");
                wynik = false;
            } else if(s.IndexOf(' ')>=0)
            {
                if(MessageBox.Show("Pole Nazwisko musi zawierać jeden wyraz", "Błąd",MessageBoxButtons.OKCancel)==DialogResult.Cancel)
                    textBox2.Text="";
                
                wynik = false;
            }
            

            return wynik;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            if (sprawdzNazwisko())
                label4.Text = "OK";
        }
    }
}
