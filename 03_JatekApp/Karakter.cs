using System;
using System.Collections.Generic;
using System.Text;

namespace _03_JatekApp
{
    internal class Karakter
    {
        public string Nev { get; private set; }
        //private int eletero;
        public int Eletero { get; private set; }
        

        public Karakter(string n)
        {
            this.Nev = n;
            this.Eletero = 100;
        }

        public void Sebzodik(int pont)
        {
            Eletero -= pont;
            if (Eletero < 0) Eletero = 0;
        }

        public override string ToString()
        {
            return $"{Nev} - Életerő: {Eletero} HP";
        }

    }
}
