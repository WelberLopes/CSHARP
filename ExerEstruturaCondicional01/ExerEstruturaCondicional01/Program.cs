using System;

namespace ExerEstruturaCond01{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Insira um número inteiro para verificar se o mesmo é negativo: ");
            x = int.Parse(Console.ReadLine());

            if (x < 0 ) {
                Console.WriteLine("O número '{0}' é NEGATIVO"!, x);
            } else {
                Console.WriteLine("O número '{0}' NÂO É NEGATIVO!", x);
            }
        }
    }
}