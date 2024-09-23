// See https://aka.ms/new-console-template for more information
using System;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            sbyte edad;
            string result;
            
            Console.Write("Dame la edad: ");
            edad = sbyte.Parse(Console.ReadLine());

            result = (edad > 18) ? "Adulto" : "Menor";

            Console.WriteLine("--------------------");
            Console.WriteLine("Eres {0}", result);
            Console.ReadKey();
            */
            Console.Write("Dame un numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Dame otro numero: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", calculator(a: a, b: b)) ;
            Console.ReadKey();
        }


        static int calculator(int a, int b)
        {
            bool calculatorBool = a > 0 && b > 0;
            return calculatorBool ? a + b : a * b;
        }
    }
}
