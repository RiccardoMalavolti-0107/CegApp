using System;
using System.Collections.Generic;
using System.Text;

namespace cegApp
{
    internal class Menedzser : alkalmazott
    {
        public int Bonusz { get; set; }
        public Menedzser(string nev, int alapber, int bonusz) : base(nev, alapber)
        {
            this.Bonusz = bonusz;
        }
        public override int fizetesSzamitas()
        {
            return Alapber + Bonusz;
        }
        
    
    }
}
