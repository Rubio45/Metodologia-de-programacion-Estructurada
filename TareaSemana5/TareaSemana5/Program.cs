// See https://aka.ms/new-console-template for more information

// Alex Ivan Diaz Yañez
// Septiembre 21, 2024
// Este programa imprime crea un struct de Producto y a su vez, hace un array de 8 elementos.
// Los recorre y los imprime. 

using System;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumaTotal = 0;
            Producto[] productos = new Producto[8]
            {
                new Producto("001", "Camiseta", 10.99),
                new Producto("002", "Pantalon", 15.49),
                new Producto("003", "Calcetines", 7.25),
                new Producto("004", "Zapatos", 9.99),
                new Producto("005", "Cinturon", 20.0),
                new Producto("006", "Sosten", 5.75),
                new Producto("007", "Corbata", 12.50),
                new Producto("008", "Camisa", 8.99)
            };
            Console.WriteLine("INFORMACION SOBRE LOS PRODUCTOS EN STOCK\n");
            // Ejercicio 2: Recorre el array y muestra todos los productos en el array. 
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID: {producto.idProd}, Nombre: {producto.nombre}, Precio: ${producto.precio}");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ahora se imprimirá la suma de todos los precios de los productos\n------------------------------");

            // Ejercicio 3: Recorre el array de nuevo para calcular el total de todos los productos.
            Console.WriteLine("SUMA DE LOS PRECIOS DE LOS PRODUCTOS");
            foreach (var producto in productos)
            {
                sumaTotal += producto.precio;
            }
            Console.WriteLine($"El precio total de los productos es: ${sumaTotal}");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 6: Crear un nuevo array e imprimir aquellos que tengan 10 o menos unidades en Stock.
            ProductoMejorado[] productosMejorados = new ProductoMejorado[8]
            {
                new ProductoMejorado("001", "Camiseta", 10.99, 23),
                new ProductoMejorado("002", "Pantalon", 15.49, 15),
                new ProductoMejorado("003", "Calcetines", 7.25, 8),
                new ProductoMejorado("004", "Zapatos", 9.99, 3),
                new ProductoMejorado("005", "Cinturon", 20.0, 10),
                new ProductoMejorado("006", "Sosten", 5.75, 12),
                new ProductoMejorado("007", "Corbata", 12.50, 4),
                new ProductoMejorado("008", "Camisa", 8.99, 12)
            };

            // Recorrer el array y mostrar el nombre de los productos que tengan 10 o menos unidades en Stock
            Console.WriteLine("Productos con 10 o menos unidades disponibles\n--------------------------------------------------".ToUpper());
            foreach (var productoMejorado in productosMejorados)
            {
                if (productoMejorado.cantidadEnStock <= 10)
                {
                    Console.WriteLine($"Producto: {productoMejorado.nombre}, Cantidad en Stock: {productoMejorado.cantidadEnStock}");
                }
            }
            Console.ReadKey();
            Console.Clear();
            // Ejercicio 8: Crear un array de CuentaBancaria y mostrar los datos.
            CuentaBancaria[] cuentasBancarias = new CuentaBancaria[8]
            {
                new CuentaBancaria(1001, "Juan Perez", 1500.50),
                new CuentaBancaria(1002, "Maria Gomez", 2450.75),
                new CuentaBancaria(1003, "Carlos Martinez", 500.00),
                new CuentaBancaria(1004, "Ana Lopez", 980.25),
                new CuentaBancaria(1005, "Pedro Fernandez", 3200.00),
                new CuentaBancaria(1006, "Luis Garcia", 1100.00),
                new CuentaBancaria(1007, "Carmen Sanchez", 2750.40),
                new CuentaBancaria(1008, "Jorge Ramirez", 600.90)
            };
            // Imprimir las cuentas bancarias.
            Console.WriteLine("INFORMACION DE CUENTAS BANCARIAS");
            foreach (var cuenta in cuentasBancarias)
            {
                Console.WriteLine($"Número de cuenta: {cuenta.numDeCuenta}, Titular: {cuenta.nombreTitular}, Saldo: {cuenta.saldo}");
            }
            Console.ReadKey(); 
        }
    }

    struct Producto
    {
        public string idProd;
        public string nombre;
        public double precio;

        public Producto(string idProd, string nombre, double precio)
        {
            this.idProd = idProd;
            this.nombre = nombre;
            this.precio = precio;
        }
    }
    // Hacer un upgrade a producto para que admita otro valor. 
    struct ProductoMejorado
    {
        public string idProd;
        public string nombre;
        public double precio;
        public int cantidadEnStock;

        public ProductoMejorado(string idProd, string nombre, double precio, int cantidadEnStock)
        {
            this.idProd             = idProd;
            this.nombre             = nombre;
            this.precio             = precio;
            this.cantidadEnStock    = cantidadEnStock;
        }
    }

    struct CuentaBancaria
    {
        public int numDeCuenta;
        public string nombreTitular;
        public double saldo;

        public CuentaBancaria(int numDeCuenta, string nombreTitular, double saldo)
        {
            this.numDeCuenta    = numDeCuenta;
            this.nombreTitular  = nombreTitular;
            this.saldo          = saldo;
        }
    }
}
