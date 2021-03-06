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
    public partial class Engleski : Form
    {
        //Aktivira igre vezane uz engleski
        public Engleski()
        {
            InitializeComponent();
            string[] Korisnik = MainMenu.Korisnik;
            string[] Completed = new string[4];
            for (int i = 2; i < 6; i++)
            {
                Completed[i - 2] = Korisnik[i];
            }
            if(Completed[0]=="1")
            {
                lblCompleted1.Visible = true;
            }
            if (Completed[1] == "1")
            {
                lblCompleted2.Visible = true;
            }
            if (Completed[2] == "1")
            {
                lblCompleted3.Visible = true;
            }
            if (Completed[3] == "1")
            {
                lblCompleted4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<Kartica> lstKartice = new List<Kartica>();
            lstKartice = ListaKartica.ListaKarticaUcitavanje(MainMenu.lstSveAdminIgre[i]);
            Igra3x4 i3x4 = new Igra3x4(lstKartice, i+2);
            i3x4.Show();
            i3x4.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            List<Kartica> lstKartice = new List<Kartica>();
            lstKartice = ListaKartica.ListaKarticaUcitavanje(MainMenu.lstSveAdminIgre[i]);
            Igra3x4 i3x4 = new Igra3x4(lstKartice, i + 2);
            i3x4.Show();
            i3x4.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 2;
            List<Kartica> lstKartice = new List<Kartica>();
            lstKartice = ListaKartica.ListaKarticaUcitavanje(MainMenu.lstSveAdminIgre[i]);
            Igra3x4 i3x4 = new Igra3x4(lstKartice, i + 2);
            i3x4.Show();
            i3x4.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 3;
            List<Kartica> lstKartice = new List<Kartica>();
            lstKartice = ListaKartica.ListaKarticaUcitavanje(MainMenu.lstSveAdminIgre[i]);
            Igra4x4 i4x4 = new Igra4x4(lstKartice, i + 2);
            i4x4.Show();
            i4x4.TopMost = true;
        }
    }
}
