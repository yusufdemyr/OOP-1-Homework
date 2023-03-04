using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    public abstract class Şekil
    {
        private int kenarSayisi = 0;
        
        public abstract double getCevre();
        public abstract double getAlan();
        public string yazdir() => ToString();

    }
}
