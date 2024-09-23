// See https://aka.ms/new-console-template for more information
using System;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            double PVP, productoPagado;

            Console.Write("PVP: ");
            PVP = double.Parse(Console.ReadLine());

            Console.Write("Precio final: ");
            productoPagado = double.Parse(Console.ReadLine());

            Console.WriteLine("El descuento total fue {0:N2}%", (productoPagado/PVP)*100);
            Console.ReadKey();
        }
    }
}
