using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Aritmetinių veiksmų praktika
            Console.WriteLine("Iveskite pirmaji skaiciu:");
            int pirmasisSkaicius = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antraji skaiciu:");
            int antrasisSkaicius = int.Parse(Console.ReadLine());

            int suma = pirmasisSkaicius + antrasisSkaicius;
            Console.WriteLine("Skaiciu suma: " + suma);

            int skirtumas = pirmasisSkaicius - antrasisSkaicius;
            Console.WriteLine("Skaiciu skirtumas: " + skirtumas);

            int sandauga = pirmasisSkaicius * antrasisSkaicius;
            Console.WriteLine("Skaiciu sandauga: " + sandauga);

            double dalyba = (double)pirmasisSkaicius / antrasisSkaicius;
            Console.WriteLine("Skaiciu dalyba: " + dalyba);

            double pirmoKvadratas = Math.Pow(pirmasisSkaicius, 2);
            Console.WriteLine("Pirmojo skaiciaus kvadratas: " + pirmoKvadratas);

            double antroKvadratas = Math.Pow(antrasisSkaicius, 2);
            Console.WriteLine("Antrojo skaiciaus kvadratas: " + antroKvadratas);

        }
    }
}