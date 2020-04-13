using System;

namespace Questao38
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 38) Um plano de saúde, após as negociações com o governo enviou a tabela abaixo.
            Entrar com o nome e a idade de uma pessoa e imprimir o nome e o valor que ela deverá pagar.
            - > até 10 anos - R$ 30,00 
            - > 10 anos até 29 anos - R$ 60,00 
            - > 29 anos até 45 anos - R$ 120,00 
            - > 45 anos até 59 anos - R$ 150,00 
            - > 59 anos até 65 anos - R$ 250,00 
            - > maior que 65 anos - R$ 400,00 */

            // var
            string nome;
            int idade;

            // codigo
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            
            System.Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 10){
                System.Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nTotal a pagar: R$30,00");
            }
            else if (idade <= 29){
                System.Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nTotal a pagar: R$60,00");
            }
            else if (idade <= 45){
                System.Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nTotal a pagar: R$120,00");
            }
            else if (idade <= 59){
                System.Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nTotal a pagar: R$150,00");
            }
            else if (idade <= 65){
                System.Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nTotal a pagar: R$250,00");
            }
            else {
                System.Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nTotal a pagar: R$400,00");
            }
        }
    }
}
