using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tombgyakorlas
{
    public partial class Form1 : Form
    {
        int maxDb = 100;
        Random veletlen = new Random();
        int[] tomb = new int[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void Generalas() {
            for (int i = 0; i < maxDb; i++)
            {
                tomb[i] = veletlen.Next(maxDb); // 0 - maxDb-1
            }
        }
        private void Megjelenit(ListBox lista)
        {
            for (int i = 0; i < maxDb; i++)
            {
                lista.Items.Add(tomb[i]);
            }
        }


        private int Sum(int[] t)
        {
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                osszeg += t[i];
            }
            return osszeg;
        }

        private int Megszamol(int[] t)
        { /*
            int db = 0;
            for (int i = 0; i < t.Length; i++)
            {
                db++;
            }
            return db;
          */
            return t.Length;
        }

        private int Max(int[] t) {
            int x = int.MinValue;
            for (int i = 0; i < t.Length; i++)
            {
                if(t[i] > x)
                {
                    x = t[i];
                }
            }
            return x;
        }

        private int Min(int[] t)
        { int x = int.MaxValue;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < x)
                {
                    x = t[i];
                }
            }
            return x;

        }

        private int Keres(int[] t, int szam)
        {
            int x = -1;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == szam) { 
                    x = i;
                }
            }
            return x;

        }

        private void Rendez(int[] t)
        {   int s = 0;
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = i+1; j < t.Length; j++)
                {
                    if (t[i] > t[j])  // csere
                    {
                        s = t[i];
                        t[i] = t[j];
                        t[j] = s;
                    }

                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Generalas();
            Megjelenit(listBox1);
            textBox1.Text += "Összeg: "+Sum(tomb)+"\r\n";
            textBox1.Text += "Darabszám: " + Megszamol(tomb) + "\r\n";
            textBox1.Text += "Min: " + Min(tomb) + "\r\n";
            textBox1.Text += "Max: " + Max(tomb) + "\r\n";
            textBox1.Text += "Keres 50 : " + Keres(tomb , 50) + "\r\n";
            textBox1.Text += "Keres 100 : " + Keres(tomb , 100) + "\r\n";
            Rendez(tomb);
            Megjelenit(listBox2);

        }
    }
}
