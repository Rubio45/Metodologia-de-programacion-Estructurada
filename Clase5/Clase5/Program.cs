// See https://aka.ms/new-console-template for more information

using System;

namespace MiPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            Estudiante estudiante2 = new Estudiante(123, "Maria", "Juana", "Marketing");

            Console.WriteLine("DATOS DEL ESTUDIANTE\n----------------------");
            Console.WriteLine($"CIF:\t {estudiante2.cif}");
            Console.WriteLine($"Nombre:\t {estudiante2.nombre}");
            Console.WriteLine($"Apellido: {estudiante2.apellido}");
            Console.WriteLine($"Carrera: {estudiante2.carrera}");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Datos del Estudiante 1\n----------------");
            Console.Write($"CIF: ");
            estudiante1.cif = int.Parse(Console.ReadLine());
            Console.Write($"Nombre: ");
            estudiante1.nombre = Console.ReadLine();
            Console.Write($"Apellido: ");
            estudiante1.apellido = Console.ReadLine();
            Console.Write($"Carrera: ");
            estudiante1.carrera = Console.ReadLine();
            Console.ReadKey();

        }
    }

    struct Estudiante
    {
        public int cif;
        public string nombre;
        public string apellido;
        public string carrera;

        public Estudiante(int cifC, string nombreC, string apellidoC, string carreraC)
        {
            cif = cifC;
            nombre = nombreC;
            apellido = apellidoC;
            carrera = carreraC;
        }
    }
}
