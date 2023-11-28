using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA003
{
    internal class Jelentkezo
    {
        public string Nev { get; set; }
        public int SzulEv { get; set; }
        public string Nyelv { get; set; }
        public string Szint { get; set; }

        public Jelentkezo(string nev, int szulEv, string nyelv, string szint)
        {
            Nev = nev;
            SzulEv = szulEv;
            Nyelv = nyelv;
            Szint = szint;
        }
    }
}
