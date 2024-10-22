using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Automobilio eksploatacijos išlaidų skaičiuoklė
            Console.WriteLine("Iveskite kuro litro kaina(eu):");
            double kaina = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite automobilio vidutines 100km kuro sanaudas(l):");
            double vidSanaudos = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite per metus automobiliu nuvaziuojama atstuma(km):");
            double atstumas = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite tech prieziuros, draudimo ir kitu eksploitacijos islaidu suma(eu) per metus:");
            double kitosIslaidos = double.Parse(Console.ReadLine());


            double sanaudos = atstumas / 100 * vidSanaudos;
            double bendrosIslaidos = sanaudos * kaina + kitosIslaidos;


            Console.WriteLine($"Bendros kuro sanaudos per metus - {sanaudos} litrai");
            Console.WriteLine($"Technines prieziuros ir kitu islaidu suma - {kitosIslaidos} eurai");
            Console.WriteLine($"Bendra automobilio eksploitacijos kaina - {bendrosIslaidos} eurai");
        }
    }
}