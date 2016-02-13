using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            foreach (string s in numbers)
            {
                int factor = int.Parse(s);
                bool bPrime = true;
                for (int i = 2; i*i<=factor; i++)
                {
                    if (factor % i == 0 && factor != 1)
                        bPrime = false;
                }
                if (bPrime == true)
                    Console.WriteLine(factor);
            }
            Console.ReadKey();
        }
    }
}


