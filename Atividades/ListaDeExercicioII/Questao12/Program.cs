using System;

namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Entrar com nome, nota da PR1 e nota da PR2 de 1 aluno. Imprimir: nome,
            nota da PR1, nota da PR2, média truncada e uma das mensagens: AP , RP ou PF (a
            média é 7 para aprovação, menor que 3 para reprovação e as demais em prova final).*/
            
            // var
            float nota1, nota2, media;
            string nome;

            // codigo
            System.Console.Write("Escreva seu nome: ");
            nome = Console.ReadLine();
            System.Console.Write("Escreva a 1ª Nota: ");
            nota1 = float.Parse(Console.ReadLine());
            System.Console.Write("Escreva a 2ª Nota: ");
            nota2 = float.Parse(Console.ReadLine());
            
            media = (nota1 + nota2)/2;

            if (media >= 7){
                System.Console.WriteLine($"1ª Nota: {nota1}\n2ª Nota: {nota2}\nMédia: {media}\nAP");                
            } 
            else if (media < 3){
                System.Console.WriteLine($"1ª Nota: {nota1}\n2ª Nota: {nota2}\nMédia: {media}\nRP");
            }
            else {
                System.Console.WriteLine($"1ª Nota: {nota1}\n2ª Nota: {nota2}\nMédia: {media}\nPF");
            }         
        }
    }
}
