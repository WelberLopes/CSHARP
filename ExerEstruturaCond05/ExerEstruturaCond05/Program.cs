using System.Globalization;



namespace LojaComida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("CÓDIGO      PRODUTO             PREÇO");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 1          Cachorro Quente     R$4.00");
            Console.WriteLine(" 2          X-Salada            R$4.50");
            Console.WriteLine(" 3          X-Bacon             R$5.00");
            Console.WriteLine(" 4          Torrada simples     R$2.00");
            Console.WriteLine(" 5          Refrigerante        R$1.50");
            Console.WriteLine("==============================================");
            Console.WriteLine(" ");


            int _codEscolhido;
            int _qtdProduto;


            Console.WriteLine("Digite o código do produto escolhido e a quantidade: ");

            string[] valores = (Console.ReadLine().Split(' '));
            _codEscolhido = int.Parse(valores[0], CultureInfo.InvariantCulture);
            _qtdProduto = int.Parse(valores[1], CultureInfo.InvariantCulture);

            double _valorFinal;
            double _hotDog = 4.00;
            double _xSalada = 4.50;
            double _xBacon = 5.00;
            double _torradaS = 2.00;
            double _refri = 1.50;

            if (_codEscolhido == 1)
            {
                _valorFinal = _hotDog * _qtdProduto;
                Console.WriteLine("Total= R$ {0:F2}", _valorFinal);
            }
            else if (_codEscolhido == 2)
            {
                _valorFinal = _xSalada * _qtdProduto;
                Console.WriteLine("Total= R$ {0:F2}", _valorFinal);
            }
            else if (_codEscolhido == 3)
            {
                _valorFinal = _xBacon * _qtdProduto;
                Console.WriteLine("Total= R$ {0:F2}", _valorFinal);
            }
            else if (_codEscolhido == 4)
            {
                _valorFinal = _torradaS * _qtdProduto;
                Console.WriteLine("Total= R$ {0:F2}", _valorFinal);
            }
            else if (_codEscolhido == 5)
            {
                _valorFinal = _refri * _qtdProduto;
                Console.WriteLine("Total= R$ {0:F2}", _valorFinal);
            }
            else
            {
                Console.WriteLine("!!Código de Produto INCORRETO!!");
            }

        }
    }
}