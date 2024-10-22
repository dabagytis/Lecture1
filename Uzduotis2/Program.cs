using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Kuro sąnaudų skaičiavimas
            Console.WriteLine("Iveskite nuvaziuota atstuma (km):");
            double atstumas = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite sunaudoto kuro kieki (l):");
            double kuras = double.Parse(Console.ReadLine());

            double sanaudos = kuras * 100 / atstumas;

            Console.WriteLine("Kuro sanaudos 100km = " + sanaudos + "l");
        }
    }
}