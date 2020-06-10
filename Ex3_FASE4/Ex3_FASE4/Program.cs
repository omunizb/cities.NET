using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Ex3_FASE4
{
    class Program
    {
        
        static void InvertPrint(string city, char[] arrCity)
        {
            int counter = 0;

            foreach (char letter in city)
            {
                arrCity[counter] = letter;
                counter++;
            }

            for (int i = arrCity.Length - 1; i >= 0; i--)
            {
                Console.Write(arrCity[i]);
            }

            Console.Write(Environment.NewLine);
        }

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

            char[] arrCity1 = new char[city1.Length];
            char[] arrCity2 = new char[city2.Length];
            char[] arrCity3 = new char[city3.Length];
            char[] arrCity4 = new char[city4.Length];
            char[] arrCity5 = new char[city5.Length];
            char[] arrCity6 = new char[city6.Length];

            Console.WriteLine("These are the inverted cities you have chosen:");

            InvertPrint(city1, arrCity1);
            InvertPrint(city2, arrCity2);
            InvertPrint(city3, arrCity3);
            InvertPrint(city4, arrCity4);
            InvertPrint(city5, arrCity5);
            InvertPrint(city6, arrCity6);
        }
    }
}