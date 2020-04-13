using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6-Ler nome, endereço e telefone e imprimi-los.
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            System.Console.WriteLine($"\nNome: {nome}\nEndereço: {endereco}\nTelefone: {telefone}");
        }
    }
}
