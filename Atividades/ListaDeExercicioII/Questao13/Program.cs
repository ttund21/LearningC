using System;

namespace Questao13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 13) Entrar com o nome da capital do Brasil. Se a resposta estiver correta,imprimir 
            PARABÉNS, caso contrário, ERROU. (Considerar: BRASÍLIA ou Brasília)*/
            
            //var
            string resp;

            System.Console.Write("Qual a capital do Brasil?\n>>> ");
            resp = Console.ReadLine();

            if (resp == "Brasília" || resp == "BRASÍLIA"){
                System.Console.WriteLine("Correto!");
            }
            else {
                System.Console.WriteLine("Incorreto!");
            }
        }
    }
}
