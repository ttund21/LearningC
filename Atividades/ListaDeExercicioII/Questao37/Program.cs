using System;

namespace Questao37
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 37) Faça um programa que leia a idade de uma pessoa e informe a sua classe eleitoral:
            - não eleitor (abaixo de 16 anos)
            - eleitor obrigatório ( entre 18 e 65 anos)
            - eleitor facultativo ( entre 16 e 18 anos e maior de 65 anos) */
            
            // var
            int idade;

            // codigo
            System.Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 16){
                System.Console.WriteLine("Não eleitor.");
            }
            else if (idade >= 18 && idade <= 65){
                System.Console.WriteLine("Eleitor obrigatório.");
            }
            else{
                System.Console.WriteLine("Eleitor facultativo.");
            }

        }
    }
}
