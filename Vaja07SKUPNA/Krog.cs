using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja07SKUPNA
{
    class Krog
    {

        private double r;
        public Krog()
        {
            r = 1;
        }

        public Krog(double r)
        {
            this.r = r;
        }

        public void NastaviR()
        {
            Console.WriteLine("Vnesi velikost R:");
            r = Convert.ToDouble(Console.ReadLine());
        }

        public double Obseg()
        {
            return 2 * Math.PI * r;
        }

        public double Ploscina()
        {
            return Math.PI * r * r;
        }
    }
}
