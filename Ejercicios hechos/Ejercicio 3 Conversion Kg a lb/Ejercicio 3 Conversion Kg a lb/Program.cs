// See https://aka.ms/new-console-template for more information
/*
 * 
 * Elabore un programa que permita ingresar nombre del cliente,
nombre del producto, el precio unitario y la cantidad de un artículo
a comprar. Calcular el total a pagar. (Considerar el IVA 12%).
 * 
 */


using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreProducto, nombreCliente;
            float precioUnitario, total;
            sbyte cantidadArticulos;

            Console.Write("Ingrese el nombre del cliente: ");
            nombreCliente = Console.ReadLine();
            Console.Write("Ingrese el nombre del producto: ");
            nombreProducto = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            precioUnitario = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de articulos: ");
            cantidadArticulos = sbyte.Parse(Console.ReadLine());

            // usando el iva
            total = precioUnitario * cantidadArticulos * 1.12f;

            Console.Clear();
            // Mostrar el total
            Console.WriteLine($"El total para {nombreCliente} por la compra de {cantidadArticulos} {nombreProducto}(s) con IVA incluido es: {total:C}");// uso :C para darle formate currency
            
            Console.ReadKey();
        }
    }
}
