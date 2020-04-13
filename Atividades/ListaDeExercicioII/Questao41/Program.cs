using System;

namespace Questao41
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 41)Faça um algoritmo que possa imprimir o menu abaixo:
            1 – solteiro(a)
            2 – desquitado(a)
            3 – casado(a)
            4 – divorciado(a)
            5 – viúvo(a)
            Digite sua opção:
            O usuário deverá selecionar uma das opções, digitando um número e este deverá
            escrever o estado civil da pessoa. Emitir mensagem de erro caso seja escolhida uma
            opção inexistente. */

            // var
            int estadoCivil;

            // codigo
            Console.Write("1 - Solteiro(a)\n2 - Desquitado(a)\n3 - Casado(a)\n4 - Divorciado(a)\n5 - Viúvo(a)\nDigite sua opção: ");
            estadoCivil = int.Parse(Console.ReadLine());

            switch (estadoCivil){
                case 1:
                    System.Console.WriteLine("Solteiro(a)");
                    break;
                case 2:
                    System.Console.WriteLine("Desquitado(a)");
                    break;
                case 3:
                    System.Console.WriteLine("Casado(a)");
                    break;
                case 4:
                    System.Console.WriteLine("Divorciado(a)");
                    break;
                case 5:
                    System.Console.WriteLine("Viúvo(a)");
                    break;
                default:
                    System.Console.WriteLine("Opção inexistente");
                    break;
            }
        }
    }
}
