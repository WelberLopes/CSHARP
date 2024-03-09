using System;
using System.Globalization;

namespace ExerEstruturaSequencial06
{
    class Programa
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double _triangulo = (A * C) / 2;
            double _circulo = Math.Pow(C, 2.0) * 3.14159;
            double _trapezio = (A+B)*C/2;
            double _quadrado = Math.Pow(B, 2.0);
            double _retangulo = A * B;

            Console.WriteLine("TRIANGULO " + _triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO " + _circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO " + _trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO " + _quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO " + _retangulo.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}