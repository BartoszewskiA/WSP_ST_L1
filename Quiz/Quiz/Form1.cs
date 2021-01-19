using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        const string PLIK = "pytania.txt";
        
        List<string> pytania = new List<string>();
        List<string> odpowiedzi = new List<string>();
        List<int> wyniki = new List<int>();
        int numerPytania =0;
        int odpowiedziDobre = 0;
        int odpowiedziZle = 0;
        
        public Form1()
        {
            InitializeComponent();
            wczytajPlik();
            wypiszPytanie();
        }

        private void wypiszPytanie()
        {
            textBox1.Text = odpowiedziDobre.ToString();
            textBox2.Text = odpowiedziZle.ToString();
            richTextBox1.Text = pytania[numerPytania];
            richTextBox2.Text = odpowiedzi[numerPytania];
        }

        private void wczytajPlik()
        {
            string s = "";
            try
            {
                FileStream fs = new FileStream(PLIK, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    pytania.Add(sr.ReadLine());
                    s = "a) " +
                        sr.ReadLine() +
                        "\n" +
                        "b) " +
                        sr.ReadLine() +
                        "\n" +
                        "c) " +
                        sr.ReadLine();
                    odpowiedzi.Add(s);

                    wyniki.Add(int.Parse(sr.ReadLine()));
                }
                sr.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Błąd pliku\n\n" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int naszOdp = 0;
            if (radioButton1.Checked) naszOdp = 1;
            else if (radioButton2.Checked) naszOdp = 2;
            else if (radioButton3.Checked) naszOdp = 3;

            if (naszOdp == wyniki[numerPytania]) odpowiedziDobre++;
            else odpowiedziZle++;
            numerPytania++;
            wypiszPytanie();
        }
    }
}
