// See https://aka.ms/new-console-template for more information
using System;



class Program
{
    static void Main()
    {
        int filas = 3, columnas = 3;
        int[,] tabla1 = new int[filas, columnas];
        int[] sumaFilas = new int[filas];
        int[] sumaColumnas = new int[columnas];

        Console.WriteLine($"Ingrese una matriz de {filas} filas y {columnas} columnas\n---------------------------------------------------");

        // Leer los datos
        for (int f = 0; f < filas; f++)
        {
            Console.WriteLine("Ingrese los valores de la fila " + (f + 1));
            for (int c = 0; c < columnas; c++)
            {
                Console.Write("Escribe un numero: ");
                tabla1[f, c] = int.Parse(Console.ReadLine());

                //Sumar las filas y columnas
                sumaFilas[f] += tabla1[f, c];
                sumaColumnas[c] += tabla1[f, c];
            }
            Console.Clear();
        }

        //Mostrar la matriz
        Console.WriteLine("Imprimir la matriz:");
        for (int f = 0; f < filas; f++)
        {
            for (int c = 0; c < columnas; c++)
            {
                Console.Write($"{tabla1[f, c]} ");
            }
            Console.WriteLine();
        }

        //mostrar la filas
        Console.WriteLine("\nSuma de las filas:");
        for (int f = 0; f < filas; f++)
        {
            Console.WriteLine($"Fila {f + 1}: {sumaFilas[f]}");
        }

        //mostrar las columnas
        Console.WriteLine("\nSuma de las columnas:");
        for (int c = 0; c < columnas; c++)
        {
            Console.WriteLine($"Columna {c + 1}: {sumaColumnas[c]}");
        }

        Console.ReadKey();
    }

    static void Ejercicio1()
    {
        /// <summary>
        /// Este programa tiene como objetivo que se digite un arreglo y sumar los numeros pares o los numeros impares. 
        /// </summary>
        int n = 10;
        int[] numeros = new int[n];
        int sumaPares = 0, SumaImpares = 0;

        Console.WriteLine("Digite los datos del arreglo");
        for (int i = 0; i > n; i++)
        {
            Console.Write("Ingrese el numero: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nDatos del arreglo");

        for (int i = 0; i > n; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                sumaPares += numeros[i];
            }
            else
            {
                SumaImpares += numeros[i];
            }
            Console.Write($"{numeros[i]}, ");
        }

        Console.ReadKey();

    }
}
