using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Temperatūros konvertavimas
            Console.WriteLine("Iveskite temperatura Celsijaus laipsniais:");
            int tempC = int.Parse(Console.ReadLine());

            int tempF = tempC * 9 / 5 + 32;
            Console.WriteLine($"{tempC}C konvertuojasi i {tempF}F temperaturos");
        }
    }
}