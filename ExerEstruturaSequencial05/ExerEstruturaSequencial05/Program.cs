using System;
using System.Globalization;

namespace ExerEstruturaSequencial05
{
    class Program
    {
        static void Main(string[] args)
        {
            int _codigoPeca1;
            int _qtdPecas1;
            double _precoPeca1;

            int _codigoPeca2;
            int _qtdPecas2;
            double _precoPeca2;

            Console.WriteLine("Insira: Código da Peça, quatidade da peça e valor da peça:");
            string[] valores = Console.ReadLine().Split(' ');


            _codigoPeca1 = int.Parse(valores[0], CultureInfo.InvariantCulture);
            _qtdPecas1 = int.Parse(valores[1], CultureInfo.InvariantCulture);
            _precoPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Insira: Código da Peça, quatidade da peça e valor da peça:");
            string[] valores2= Console.ReadLine().Split(' ');

            _codigoPeca2 = int.Parse(valores2[0], CultureInfo.InvariantCulture);
            _qtdPecas2 = int.Parse(valores2[1], CultureInfo.InvariantCulture);
            _precoPeca2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);


            double _valorPagar1 = _qtdPecas1 * _precoPeca1;
            double _valorpagar2 = _qtdPecas2 * _precoPeca2;

            double _valorTotal = _valorPagar1 + _valorpagar2;

            Console.WriteLine("VALOR A PAGAR: R$" + _valorTotal.ToString("F2", CultureInfo.InvariantCulture));  






        }
    }
}
