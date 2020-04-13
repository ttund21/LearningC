using System;

namespace Questao31
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 31) Entrar com o salário de uma pessoa e imprimir o desconto do IR segundo a tabela
            abaixo:
                - menor ou igual a R$ 600,00 - isento
                - maior que R$ 600,00 e menor ou igual a R$ 1200,00 - 20%
                - maior que R$ 1200,00 e menor ou igual a R$2000,00 - 25%
                - maior que R$ 2000,00 - 30% */

            // var 
            float salario;

            // codigo
            System.Console.Write("Salário: R$");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 600){
                System.Console.WriteLine("Isento");
            }
            else if (salario <= 1200){
                System.Console.WriteLine($"Desconto: R${Math.Round(salario * 0.2)}");
            }
            else if (salario <= 2000){
                System.Console.WriteLine($"Desconto: R${Math.Round(salario * 0.25)}");
            }
            else {
                System.Console.WriteLine($"Desconto: R${Math.Round(salario * 0.3)}");
            }
        }
    }
}
