using System;
using System.Globalization;
namespace Curso {


    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Insira as medidas do triangulo X: ");
            double _a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double _b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double _c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira as medidas do triangulo Y: ");
            double _a2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double _b2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double _c2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double _resultado1 = _area(_a, _b, _c);
            double _resultado2 = _area(_a2, _b2, _c2);

            Console.WriteLine("Área do triangulo X: " + _resultado1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do triangulo Y: " + _resultado2.ToString("F4", CultureInfo.InvariantCulture));

            string _maior = Maior(_resultado1, _resultado2);
            Console.WriteLine("A maior área é : {0}", _maior);
        }

        static double _area(double a, double b, double c) {
            double _p = (a + b + c) / 2;

            double _calculo = (_p * (_p - a) * (_p - b) * (_p - c));

            double _areaTriangulo = Math.Sqrt(_calculo);

            return _areaTriangulo;

        }
        static string Maior(double _x, double _y) {


            if (_x > _y) {
                return "X";

            }
            else {
                return "Y";

            }


        }
    }
}