using System;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Elaborar um algoritmo que calcule e imprima o valor do número π , dado um número N de
            termos. A série é:             
             π = 4 - 4/3 + 4/5 - 4/7 + 4/9 - 4/11 + ...
            Execute o programa utilizando os seguintes valores para N:
            10, 100, 500, 1000, 10000, 20000. Compare os resultados obtidos. */

            // var
            int opcao;

            // codigo
            while (true){
                System.Console.Write("\nValor de N:\n1 - 10\n2 - 100\n3 - 500\n4 - 1000\n5 - 10000\n6 - 20000\n0 - Sair\n>>> ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                        expressao(10);
                        break;
                    case 2:
                        expressao(100);
                        break;
                    case 3:
                        expressao(500);
                        break;
                    case 4:
                        expressao(1000);
                        break;
                    case 5:
                        expressao(10000);
                        break;
                    case 6:
                        expressao(20000);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("Valor Inválido!");
                        break;
                }
            }

        }

        static void expressao(int opcao)
        {
            // var
            double divisor = 3, resultado = 4, cont = 0;

            // codigo
            do {
                if (cont % 2 == 0){
                    resultado -= 4/divisor;
                    divisor += 2;
                    ++cont;
                }
                else{
                    resultado += 4/divisor;
                    divisor += 2;
                    ++cont;
                }

            } while (cont <= opcao);
            System.Console.WriteLine(resultado);

        }
    }
}
