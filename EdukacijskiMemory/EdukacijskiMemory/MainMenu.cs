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
    public partial class MainMenu : Form
    {
        //Navigiranje main menuom
        public static string[] Korisnik = new string[18];
        public static List<string[]> lstSveAdminIgre = new List<string[]>();
        public MainMenu()
        {
            InitializeComponent();
            lstSveAdminIgre = Admin.SveAdminIgre();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIgraj_Click(object sender, EventArgs e)
        {
            btnMatematika.Visible = btnEngleski.Visible = btnNjemacki.Visible = btnTalijanski.Visible = btnMojeIgre.Visible = btnIgreOstalihIgraca.Visible = true;
            btnIgraj.Visible = btnNapraviIgru.Visible = btnProfil.Visible = false;
            btnBack.Visible = true;
            this.BackgroundImage = new Bitmap(@"Slike\MainMenuIgraj.png");
        }

        private void btnNapraviIgru_Click(object sender, EventArgs e)
        {
            btnIgraj.Visible = btnNapraviIgru.Visible = btnProfil.Visible = false;
            btnNapraviIgru4x3.Visible = btnNapraviIgru4x4.Visible = true;
            btnBack.Visible = true;
            this.BackgroundImage = new Bitmap(@"Slike\MainMenuNapraviIgru.png");
        }

        private void btnNapraviIgru4x3_Click(object sender, EventArgs e)
        {
            NapraviIgru np = new NapraviIgru();
            np.Show();
            np.TopMost = true;
        }

        private void btnNapraviIgru4x4_Click(object sender, EventArgs e)
        {
            NapraviIgru4x4 np4x4 = new NapraviIgru4x4();
            np4x4.Show();
            np4x4.TopMost = true;
        }

        private void btnEngleski_Click(object sender, EventArgs e)
        {
            Engleski en = new Engleski();
            en.Show();
            en.TopMost = true;
        }

        private void btnMatematika_Click(object sender, EventArgs e)
        {
            Matematika ma = new Matematika();
            ma.Show();
            ma.TopMost = true;
        }

        private void btnNjemacki_Click(object sender, EventArgs e)
        {
            Njemacki nj = new Njemacki();
            nj.Show();
            nj.TopMost = true;
        }

        private void btnTalijanski_Click(object sender, EventArgs e)
        {
            Talijanski ta = new Talijanski();
            ta.Show();
            ta.TopMost = true;
        }

        private void btnMojeIgre_Click(object sender, EventArgs e)
        {
            Igre ig = new Igre("Moje igre");
            try
            {
                ig.Show();
                ig.TopMost = true;
            }
            catch { }
        }

        private void btnIgreOstalihIgraca_Click(object sender, EventArgs e)
        {
            Igre ig = new Igre("Igre ostalih igrača");
            ig.Show();
            ig.TopMost = true;
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Profil pr = new Profil();
            pr.Show();
            pr.TopMost = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            btnMatematika.Visible = btnEngleski.Visible = btnNjemacki.Visible = btnTalijanski.Visible = btnMojeIgre.Visible = btnIgreOstalihIgraca.Visible = false;
            btnIgraj.Visible = btnNapraviIgru.Visible = btnProfil.Visible = true;
            btnNapraviIgru4x3.Visible = btnNapraviIgru4x4.Visible = false;

            this.BackgroundImage = new Bitmap(@"Slike\MainMenu.png");
        }
    }
}
