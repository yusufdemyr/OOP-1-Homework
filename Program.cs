using System;
using System.ComponentModel;
namespace Odev
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Daire Test Sınıfı");
            Console.Write("Dairenin yarıçapını giriniz. ");
            string yariCap = Console.ReadLine();
            double value = Convert.ToDouble(yariCap);
            Şekil daire = new Daire(value);
            Console.WriteLine(daire.yazdir());
            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.");
            Console.ReadKey();
            
            Şekil daire2 = new Daire();
            Console.WriteLine(daire2.yazdir());
            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.");
            Console.ReadKey();

            Console.WriteLine("\nKare Test Sınıfı");
            Şekil kare = new Kare(10);
            Console.WriteLine(kare.yazdir());
            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.");
            Console.ReadKey();

            Şekil kare2 = new Kare();
            Console.WriteLine(kare2.yazdir());
            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.");
            Console.ReadKey();


            Console.WriteLine("\nDikdörtgen Test Sınıfı");
            Şekil dikdortgen = new Dikdortgen(20, 30);
            Console.WriteLine(dikdortgen.yazdir());
            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.");
            Console.ReadKey();

            Şekil dikdortgen2 = new Dikdortgen();
            Console.WriteLine(dikdortgen2.yazdir());
            Console.ReadKey();
        }
    }
}
