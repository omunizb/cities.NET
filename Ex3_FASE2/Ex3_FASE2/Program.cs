using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Ex3_FASE2
{
    class Program
    {
        static void Main(string[] args)
        {
            string city1, city2, city3, city4, city5, city6;

            Console.WriteLine("Write the name of six cities:");

            city1 = Console.ReadLine();
            city2 = Console.ReadLine();
            city3 = Console.ReadLine();
            city4 = Console.ReadLine();
            city5 = Console.ReadLine();
            city6 = Console.ReadLine();

            string[] arrayCities = { city1, city2, city3, city4, city5, city6 };

            Array.Sort(arrayCities);

            Console.WriteLine("These are your chosen cities in alphabetical order:");

            foreach (string city in arrayCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}

