using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Vidurkio skaičiavimas
            Console.WriteLine("Iveskite pirmaji skaiciu:");
            int pirmasisSkaicius = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antraji skaiciu:");
            int antrasisSkaicius = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite treciaji skaiciu:");
            int treciasisSkaicius = int.Parse(Console.ReadLine());

            int vidurkis = (pirmasisSkaicius + antrasisSkaicius + treciasisSkaicius) / 3;
            Console.WriteLine("Ivestu skaiciu vidurkis: " + vidurkis);
        }
    }
}