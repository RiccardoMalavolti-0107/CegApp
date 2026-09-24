using System;
using System.Collections.Generic;
using System.Text;

namespace cegApp
{
    internal class alkalmazott
    {
        public string nev { get; set; }

        protected int Alapber { get; set; }

        public alkalmazott(string nev, int alapber)
        {
            this.nev = nev;
            this.Alapber = alapber;
        }

        public virtual int fizetesSzamitas()
        {
            return Alapber;
        }
        public override string ToString()
        {
            return $"Név: {nev}, Alapbér: {Alapber}";
        }

    }
}
