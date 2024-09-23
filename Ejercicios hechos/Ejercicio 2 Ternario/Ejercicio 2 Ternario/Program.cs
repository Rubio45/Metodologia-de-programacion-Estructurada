// See https://aka.ms/new-console-template for more information
/*
 * Realizar el programa que muestre el nombre del cliente y la
cantidad de artículos comprados en una tienda, si la cantidad es
menor de 30 pagara en efectivo, si es mayor de 30 y menor de 60
pagara con tarjeta, si es mayor de 60 pagara con cheque.
*/

using System;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente, metodoPago;
            sbyte cantidadArticulos;

            Console.Write("Introduce el nombre del cliente: ");
            cliente = Console.ReadLine();

            Console.Write("Introduce la cantidad de articulos: ");
            cantidadArticulos = sbyte.Parse(Console.ReadLine());

            metodoPago = cantidadArticulos < 30 ? "efectivo" : ((cantidadArticulos > 30 && cantidadArticulos < 60) ? "tarjeta" : "cheque");

            Console.WriteLine($"El cliente {cliente} comprará {cantidadArticulos} articulos, por lo tanto pagará con {metodoPago}");
            Console.ReadKey();
        }
    }
}

