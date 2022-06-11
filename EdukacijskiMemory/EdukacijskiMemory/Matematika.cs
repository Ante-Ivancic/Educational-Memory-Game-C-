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
    public partial class Matematika : Form
    {
        public Matematika()
        {
            //Aktivira igre vezane uz matematiku
            InitializeComponent();
            string[] Korisnik = MainMenu.Korisnik;
            string[] Completed = new string[4];
            for (int i = 6; i < 10; i++)
            {
                Completed[i - 6] = Korisnik[i];
            }
            if (Completed[0] == "1")
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
            List<Kartica> lstKartice = new List<Kartica>();
            lstKartice = ListaKartica.ListaKarticaUcitavanje(MainMenu.lstSveAdminIgre[4]);
            Igra3x4 i3x4 = new Igra3x4(lstKartice, 6);
            i3x4.Show();
            i3x4.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 5;
            List<Kartica> lstKartice = new List<Kartica>();
            lstKartice = ListaKartica.ListaKarticaUcitavanje(MainMenu.lstSveAdminIgre[i]);
            Igra3x4 i3x4 = new Igra3x4(lstKartice, i + 2);
            i3x4.Show();
            i3x4.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 6;
            List<Kartica> lstKartice = new List<Kartica>();
            lstKartice = ListaKartica.ListaKarticaUcitavanje(MainMenu.lstSveAdminIgre[i]);
            Igra3x4 i3x4 = new Igra3x4(lstKartice, i + 2);
            i3x4.Show();
            i3x4.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 7;
            List<Kartica> lstKartice = new List<Kartica>();
            lstKartice = ListaKartica.ListaKarticaUcitavanje(MainMenu.lstSveAdminIgre[i]);
            Igra4x4 i4x4 = new Igra4x4(lstKartice, i + 2);
            i4x4.Show();
            i4x4.TopMost = true;
        }
    }
}
