using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdukacijskiMemory
{
    public partial class Igre : Form
    {
        public int i = 0;
        public static List<string[]> lstIgre = new List<string[]>();

        //Prikazuje ili sve igre koje je napravio igrač ili sve igre koje su napravili drugi igrači.
        public Igre(string KojeIgre)
        {
            InitializeComponent();
            string Korisnik = MainMenu.Korisnik[0];
            lstIgre = Admin.SveIgre();
            int j = lstIgre.Count;
            for (int i = 0; i < j; i++)
            {
                string imeKorisnika = lstIgre[i][0];
                if(KojeIgre=="Moje igre")
                {
                    if(imeKorisnika!=Korisnik)
                    {
                        lstIgre.RemoveAt(i);
                        i--;
                        j--;
                    }
                }
                else if(KojeIgre=="Igre ostalih igrača")
                {
                    if (imeKorisnika == Korisnik)
                    {
                        lstIgre.RemoveAt(i);
                        i--;
                        j--;
                    }
                }
                else
                {
                    MessageBox.Show("Greska.");
                }
                //MessageBox.Show(lstIgre.Count.ToString());
                if (lstIgre.Count == 0)
                {
                    MessageBox.Show("Niste napravili nijednu igru.");
                    this.Close();
                }
                else
                {
                    lblAktivnaIgra.Text = lstIgre[0][1];
                }
            }
        }

        //Lista kroz listu igara.
        private void button2_Click(object sender, EventArgs e)
        {
            if(i<lstIgre.Count-1)
            {
                i++;
                lblAktivnaIgra.Text = lstIgre[i][1];
            }
            else if(i==lstIgre.Count-1)
            {
                i = 0;
                lblAktivnaIgra.Text = lstIgre[i][1];
            }
        }

        //Lista kroz listu igara.
        private void button1_Click(object sender, EventArgs e)
        {
            if(i>0)
            {
                i--;
                lblAktivnaIgra.Text = lstIgre[i][1];
            }
            else if (i == 0)
            {
                i = lstIgre.Count - 1;
                lblAktivnaIgra.Text = lstIgre[i][1];
            }
        }

        //Aktivira odabranu igru.
        private void button3_Click(object sender, EventArgs e)
        {
            if (lstIgre[i].Length==14)
            {
                List<Kartica> lstKartice = new List<Kartica>();
                lstKartice = ListaKartica.ListaKarticaUcitavanje(lstIgre[i]);
                Igra3x4 i3x4 = new Igra3x4(lstKartice,0);
                i3x4.Show();
                i3x4.TopMost = true;
            }
            else if(lstIgre[i].Length==18)
            {
                List<Kartica> lstKartice = new List<Kartica>();
                lstKartice = ListaKartica.ListaKarticaUcitavanje(lstIgre[i]);
                Igra4x4 i4x4 = new Igra4x4(lstKartice, 0);
                i4x4.Show();
                i4x4.TopMost = true;
            }
        }
    }
}
