using System;
using Entidades;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese los datos del paralelogramo:");

                double baseParalelogramo = IngresarValor("Ingrese la base del paralelogramo: ");
                double altura = IngresarValor("Ingrese la altura del paralelogramo: ");
                double lado = IngresarValor("Ingrese el lado del paralelogramo: ");

                Paralelogramo paralelogramo = new Paralelogramo();
                paralelogramo.EstablecerValores(baseParalelogramo, altura, lado);

                Console.WriteLine("\n--- INFORME DEL PARALELOGRAMO ---");
                paralelogramo.InformarDatos();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static double IngresarValor(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor;
                }
                Console.WriteLine("Error: El valor debe ser un número positivo. Por favor, intente nuevamente.");
            }
        }
    }
}
