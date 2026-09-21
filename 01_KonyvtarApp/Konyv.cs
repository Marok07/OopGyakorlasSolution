using System;
using System.Collections.Generic;
using System.Text;

namespace _01_KonyvtarApp
{
    internal class Konyv
    {
        public readonly string Cim;
        private int oldalszam;
        public int Oldalszam {
            get { return oldalszam; }
            set
            {
                if ( value>0 )
                {
                    oldalszam = value;
                }
            } 
        }
        public Konyv(string c, int o)
        {
            this.Cim = c;
            this.oldalszam = o;
        }

        public override string ToString()
        {
            return $"Könyv: {Cim}, {Oldalszam} oldal";
        }

    }
}
