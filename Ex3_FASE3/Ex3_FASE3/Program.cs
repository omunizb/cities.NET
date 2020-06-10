using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Ex3_FASE3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrModCities = new string[6];

            Console.WriteLine("Write the name of six cities:");

            for (int i = 0; i < arrModCities.Length; i++)
            {
                arrModCities[i] = Console.ReadLine().Replace('a', '4').Replace('A', '4');
            }

            Array.Sort(arrModCities);

            Console.WriteLine("These are your chosen modified cities in alphabetical order:");

            foreach (string city in arrModCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
