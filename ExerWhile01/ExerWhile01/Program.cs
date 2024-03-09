using System;

namespace ExercicioWhile {
    class Program {
        static void Main(string[] args) {
            int _n = 0;




            while (_n >= 0) {
                Console.WriteLine("Digite um número:");
                _n = int.Parse(Console.ReadLine());

                double _resultado = Math.Sqrt(_n);
                Console.WriteLine("{0:F3}", _resultado);

            }
            Console.WriteLine("Número negativo");


        }
    }
}