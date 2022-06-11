using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdukacijskiMemory
{
    public static class ListaKartica
    {
        //Vraća listu karata.
        public static List<Kartica> ListaKarticaUcitavanje(string[] igra)
        {
            List<Kartica> lstKartica = new List<Kartica>();
            for (int i = 2; i < igra.Length; i++)
            {
                Kartica k = new Kartica(igra[i], i / 2);
                lstKartica.Add(k);
            }
            return lstKartica;
        }
        //Miješa karte
        public static void PromijesajKartice(List<Kartica>lstKartice)
        {
            Random rnd = new Random();
            int n = rnd.Next(7000, 8000);
            for (int i = 0; i < n; i++)
            {
                Kartica t = new Kartica();
                int a = rnd.Next(lstKartice.Count());
                int b = rnd.Next(lstKartice.Count());
                t = lstKartice[a];
                lstKartice[a] = lstKartice[b];
                lstKartice[b] = t;
            }
        }
    }
}
