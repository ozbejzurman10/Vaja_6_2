using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja07SKUPNA
{
    class Pit_Trikotnik
    {
        private double a;
        private double b;
        private double c;
        public Pit_Trikotnik()
        {
            a = 3;
            b = 4;
            c = 5;
        }
        public Pit_Trikotnik(double a, double b)
        {
            this.a = a;
            this.b = b;
            c = Math.Sqrt(a * a + b * b);
        }
        public void NastaviStranice()
        {
            Console.WriteLine("Vnesi dolzino prve stranice: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vnesi dolzino druge stranice: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vnesi dolzino tretje stranice: ");
            c = Convert.ToDouble(Console.ReadLine());
        }
        public double IzracunajObseg()
        {
            return a + b + c;
        }
        public double IzracunajPloscino()
        {
            return (a * b) / 2;
        }
    }
}
