using System;
namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar?");
            int _n = int.Parse(Console.ReadLine());
            int _x;
            int _soma = 0;

            for (_x = 1; _x <= _n; _x++)
            {
                int _n1;
                
                Console.WriteLine("Valor #{0}:", _x);
                _n1 = int.Parse(Console.ReadLine());
                _soma += _n1;
               
            }

            Console.WriteLine("Soma= " + _soma);
        }
    }
}
