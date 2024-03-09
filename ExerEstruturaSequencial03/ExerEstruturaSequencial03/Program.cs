using System;

namespace ExerEstruturaSequencial03
{
    class Program
    {
        static void Main(string[]args)
        {
            int a, b, c, d;

            Console.WriteLine("Insira 4 numeros inteiros:");
            a= int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int _diferença = (a*b - c*d);

            Console.WriteLine("DIFERNÇA: {0}", _diferença);
        }
    }
}