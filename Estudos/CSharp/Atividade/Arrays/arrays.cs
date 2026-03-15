using System;
using System.Security.Cryptography.X509Certificates;
namespace arrays
{
    class arrays
    {
        static void Main2()
        {
            Console.WriteLine("Escreva o nome de cada integrante do seu esquadrão de time:");
            string[] squad = new string[4];
            for (int x = 0; x < squad.Length; x++)
            {
                squad[x] = Console.ReadLine();
                Console.WriteLine($"Participante '{squad[x]}' adicionado com sucesso!");
            }   
            Console.WriteLine("Seu Esquadrão:");
            for(int x = 0; x < squad.Length; x++)
            {
                Console.WriteLine(squad[x]);
            }
        }
    }
}