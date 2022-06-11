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
    public partial class Profil : Form
    {
        public Profil()
        {
            //Prikazuje statistiku riješenosti. 
            InitializeComponent();
            lblDobrodosli.Text = "Dobrodošli, " + MainMenu.Korisnik[0] + "!";
            int EngleskiBrojac = 0;
            int MatematikaBrojac = 0;
            int NjemackiBrojac = 0;
            int TalijanskiBrojac = 0;
            for (int i = 2; i < 6; i++)
            {
                if(MainMenu.Korisnik[i]=="1")
                {
                    EngleskiBrojac++;
                }
            }
            for (int i = 6; i < 10; i++)
            {
                if (MainMenu.Korisnik[i] == "1")
                {
                    MatematikaBrojac++;
                }
            }
            for (int i = 10; i < 14; i++)
            {
                if (MainMenu.Korisnik[i] == "1")
                {
                    NjemackiBrojac++;
                }
            }
            for (int i = 14; i < 18; i++)
            {
                if (MainMenu.Korisnik[i] == "1")
                {
                    TalijanskiBrojac++;
                }
            }
            lblEngleski.Text = "Engleski: " + (EngleskiBrojac * 25).ToString() + "%";
            lblMatematika.Text = "Matematika: " + (MatematikaBrojac * 25).ToString() + "%";
            lblNjemacki.Text = "Njemački: " + (NjemackiBrojac * 25).ToString() + "%";
            lblTalijanski.Text = "Talijanski: " + (TalijanskiBrojac * 25).ToString() + "%";

        }
    }
}
