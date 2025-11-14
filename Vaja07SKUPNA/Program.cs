using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja07SKUPNA
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 6;
            double b = 8;
            Pit_Trikotnik trikotnik = new Pit_Trikotnik(a, b);
            Console.WriteLine("Ploščina pravokotnega trikotnika s katetama {0} in {1} je {2}.", a, b, trikotnik.IzracunajPloscino());
        }
    }
}
