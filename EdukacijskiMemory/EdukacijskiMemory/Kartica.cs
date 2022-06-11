using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdukacijskiMemory
{
    public class Kartica
    {
        private string _tekst;
        private int _par;
        public string tekst
        {
            get { return _tekst; }
        }
        public int par
        {
            get { return _par; }
        }

        public Kartica(string tekst, int par)
        {
            _tekst = tekst;
            _par = par;
        }
        public Kartica()
        {
            _tekst = "";
            _par = 0;
        }
    }
}
