using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Kūno masės indekso (KMI) skaičiavimas
            Console.WriteLine("Iveskite savo svori(kg):");
            double svoris = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite savo ugi(m)");
            double ugis = double.Parse(Console.ReadLine());

            double indeksas = svoris / Math.Pow(ugis, 2);
            Console.WriteLine($"Jusu kuno mases indeksas yra {indeksas}");
        }
    }
}