using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Darbo užmokesčio skaičiavimas
            Console.WriteLine("Iveskite valandine darbo verte(eu):");
            double valandinis = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite savaites darbo valandu kieki:");
            int valanduKiekis = int.Parse(Console.ReadLine());

            double savaitinis = valandinis * valanduKiekis;
            double menesinis = savaitinis * 4;
            double metinis = menesinis * 12;

            Console.WriteLine($"Jusu savaitinio uzmokescio verte {savaitinis} eurai, menesinio - {menesinis} eurai, o metinio - {metinis} eurai.");
        }
    }
}