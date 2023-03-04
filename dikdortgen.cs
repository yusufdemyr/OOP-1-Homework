using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class Dikdortgen : Şekil
    {
        private double kisaKenarUzunlugu;
        private double uzunKenarUzunlugu;
        public Dikdortgen()
        {
            kisaKenarUzunlugu = 5;
            uzunKenarUzunlugu = 10;
        }
        public Dikdortgen(double kisa,double uzun)
        {
            kisaKenarUzunlugu = kisa;
            uzunKenarUzunlugu = uzun;
        }
        public override double getAlan()
        {
            return kisaKenarUzunlugu * uzunKenarUzunlugu;
        }

        public override double getCevre()
        {
            return 2 * kisaKenarUzunlugu + 2 * uzunKenarUzunlugu;
        }
        public override string ToString() => "kisaKenarUzunlugu = "+ kisaKenarUzunlugu + "\nuzunKenarUzunlugu = "+ uzunKenarUzunlugu +"\nÇevre = " + getCevre().ToString() + "\nAlan = " + getAlan().ToString()+"\n";
    }
}
