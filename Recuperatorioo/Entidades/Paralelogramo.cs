using System;

namespace Entidades
{
    public struct Paralelogramo
    {
        public double Base { get; private set; }
        public double Altura { get; private set; }
        public double Lado { get; private set; }

        public Paralelogramo(double baseParalelogramo, double altura, double lado)
        {
            if (baseParalelogramo <= 0 || altura <= 0 || lado <= 0)
            {
                throw new ArgumentException("Todos los valores deben ser positivos y mayores que cero.");
            }

            Base = baseParalelogramo;
            Altura = altura;
            Lado = lado;
        }

        public void EstablecerValores(double baseParalelogramo, double altura, double lado)
        {
            if (baseParalelogramo <= 0 || altura <= 0 || lado <= 0)
            {
                throw new ArgumentException("Todos los valores deben ser positivos y mayores que cero.");
            }

            Base = baseParalelogramo;
            Altura = altura;
            Lado = lado;
        }

        public void InformarPerimetro()
        {
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
        }

        public void InformarSuperficie()
        {
            Console.WriteLine($"Superficie: {CalcularSuperficie()}");
        }

        public void InformarDatos()
        {
            Console.WriteLine($"Base: {Base}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Lado: {Lado}");
            InformarPerimetro();
            InformarSuperficie();
        }

        private double CalcularPerimetro() => 2 * (Base + Lado);
        private double CalcularSuperficie() => Base * Altura;
    }
}
