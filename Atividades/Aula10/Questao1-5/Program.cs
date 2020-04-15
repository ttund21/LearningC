using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            1) Elaborar um algoritmo que imprima números entre 0 e 20, em ordem ascendente.
            2) Elaborar um algoritmo que imprima números entre 0 e 20, em ordem descendente.
            3) Elaborar um algoritmo que imprima os números múltiplos de 10 entre 1 e 100.
            4) Elaborar um algoritmo que imprima a soma de todos os números entre 0 e 30. 
            5) Elaborar um algoritmo que leia um número e imprima o fatorial deste número (utilizar de comando enquanto).
            */
            
            // var
            int resp;

            // codigo
            while(true){
                Console.Write("\n1 - ascendente\n2 - descendente\n3 - multiplos de 10\n4 - Soma 30\n5 - Fatorial de um numero \n0 - finalizar\n>>> ");
                resp = int.Parse(Console.ReadLine());

                switch(resp){
                    case 1:
                        ascendente();
                        break;
                    case 2:
                        descendente();
                        break;
                    case 3:
                        multiplos10();
                        break;
                    case 4:
                        soma30();
                        break;
                    case 5:
                        System.Console.Write("Número: ");
                        fatorial(int.Parse(Console.ReadLine()));
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

        static void ascendente()
        {
            // var
            int i = 0;

            // codigo
            do {
                System.Console.Write(i + " ");
                ++i;
            } while (i <= 20);
            System.Console.WriteLine("\n----------------------------------------------------");

        }
        
        static void descendente()
        {
            // var
            int i = 20;

            // codigo
            do {
                System.Console.Write(i + " ");
                --i;
            } while (i >= 0);
            System.Console.WriteLine("\n----------------------------------------------------");
        }

        static void multiplos10()
        {
            // var
            int i = 10;

            // codigo
            do{
                System.Console.Write(i + " ");
                i += 10;
            }while (i <= 100);
            System.Console.WriteLine("\n----------------------------------------------------");
        }

        static void soma30()
        {
            // var
            int i = 0, z = 0;

            // codigo
            do {
                z += i;
                ++i;               
            } while(i <= 30);
            System.Console.Write(z);
            System.Console.WriteLine("\n----------------------------------------------------");
        }
        static void fatorial(int x)
        {
            // var
            int i = 1, z = 1;

            // codigo
            do {
                z *= i;
                ++i;               
            } while(i <= x);
            System.Console.Write($"Fatorial de {x}: {z}");
            System.Console.WriteLine("\n----------------------------------------------------");
        }
    }
}
