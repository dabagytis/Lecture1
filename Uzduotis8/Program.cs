using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Valandų konvertavimas į minutes ir sekundes
            Console.WriteLine("Iveskite valandu kieki:");
            int valandos = int.Parse(Console.ReadLine());

            int minutes = valandos * 60;
            int sekundes = minutes * 60;

            Console.WriteLine($"{valandos} valandos sudaro {minutes} minutes arba {sekundes} sekundes");
        }
    }
}