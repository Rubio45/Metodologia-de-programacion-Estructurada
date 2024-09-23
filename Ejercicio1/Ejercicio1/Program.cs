// See https://aka.ms/new-console-template for more information
using System;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int salonA, salonB, salonC;
            int tiempoA = 5, tiempoB = 8, tiempoC = 6;
            int revisionA, revisionB, revisionC, tiempoTotal;
            int minutos, horas;

            Console.Write("Estudiantes en el SalonA: ");
            salonA = int.Parse(Console.ReadLine());
            Console.Write("Estudiantes en el SalonB: ");
            salonB = int.Parse(Console.ReadLine());
            Console.Write("Estudiantes en el SalonC: ");
            salonC = int.Parse(Console.ReadLine());

            revisionA = salonA * tiempoA;
            revisionB = salonB * tiempoB;
            revisionC = salonC * tiempoC;

            tiempoTotal = revisionC + revisionB + revisionA;

            minutos = tiempoTotal % 60;
            horas = tiempoTotal / 60;

            Console.WriteLine("Se demorara {0} horas con {1} minutos", horas, minutos);
            Console.ReadKey();
        }
    }
}
