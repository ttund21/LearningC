using System;

namespace Questao32
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 32)Um comerciante comprou um produto e quer vendê-lo com um lucro de 45%
            se o valor da compra for menor que R$ 20,00 ,  caso contrário, o lucro será de 30%.
            Entrar com o valor do produto e imprimir o valor da venda. */

            // var
            float produto, lucro;

            // codigo
            System.Console.Write("Valor do produto: R$");
            produto = float.Parse(Console.ReadLine());

            if (produto < 20){
                lucro = (produto * 45) / 100;
                System.Console.WriteLine($"\nValor da venda: R${produto + lucro}");
            }
            else {
                lucro = (produto * 30) / 100;
                System.Console.WriteLine($"\nValor da venda: R${produto + lucro}");
            }

        }
    }
}
