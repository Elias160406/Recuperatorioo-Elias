namespace Ejercicio2
{
    struct Paralelogramo
    {
        public double Base;
        public double Altura;
        public double Lado;

        public Paralelogramo(double baseParalelogramo, double altura, double lado)
        {
            if (baseParalelogramo <= 0 || altura <= 0 || lado <= 0)
            {
                throw new ArgumentException("Todos los valores deben ser positivos.");
            }

            Base = baseParalelogramo;
            Altura = altura;
            Lado = lado;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Lado);
        }

        public double CalcularSuperficie()
        {
            return Base * Altura;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double mayorPerimetro = 0;
            int iteracionMayorPerimetro = 0;
            double sumaSuperficies = 0;
            int conteoParalelogramos = 0;
            int iteracion = 0;

            while (true)
            {
                iteracion++;

                double baseParalelogramo = IngresarValor("Ingrese la base del paralelogramo: ");
                double altura = IngresarValor("Ingrese la altura del paralelogramo: ");
                double lado = IngresarValor("Ingrese el lado del paralelogramo: ");

                Paralelogramo paralelogramo = new Paralelogramo(baseParalelogramo, altura, lado);

                double superficie = paralelogramo.CalcularSuperficie();
                double perimetro = paralelogramo.CalcularPerimetro();

                sumaSuperficies += superficie;
                conteoParalelogramos++;

                Console.WriteLine($"\n--- INFORME DEL PARALELOGRAMO {iteracion} ---");
                Console.WriteLine($"Base: {paralelogramo.Base}");
                Console.WriteLine($"Altura: {paralelogramo.Altura}");
                Console.WriteLine($"Lado: {paralelogramo.Lado}");
                Console.WriteLine($"Superficie: {superficie}");
                Console.WriteLine($"Perímetro: {perimetro}\n");

                if (perimetro > mayorPerimetro)
                {
                    mayorPerimetro = perimetro;
                    iteracionMayorPerimetro = iteracion;
                }

                Console.Write("¿Desea ingresar otro paralelogramo? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                    break;
            }

            if (conteoParalelogramos > 0)
            {
                double promedioSuperficies = sumaSuperficies / conteoParalelogramos;
                Console.WriteLine("\n--- RESUMEN FINAL ---");
                Console.WriteLine($"El paralelogramo con mayor perímetro fue ingresado en la iteración {iteracionMayorPerimetro} con un perímetro de {mayorPerimetro}");
                Console.WriteLine($"El promedio de las superficies ingresadas es: {promedioSuperficies}");
            }
            else
            {
                Console.WriteLine("\nNo se ingresaron paralelogramos válidos.");
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
                Console.WriteLine("Error: El valor debe ser un número positivo. Intente de nuevo.");
            }
        }
    }
}
