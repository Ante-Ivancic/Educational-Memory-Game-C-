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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Provjerava postoji li korisnik, ako ne onda ga stvara.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "" && tbSifra.Text != "")
            {
                string ime = tbIme.Text;
                string sifra = tbSifra.Text;
                string[] AktivniKorisnik = new string[18];
                AktivniKorisnik = Admin.IdentificiranjeKorisnika(ime, sifra);
                if (AktivniKorisnik[17] == "0" || AktivniKorisnik[17] == "1")
                {
                    MainMenu.Korisnik = AktivniKorisnik;
                    this.Hide();
                    MainMenu mm = new MainMenu();
                    mm.Show();
                }
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena");
            }
        }
    }
}
