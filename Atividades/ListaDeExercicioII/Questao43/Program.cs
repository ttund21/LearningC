using System;

namespace Questao43
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 43) Ler um número entre 1 e 12, e escrever o mês correspondente. Caso o usuário
            digite um número fora deste intervalo, deverá aparecer uma mensagem, 
            informando que não existe  mês com este número. */

            // var
            int mes;

            // codigo
            Console.Write("Escreva um número de 1 a 12: ");
            mes = int.Parse(Console.ReadLine());

            switch(mes){
                case 1:
                    System.Console.WriteLine("Janeiro");
                    break;
                case 2:
                    System.Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    System.Console.WriteLine("Março");
                    break;
                case 4:
                    System.Console.WriteLine("Abril");
                    break;
                case 5:
                    System.Console.WriteLine("Maio");
                    break;
                case 6:
                    System.Console.WriteLine("Junho");
                    break;
                case 7:
                    System.Console.WriteLine("Julho");
                    break;
                case 8:
                    System.Console.WriteLine("Agosto");
                    break;
                case 9:
                    System.Console.WriteLine("Setembro");
                    break;
                case 10:
                    System.Console.WriteLine("Outubro");
                    break;
                case 11:
                    System.Console.WriteLine("Novembro");
                    break;
                case 12:
                    System.Console.WriteLine("Dezembro");
                    break;
                default:
                    System.Console.WriteLine("Valor Inválido!");
                    break;
            }
        }
    }
}
