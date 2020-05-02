using System;

namespace Questao02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* QUESTÃO 02 - Faça um algoritmo em C#, utilizando o comando PARA, que a partir de uma
             informação dada pelo usuário sobre a ordem de impressão (C para crescente e D para 
             decrescente), imprima os números entre 30 e 50 com a ordem especificada. */

            //var
            char resp;

            // codigo
            Console.Write("Ordem(C para crescente e D para decrescente): ");
            resp = char.Parse(Console.ReadLine());

            switch(resp){
                case 'C':
                    for (int i = 30; i <= 50; i++){
                        System.Console.Write($"{i} ");
                    }
                    break;

                case 'D':
                    for (int i = 50; i >= 30; i--){
                        System.Console.Write($"{i} ");
                    }
                    break;

                default:
                    System.Console.WriteLine("Comando Inválido!");
                    break;
            }
        }
    }
}
