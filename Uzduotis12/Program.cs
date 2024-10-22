using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Procentų skaičiavimas
            Console.WriteLine("Iveskite skaiciu:");
            float skaicius = float.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite procentine(%) reiksme:");
            int procentai = int.Parse(Console.ReadLine());

            float dalis = skaicius / 100 * procentai;
            Console.WriteLine($"{procentai}% skaiciaus {skaicius} yra {dalis}");
        }
    }
}