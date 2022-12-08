using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF46o13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string MindenXedik(string s,int hanyadik)  // ABCDEFG
        {
            string s2 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if ( (i + 1) % hanyadik == 0)
                {
                    s2 = s2 + s[i];
                }
            }

            return s2;  
        }

        string Forditva(string s)
        {
            string s2 = "";
            for (int i = 0; i < s.Length; i++)
            {
                s2 = s[i] + s2;
            }
            return s2;
        }

        int HanyMaganhangzo(string s)
        {   string maganhangzo = "aAáÁeEéÉiIíÍoOóÓöÖőŐuUúÚüÜűŰ";
            int db = 0;
            foreach (var betu in s)
            {
                if (maganhangzo.IndexOf(betu) >= 0 ) db++;  
            }
            return db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eredmeny_a.Text = MindenXedik(szoveg.Text,2);
            eredmeny_b.Text = MindenXedik(szoveg.Text,5);
            // C.feladat: ABCDEFGH ... hossz
            int startIndex = szoveg.Text.Length-5;
            if (startIndex < 0)
                eredmeny_c.Text = "Nincs 5 betű! "+szoveg.Text;
            else
                eredmeny_c.Text = szoveg.Text.Substring(startIndex);

            eredmeny_d.Text = Forditva(szoveg.Text);
            //E. feladat
            string[] szavak = szoveg.Text.Split(' '); // szétvágja

            foreach (string szo in szavak)
            {
                eredmeny_e.Text = szo +" "+ eredmeny_e.Text;
            }

            // F feladat
            if (szoveg.Text.IndexOf('t') < 0)
                eredmeny_f.Text = "Nincs benne t betű";
            else
                eredmeny_f.Text = "Van benne t betű. "+ (szoveg.Text.IndexOf('t')+1) +".betű";
            // G feladat
            if (szoveg.Text.LastIndexOf("fa") < 0)
                eredmeny_g.Text = "Nincs benne a fa";
            else
                eredmeny_g.Text = "Van benne fa " + (szoveg.Text.LastIndexOf("fa") + 1) + ". kezd";

            // H hány magánhangzó?
            eredmeny_h.Text = HanyMaganhangzo(szoveg.Text).ToString();
    }
    }
}
