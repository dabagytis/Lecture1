using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Trikampio ploto skaičiavimas
            Console.WriteLine("Iveskite trikampio pagrindo ilgi (cm):");
            double ilgis = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite trikampio auksti (cm):");
            double aukstis = double.Parse(Console.ReadLine());

            double plotas = ilgis * aukstis / 2;

            Console.WriteLine("Trikampio plotas = " + plotas + "(cm2)");
        }
    }
}