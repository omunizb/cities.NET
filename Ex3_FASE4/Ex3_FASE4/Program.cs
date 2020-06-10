using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Ex3_FASE4
{
    class Program
    {
        
        static char[] CharArray(string city)
        {
            char[] cityLetters = new char[city.Length];

            for (int i = 0; i < city.Length; i++)
            {
                cityLetters[i] = city[i];
            }

            return cityLetters;
        }

        static void InvertPrint(char[] city)
        {
            for (int i = city.Length - 1; i >= 0; i--)
            {
                Console.Write(city[i]);
            }

            Console.Write(Environment.NewLine);
        }

        static void Main(string[] args)
        {
            string[] arrCities = new string[6];

            Console.WriteLine("Write the name of six cities:");

            for (int i = 0; i < arrCities.Length; i++)
            {
                arrCities[i] = Console.ReadLine();
            }

            Console.WriteLine("These are the cities you have chosen, inverted:");

            for (int i = 0; i < arrCities.Length; i++)
            {
                InvertPrint(CharArray(arrCities[i]));
            }
        }
    }
}