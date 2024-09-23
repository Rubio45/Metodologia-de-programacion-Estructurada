
using System;


namespace Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Ejercio 1\n---------------");
            Program.ejercicio1();
            Console.Clear();
            // 2
            Console.WriteLine("Ejercio 2\n---------------");
            Program.ejercicio2();
            Console.Clear();
            // 3
            Console.WriteLine("Ejercio 3\n---------------");
            Program.ejercicio3();
            Console.Clear();
            // 4
            Console.WriteLine("Ejercio 4\n---------------");
            Program.ejercicio4();
            Console.Clear();
            // 5
            Console.WriteLine("Ejercio 5\n---------------");
            Program.ejercicio5();
        }

        static void ejercicio1()
        {
            /*Escriba un programa que calcule la suma de todos los números pares entre 1 y un número
ingresado por el usuario. Utilice un ciclo for para iterar sobre los números y una estructura
if para verificar si cada número es par.
*/
            int numeroIngresado, suma = 0;

            Console.Write("Ingrese un numero para sumar todos los numeros pares hasta ese numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            // pongo numeroIngresado + 1 para contar el propio numero
            for (int i = 0; i < numeroIngresado + 1; i++) // se puede optimizar la memoria incrementando i + 2. Para tener mas eficiencia
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }

            }
            Console.WriteLine($"La suma de todos los numeros pares hasta {numeroIngresado} es: {suma}");
            Console.ReadKey();
        }

        static void ejercicio2()
        {
            /*
             * Escriba un programa que calcule el factorial de un número ingresado por el usuario
utilizando un ciclo while. Use una estructura if para manejar el caso en que el número
ingresado es negativo, ya que el factorial no está definido para números negativos.
            */
            int numeroIngresado, factorial = 1;
            Console.Write("Ingrese un numero para calcular el factorial de ese numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());
            int copia = numeroIngresado;
            while (numeroIngresado > 0)
            {
                if (numeroIngresado <= 1)
                {
                    break;
                }
                factorial *= numeroIngresado;
                numeroIngresado -= 1;
            }
            Console.Write($"El factorial de {copia} es {factorial}");
            Console.ReadKey();
        }

        static void ejercicio3()
        {
            /*Escriba un programa que imprima todos los números múltiplos de 5 entre 1 y un número
ingresado por el usuario. Utilice un ciclo for para iterar sobre los números y una estructura
if para verificar si cada número es múltiplo de 5.
            */
            int numeroIngresado;
            Console.Write("Ingrese un numero para ver todos los multiplos 5 entre 1 y ese numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            for (int i = 1; i < numeroIngresado + 1; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.ReadKey();
        }


        static void ejercicio4()
        {
            /*Escribe un programa que genere la secuencia de Fibonacci hasta el enésimo término, donde
n es un número ingresado por el usuario. Utilice un ciclo for para generar los términos y
una estructura if para manejar la inicialización de los primeros términos de la secuencia.
            */
            Console.Write("Ingrese la cantidad de terminos de la Serie de Fibonacci que desea: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.Write($"La serie de Fibonacci con {n} miembros es: ");
            if (n >= 1)
            {
                Console.Write(a);
            }

            if (n >= 2)
            {
                Console.Write(", " + b);
            }

            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                Console.Write(", " + c);
                a = b;
                b = c;
            }

            Console.ReadKey();
        }

        /*
         * Escriba un programa que lea una serie de números ingresados por el usuario hasta que se
ingrese un número 0 (cero). Utilice un ciclo for para leer los números y una estructura if
para determinar el número máximo y el mínimo de la serie.
        */
        static void ejercicio5()
        {
            byte n = 20;
            //Declarar un array de 20 numeros enteros.
            int[] numeros = new int[n];
            byte i = 0;

            while (i < n)
            {
                Console.Write("Introduce un numero nuevo, no puede ser 0: ");
                int aux = int.Parse(Console.ReadLine());

                if (aux == 0)
                {
                    Console.WriteLine("No se puede introducir el numero 0");
                    break;
                }
                else
                {
                    numeros[i] = aux;
                }
                i++;
            }
            Console.Clear();
            int menorNumero = 0, mayorNumero = 0;
            for(int k = 0; k < numeros.Count() - 1; k++)
            {
                if (numeros[k] != 0)
                {
                    Console.Write($"{numeros[k]}, ");
                }
                // Determinar cual de los numeros es el mayor y cual es el menor.

                if (numeros[k] > mayorNumero)
                {
                    mayorNumero = numeros[k];
                }

                if (numeros[k] < menorNumero)
                {
                    menorNumero = numeros[k];
                }
            }
            
            Console.WriteLine($"\n\n-----------------------------------------------------------------\nEl mayor numero introducido es: {mayorNumero} y el menor es: {menorNumero}");

            Console.ReadKey();

        }
    }
}