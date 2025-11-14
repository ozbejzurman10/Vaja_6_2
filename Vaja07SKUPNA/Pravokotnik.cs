using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja07SKUPNA
{
    internal class Pravokotnik
    {
        private double a;
        private double b;

        public Pravokotnik()
        {
            a = 1;
            b = 1;
        }
        public Pravokotnik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void NastavitiVrednosti()
        {
            Console.Write("Vnesi dolzino prve stranice: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vnesi dolzino druge stranice: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public double Obseg()
        {
            return 2 * (a + b);
        }

        public double Ploscina()
        {
            return a * b;
        }
        


    }
}
