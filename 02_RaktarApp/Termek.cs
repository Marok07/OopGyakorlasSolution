using System;
using System.Collections.Generic;
using System.Text;

namespace _02_RaktarApp
{
    internal class Termek
    {
        public string Nev { get; set; }
        public int EgysegAr { get; private set; }

        public static int TermekSzamlalo = 0;

        public Termek(string n, int ea)
        {
            this.Nev = n;
            this.EgysegAr = ea;

            TermekSzamlalo = TermekSzamlalo + 1;
        }

    }
}
