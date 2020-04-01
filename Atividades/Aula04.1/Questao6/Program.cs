using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um programa que calcule o valor do desconto do
            INSS. Os critérios são os seguintes:
            • salário < 200 INSS => 8,0%
            • salário >= 200 e < 500 => 8.5%
            • salário >=500 e < 1000 => 9.0%
            • salário >1000 =>9.5%*/

            float salario;

            Console.Write("Salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario < 200){
                System.Console.Write($"Desconto: {(salario*8)/100}");
            }
            else if (salario >= 200 && salario < 500){
                System.Console.Write($"Desconto: {(salario*8.5)/100}");
            }
            else if (salario >= 500 && salario < 1000){
                System.Console.Write($"Desconto: {(salario*9)/100}");
            }
            else{
                System.Console.Write($"Desconto: {(salario*9.5)/100}");
            }
        }
    }
}
