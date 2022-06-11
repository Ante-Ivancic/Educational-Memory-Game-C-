using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EdukacijskiMemory
{
    public static class Admin
    {
        //Prepoznaje korisnika ako postoji ili ga zapisuje u datoteku.
        public static string[] IdentificiranjeKorisnika(string ime, string sifra)
        {
            StreamReader sr = new StreamReader("SviKorisnici.txt");
            string[] AktivniKorisnik = new string[18];
            bool PostojiLiKorisnik = false;
            bool kraj = false;
            string linija;
            while (kraj == false)
            {
                linija = sr.ReadLine();
                if (linija != null)
                {
                    string[] RazlomljenaLinija = linija.Split('|');
                    if (RazlomljenaLinija[0].ToLower() == ime.ToLower())
                    {
                        PostojiLiKorisnik = true;
                        if (RazlomljenaLinija[1] == sifra)
                        {
                            AktivniKorisnik = RazlomljenaLinija;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    kraj = true;
                }
            }
            sr.Close();
            if (PostojiLiKorisnik == true && AktivniKorisnik[0] == null)
            {
                MessageBox.Show("Kriva lozinka");
            }
            else if (PostojiLiKorisnik == false)
            {
                AktivniKorisnik[0] = ime;
                AktivniKorisnik[1] = sifra;
                for (int i = 2; i < 18; i++)
                {
                    AktivniKorisnik[i] = "0";
                }
                UpisKorisnika(AktivniKorisnik);
            }
            return AktivniKorisnik;
        }

        //Upis korisnika u datoteku.
        public static void UpisKorisnika(string[] Korisnik)
        {
            string linija = "";
            for (int i = 0; i < 18; i++)
            {
                linija += Korisnik[i];
                if (i < 17)
                    linija += "|";
            }
            StreamWriter sw = File.AppendText("SviKorisnici.txt");
            sw.WriteLine(linija);
            sw.Close();
        }

        //Upisuje igru 3x3 koju je unio korisnik u datoteku.
        public static void UpisIgre3x4(string[] Igra)
        {
            string linija = "";
            for (int i = 0; i < 14; i++)
            {
                linija += Igra[i];
                if (i < 13)
                    linija += "|";
            }
            StreamWriter sw = File.AppendText("Igre3x4.txt");
            sw.WriteLine(linija);
            sw.Close();
        }

        //Upisuje igru 4x4 koju je unio korisnik u datoteku.
        public static void UpisIgre4x4(string[] Igra)
        {
            string linija = "";
            for (int i = 0; i < 18; i++)
            {
                linija += Igra[i];
                if (i < 17)
                    linija += "|";
            }
            StreamWriter sw = File.AppendText("Igre4x4.txt");
            sw.WriteLine(linija);
            sw.Close();
        }

        //Vraća listu svih igara igrača.
        public static List<string[]> SveIgre()
        {
            List<string[]> SveIgre = new List<string[]>();
            StreamReader sr = new StreamReader("Igre3x4.txt");
            bool kraj = false;
            string linija;
            while (kraj == false)
            {
                linija = sr.ReadLine();
                if (linija != null)
                {
                    string[] RazlomljenaLinija = linija.Split('|');
                    SveIgre.Add(RazlomljenaLinija);
                }
                else
                {
                    kraj = true;
                }
            }
            sr.Close();
            //MessageBox.Show(SveIgre.Count.ToString());
            StreamReader sr2 = new StreamReader("Igre4x4.txt");
            bool kraj2 = false;
            string linija2;
            while (kraj2 == false)
            {
                linija2 = sr2.ReadLine();
                if (linija2 != null)
                {
                    string[] RazlomljenaLinija = linija2.Split('|');
                    SveIgre.Add(RazlomljenaLinija);
                }
                else
                {
                    kraj2 = true;
                }
            }
            sr2.Close();
            //MessageBox.Show(SveIgre.Count.ToString());
            return SveIgre;
        }

        //Mijenja podatke o korisniku u datoteci.
        public static void AzuriranjeKorisnikaNakonZavrseneIgre(int RedniBrojIgre)
        {
            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader("SviKorisnici.txt"))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    //if (line != "removeme")
                    string[] RazlomljenaLinija = line.Split('|');
                    if (RazlomljenaLinija[0]==MainMenu.Korisnik[0])
                    {
                        MainMenu.Korisnik[RedniBrojIgre] = "1";
                        line = "";
                        RazlomljenaLinija[RedniBrojIgre] = "1";
                        for (int i = 0; i < RazlomljenaLinija.Length; i++)
                        {
                            line += RazlomljenaLinija[i];
                            if (i < RazlomljenaLinija.Length - 1)
                                line += "|";
                        }
                    }
                    sw.WriteLine(line);
                }
            }

            File.Delete("SviKorisnici.txt");
            File.Move(tempFile, "SviKorisnici.txt");
        }

        //Vraća listu svih zadanih igara.
        public static List<string[]> SveAdminIgre()
        {
            List<string[]> SveIgre = new List<string[]>();
            StreamReader sr = new StreamReader("AdminIgre.txt");
            bool kraj = false;
            string linija;
            while (kraj == false)
            {
                linija = sr.ReadLine();
                if (linija != null)
                {
                    string[] RazlomljenaLinija = linija.Split('|');
                    SveIgre.Add(RazlomljenaLinija);
                }
                else
                {
                    kraj = true;
                }
            }
            sr.Close();
            return SveIgre;
        }
    }
}
