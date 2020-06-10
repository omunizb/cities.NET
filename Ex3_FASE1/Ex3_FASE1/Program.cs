using System;
using System.Dynamic;

namespace Ex3_FASE1
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

            Console.WriteLine("Your chosen cities are {0}, {1}, {2}, {3}, {4} and {5}.", city1, city2, city3, city4, city5, city6);
        }
    }
}
