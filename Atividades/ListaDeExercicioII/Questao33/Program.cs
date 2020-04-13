using System;

namespace Questao33
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 33)Entrar com a idade de uma pessoa e informar:
                - se é maior de idade
                - se é menor de idade
                - se é maior de 65 anos */
            
            // var
            int idade;

            // codigo
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 18){
                System.Console.WriteLine("Menor de idade.");
            }
            else if (idade <= 65){
                System.Console.WriteLine("Maior de idade.");
            }
            else {
                System.Console.WriteLine("Maior de 65 anos.");
            }
        }
    }
}
