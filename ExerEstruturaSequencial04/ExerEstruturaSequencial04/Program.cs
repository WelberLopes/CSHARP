using System;

namespace ExerEstrututaSequencial04
{
    class Program
    {
        static void Main(string[] args)
        {
            double _horasTrabalhadas;
            double _salarioHora;
            int _idFuncionario;

            Console.WriteLine("BEM VINDO A APLICAÇÃO DE CALCULO DE SÁLÁRIO");
            Console.WriteLine();
            Console.WriteLine("Insira seu ID:");
            _idFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Insira a quantidade de Horas Trabalhadas");
            _horasTrabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Insira Salário por Hora");
            _salarioHora = double.Parse(Console.ReadLine());

            double _salario = (_horasTrabalhadas * _salarioHora);
            Console.WriteLine("NUMBER = {0}", _idFuncionario);
            Console.WriteLine("SALARY = U$ {0:F2}", _salario);

     

        }
    }
}