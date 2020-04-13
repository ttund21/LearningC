using System;

namespace Questao34
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 34) Entrar com o ano de nascimento de uma pessoa e o ano atual. Imprimir a idade
            da pessoa. Não se esqueça de verificar se o ano de nascimento é um ano válido. */

            // var
            int anoNasc, anoAtual;

            // codigo
            Console.Write("Ano de nascimento: ");
            anoNasc = int.Parse(Console.ReadLine());
            System.Console.Write("Ano atual: ");
            anoAtual = int.Parse(Console.ReadLine());

            if (anoNasc > anoAtual){
                System.Console.WriteLine("Data Nascimento Inválida.");
            }
            else{
                System.Console.WriteLine($"Idade: {anoAtual - anoNasc}");
            }
        }
    }
}
