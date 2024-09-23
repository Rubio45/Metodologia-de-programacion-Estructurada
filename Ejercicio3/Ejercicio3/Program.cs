// See https://aka.ms/new-console-template for more information
using System;

namespace CalcularNota
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Ingrese el número de respuestas correctas: ");
            int respuestasCorrectas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de respuestas incorrectas: ");
            int respuestasIncorrectas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de respuestas en blanco: ");
            int respuestasEnBlanco = int.Parse(Console.ReadLine());

            int notaFinal = (respuestasCorrectas * 5) + (respuestasIncorrectas * -1);

            Console.WriteLine("La nota final es: " + notaFinal);
            Console.ReadKey();
        }
    }
}
