using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerWhile01 {
    internal class ExercicioFor {

        static void Main(string[] args) {
            Console.WriteLine("Quantos números inteiros você vai digitar?");
            int _n = int.Parse(Console.ReadLine());
            int _x;

            for (_x = 1; _x < _n; _x++) {
                int _n1;
                int _soma = 0;
                _n1 = int.Parse(Console.ReadLine());
                _soma += _n1;

                Console.WriteLine("Soma= " + _soma);

            }
        }
    }
}
