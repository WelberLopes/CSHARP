using System;
using System.Globalization;
namespace ExerEstrutturaCond03
{
    class Program
    {
        static void Main(string[] args)
        {
            int _x, _y;

            Console.WriteLine("Insira dois números inteiros para verificar se são múltiplos");
            string[] valores = Console.ReadLine().Split(' ');

            _x = int.Parse(valores[0], CultureInfo.InvariantCulture);
            _y = int.Parse(valores[1], CultureInfo.InvariantCulture);

            if (_x % _y == 0 || _y % _x == 0) {
                Console.WriteLine("São MULTIPLOS");
            } else {
                Console.WriteLine("NÂO MULTIPLOS");
            }


        }
    }
}