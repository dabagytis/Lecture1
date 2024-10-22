using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Apskritimo ploto skaičiavimas
            Console.WriteLine("Iveskite apskritimo spinduli(cm):");
            double spindulys = double.Parse(Console.ReadLine());

            double plotas = Math.PI * Math.Pow(spindulys, 2);
            Console.WriteLine($"Apskritimo plotas yra {plotas}cm2");
        }
    }
}