using System;
using System.Diagnostics;

namespace Metoder3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");
            string meny = Console.ReadLine();

            switch (meny)
            {
                case "1":
                    MenyvalAddera();
                    break;
                case "2":
                    MenyvalStörstaTalet();
                    break;
                case "3":
                    break;
            }
        }

        static void MenyvalAddera()
        {
            int[] tal = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Skriv in ett tal: ");
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Addera(tal[0], tal[1], tal[2]));
        }

        static void MenyvalStörstaTalet()
        {
            int[] tal = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Skriv in ett tal: ");
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(störst(tal[0], tal[1]));
        }

        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }

        static int störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }
    }
}