using System;

namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Elektros energijos sąnaudų skaičiuoklė
            Console.WriteLine("Iveskite bendra elektros energijos suvartojima per menesi(kWh)");
            double energija = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite elektros energijos tarifa uz kilovatvalande(eu)");
            double tarifas = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite papildomus mokescius (jei netaikoma, irasykite 0);");
            double extraMokesciai = double.Parse(Console.ReadLine());

            double energijosMokestis = energija * tarifas;
            double mokesciuSuma = energijosMokestis + extraMokesciai;

            Console.WriteLine($"Suma uz suvartota elektros energija per menesi - {energijosMokestis} eurai");
            Console.WriteLine($"Bendros energijos islaidos per menesi - {mokesciuSuma} eurai");
        }
    }
}