using System;

namespace ExerestruturaCond02
{
    class PrograM
    {
        static void Main(string[] args)
        {
            int _n;
            Console.WriteLine("Insira um número inteiro para verificar s eo mesmo é IMPAR ou PAR:");
            _n = int.Parse(Console.ReadLine());

            if (_n % 2 == 0 ) 
            {
                Console.WriteLine("O número {0} é PAR", _n);

            } else
            {
                Console.WriteLine("O número '{0}' é IMPAR", _n);
            }
        }
    }
}