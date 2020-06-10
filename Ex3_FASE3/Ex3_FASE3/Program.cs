using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Ex3_FASE3
{
    class Program
    {
        static void Main(string[] args)
        {
            string city1, city2, city3, city4, city5, city6;

            Console.WriteLine("Write the name of six cities:");

            city1 = Console.ReadLine().Replace('a', '4').Replace('A', '4');
            city2 = Console.ReadLine().Replace('a', '4').Replace('A', '4');
            city3 = Console.ReadLine().Replace('a', '4').Replace('A', '4');
            city4 = Console.ReadLine().Replace('a', '4').Replace('A', '4');
            city5 = Console.ReadLine().Replace('a', '4').Replace('A', '4');
            city6 = Console.ReadLine().Replace('a', '4').Replace('A', '4');

            string[] arrModCities = { city1, city2, city3, city4, city5, city6 };

            Array.Sort(arrModCities);

            Console.WriteLine("These are your chosen modified cities in alphabetical order:");

            foreach (string city in arrModCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
