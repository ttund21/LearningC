using System;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que leia o salário atual e o percentual de aumento de um funcionário e imprima o novo salário;

            // Variaveis
            float salario, porc;

            // Codigo
            Console.Write("Salario Atual: ");
            salario = float.Parse(Console.ReadLine());
            System.Console.Write("Porcentual de aumento: ");
            porc = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"\nAumento de: {(salario / 100) * porc}\nTotal: {salario + ((salario / 100) * porc)}");
            
        }
    }
}
