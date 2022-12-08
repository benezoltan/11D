using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GyakString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Megfordit(string szoveg)  // pl. ABC
        {
            string kimenet = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char betu = szoveg[i]; // C
                kimenet = betu + kimenet;  // CBA
            }
            return kimenet;
        }

        string Maganhangzo(string szoveg)
        {
            string mh = "aAáÁeEéÉiIíÍoOóÓöÖőŐuU";

            string kimenet = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char betu = szoveg[i];
                if (mh.IndexOf(betu) >= 0) 
                { 
                    kimenet = kimenet + betu;   
                }
            }
            return kimenet;
        }

        string Mássalhangzo(string szoveg)
        {
            string mh = "aAáÁeEéÉiIíÍoOóÓöÖőŐuU";

            string kimenet = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char betu = szoveg[i];
                if (mh.IndexOf(betu) < 0)  // -1
                {
                    kimenet = kimenet + betu;
                }
            }
            return kimenet;
        }

        int HanySzo(string szoveg)
        {
            string[] szavak = szoveg.Split(' ');
            return szavak.Length;
        }

        private void startGomb_Click(object sender, EventArgs e)
        {
           kiiras.Text = Megfordit(bevitel.Text) + "\r\n";
           kiiras.Text += Maganhangzo(bevitel.Text) + "\r\n";
           kiiras.Text += Mássalhangzo(bevitel.Text) + "\r\n";
           kiiras.Text += HanySzo(bevitel.Text) + " szóból áll."  + "\r\n";
        }
    }
}
