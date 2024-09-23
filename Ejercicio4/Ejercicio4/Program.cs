// See https://aka.ms/new-console-template for more information

using System;

namespace CalcularTotal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el precio del artículo: ");
            float precio = float.Parse(s: Console.ReadLine());

            Console.Write("Ingrese la cantidad de artículos a comprar: ");
            int cantidad = int.Parse(s: Console.ReadLine());

            float subtotal = precio * cantidad;


            float totalPagar = subtotal * 1.09f;

            
            Console.WriteLine("El total a pagar es: $" + totalPagar);
            Console.ReadKey();
        }
    }
}
