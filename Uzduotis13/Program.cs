using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Valiutų konvertavimas(Litai, eurai, doleriai, svarai)
            Console.WriteLine("Iveskite pinigu suma(Lt):");
            double litai = double.Parse(Console.ReadLine());

            double eurai = litai / 3.4528;
            double doleriai = eurai / 0.93;
            double svarai = doleriai / 1.31;
            Console.WriteLine($"{litai} litai konvertuojasi i ~{(int)eurai} eurus, ~{(int)doleriai} dolerius arba ~{(int)svarai} svarus");
        }
    }
}