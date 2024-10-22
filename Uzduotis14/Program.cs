using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Individualios veiklos skaičiuoklė pagal Lietuvos mokestinę schemą
            Console.WriteLine("Nurodykite individualios veiklos metines pajamas(Eu):");
            double pajamos = double.Parse(Console.ReadLine());

            Console.WriteLine("Įvardinkite, ar taikoma 5%, ar 15% pajamų mokesčio norma?");
            double norma = double.Parse(Console.ReadLine());

            double pajamuMokestis = pajamos * (norma / 100);
            double leidziamosIslaidos = pajamos * 0.3;
            double vsdSuma = (pajamos - leidziamosIslaidos) * 0.1383;
            double psdSuma = (pajamos - leidziamosIslaidos) * 0.0698;

            Console.WriteLine($"Bendros pajamos - {pajamos} eurai");
            Console.WriteLine($"Leidžiamos išlaidos - {leidziamosIslaidos} eurai");
            Console.WriteLine($"Pajamų mokestis - {pajamuMokestis} eurai");
            Console.WriteLine($"VSD mokėtina suma - {vsdSuma} eurai");
            Console.WriteLine($"PSD mokėtina suma - {psdSuma} eurai");
            Console.WriteLine("");
            Console.WriteLine($"Galutinis mokestis - {pajamuMokestis + vsdSuma + psdSuma} eurai");
        }
    }
}