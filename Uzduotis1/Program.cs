using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Stačiakampio ploto skaičiavimas
            Console.WriteLine("Iveskite staciakampio ilgi (cm):");
            double ilgis = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite staciakampio ploti (cm):");
            double plotis = double.Parse(Console.ReadLine());

            double plotas = ilgis * plotis;

            Console.WriteLine("Staciakampio plotas = " + plotas + "(cm2)");

            double perimetras = ilgis * 2 + plotis * 2;

            Console.WriteLine("Staciakampio perimetras = " + perimetras + "(cm)");
        }
    }
}