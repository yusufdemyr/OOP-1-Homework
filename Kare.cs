using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    public class Kare : Şekil
    {
        private double kenarUzunlugu;

        
        public Kare()
        {
            kenarUzunlugu = 10;
            Şekil dikdortgen = new Dikdortgen(15, 20);
            Console.WriteLine($"dikdortgeneSigar(Şekil dikdortgen) = {dikdortgeneSigar(dikdortgen)}");
            if (dikdortgeneSigar(dikdortgen)) Console.WriteLine($"Uzun kenarı {15} kısa kenarı {20} olan bir dikdörtgene, bir kenarı {kenarUzunlugu} olan bir kare sığar");
            else Console.WriteLine($"Uzun kenarı {15} kısa kenarı {20} olan bir dikdörtgene, bir kenarı {kenarUzunlugu} olan bir kare sığmaz");
        }
        public Kare(double kenar)
        {
            kenarUzunlugu = 2*kenar;
            Şekil dikdortgen2 = new Dikdortgen(kenar,kenar*2);
            Console.WriteLine($"dikdortgeneSigar(Şekil dikdortgen) = {dikdortgeneSigar(dikdortgen2)}");
            if (dikdortgeneSigar(dikdortgen2)) Console.WriteLine($"Uzun kenarı {kenar*2} kısa kenarı {kenar} olan dikdörtgene, bir kenarı {kenarUzunlugu} olan bir kare sığar");
            else Console.WriteLine($"Uzun kenarı {kenar*2} kısa kenarı {kenar} olan dikdörtgene, bir kenarı {kenarUzunlugu} olan bir kare sığmaz");
        }
        public bool dikdortgeneSigar(Şekil dikdortgen)
        {
            if ((getAlan() < dikdortgen.getAlan())) return true;
            else return false;
        }
        public override double getAlan()
        {
            return Math.Pow(kenarUzunlugu,2);
        }

        public override double getCevre()
        {
            return 4*kenarUzunlugu;
        }
        public override string ToString() => "kenarUzunlugu = "+ kenarUzunlugu + "\nÇevre = " + getCevre().ToString() + "\nAlan = " + getAlan().ToString()+"\n";
    }
}
