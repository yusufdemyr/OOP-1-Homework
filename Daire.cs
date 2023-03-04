using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    public class Daire : Şekil
    {
        private double yariCap;
        
        public Daire()
        {   
            
            yariCap = 10;
            Şekil kare = new Kare();
            Console.WriteLine($"kareyeSigar(Şekil kare) = {kareyeSigar(kare)}");
            if (kareyeSigar(kare)) Console.WriteLine($"Bir kenarı {10} olan bir kareye yarıçapı {yariCap} olan bir daire sığar");
            else Console.WriteLine($"Bir kenarı {10} olan bir kareye yarıçapı {yariCap} olan bir daire sığmaz");

        }
        public Daire(double yarCap)
        {
            yariCap = yarCap;
            Şekil kare2 = new Kare(yarCap);
            Console.WriteLine($"kareyeSigar(Şekil kare) = {kareyeSigar(kare2)}");
            if (kareyeSigar(kare2)) Console.WriteLine($"Bir kenarı {yarCap * 2} olan bir kareye yarıçapı {yarCap} olan bir daire sığar");
            else Console.WriteLine($"Bir kenarı {yarCap * 2} olan bir kareye yarıçapı {yarCap} olan bir daire sığmaz");
        }

        public bool kareyeSigar(Şekil kare)
        {
            if ((getAlan() < kare.getAlan())) return true;
            else return false;
        }
        public override double getAlan()
        {
            return Math.PI * Math.Pow(yariCap,2);
        }
        public override double getCevre()
        {
            return 2*Math.PI*yariCap;
        }
        public override string ToString() => "yariCap = "+ yariCap +"\nÇevre = " + getCevre().ToString() + "\nAlan = " + getAlan().ToString()+"\n";
    }
}
