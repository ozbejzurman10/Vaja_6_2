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
            Pravokotnik pravokotnik1 = new Pravokotnik(3, 3);
            Pravokotnik pravokotnik2 = new Pravokotnik(6, 4);
            Console.WriteLine("Ploscina prvega pravokotnika: " + pravokotnik1.Ploscina());
            Console.WriteLine("Ploscina drugega pravokotnika: " + pravokotnik2.Ploscina());
        }
    }
}
