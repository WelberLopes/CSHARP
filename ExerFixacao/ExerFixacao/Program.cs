using System;
using System.Globalization;


namespace Course {

    class Program {
        static void Main(string[] args) {

       

            string[] vet = Console.ReadLine().Split(' ');

            string _nome = vet[0];
            char _sexo = char.Parse(vet[1]);
            int _idade = int.Parse(vet[2]);
            double _altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("{0} é do sexo {1} e possui {2} anos e mede {3:F2} metros", _nome, _sexo, _idade, _altura);



        }



    }
}
