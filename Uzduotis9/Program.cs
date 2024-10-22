using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Greičio skaičiavimas
            Console.WriteLine("Iveskite nuvaziuota atstuma(km):");
            int atstumas = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite keliones laika(h):");
            int laikas = int.Parse(Console.ReadLine());

            int greitis = atstumas / laikas;
            Console.WriteLine($"Jusu vidutinis greitis yra {greitis}km/h");
        }
    }
}