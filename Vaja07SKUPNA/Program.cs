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
            //V osnovni datoteki Program.cs v metodi Main dodaj kodo,
            //ki bo ustvarila dva objekta razreda Krog.
            //Prvi naj ima vrednost r enako 5, drugi pa 6.
            //Z uporabo metode na standardni izhod izpiši njegovo ploščino.

            Krog krog1 = new Krog(5);
            Krog krog2 = new Krog(6);

            Console.WriteLine("Ploščina kroga s polmerom 5 je: " + krog1.Ploscina());
            Console.WriteLine("Ploščina kroga s polmerom 6 je: " + krog2.Ploscina());
            Pravokotnik pravokotnik1 = new Pravokotnik(3, 3);
            Pravokotnik pravokotnik2 = new Pravokotnik(6, 4);
            Console.WriteLine("Ploscina prvega pravokotnika: " + pravokotnik1.Ploscina());
            Console.WriteLine("Ploscina drugega pravokotnika: " + pravokotnik2.Ploscina());
        }
    }
}
