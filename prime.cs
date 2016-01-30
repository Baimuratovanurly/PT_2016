using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++) // stroka sostoit iz chisel, budet prohodit` po kazhdomu elementu, poka ne doidet do konca stroki
            {
                int cnt = 0;

                int x = int.Parse(args[i]); // preobrazuyet strokovoe predstavlenie chisla v chislovoe

                for (int j = 2; j<=Math.Sqrt(x); j++) // chtoby ocenit` na prostotu proveryayem deliteli chisla ot 2 do kornea iz chisla, potomu chto bol`she deliteley net
                {
                    if (x % j == 0) // esli est` deliteli, to prostoe chislo
                    {
                        cnt++;
                   
                    }
                }
                if (cnt != 0) // esli est` deliteli, to ne prostoe chislo
            {
                Console.WriteLine(x + "is not prime");

            }
            else 
            {
                Console.WriteLine(x + "is prime"); // eslinet deliteley, to prostoe chislo
            }
            Console.ReadKey();
            }
        }
    }
}
