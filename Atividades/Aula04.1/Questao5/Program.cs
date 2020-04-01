using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer Elaborar um programa que lê 2 valores a e b e os 
            escreve com a mensagem: “São múltiplos” ou “Não são múltiplos”*/

            int a, b, m, cont = 0;
            bool validator = false;

            Console.Write("A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = int.Parse(Console.ReadLine());

            // Testando se A é multiplo de B.
            while(++cont <= 10){
                m = a * cont;
                if(m == b) {
                    System.Console.WriteLine("A é multiplo de B.");
                    validator = true;
                    break;
                }
            }

            // Testando se B é multiplo de A.
            cont = 0;
            while(++cont <= 10){
                m = b * cont;
                if(m == a) {
                    System.Console.WriteLine("B é multiplo de A.");
                    validator = true;
                    break;
                }
            }

            if (validator == false){
                System.Console.WriteLine("Não há multiplos.");
            }   
        }
    }
}
