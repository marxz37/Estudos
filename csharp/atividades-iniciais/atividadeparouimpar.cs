using System;
using System.Security.Cryptography.X509Certificates;

namespace csharp
{
    public class atividadeparouimpar
    {
        static void Main2(string[] arg)
        {
            Console.WriteLine("Escreva qualquer número:");
            int x;
            bool sucesso;
            do
            {
                sucesso = int.TryParse(Console.ReadLine(), out x);
            }
            // da para fazer com == false;
            while(!sucesso);

            x = x % 2;

            if(x == 0)
            {
                Console.WriteLine("Seu numero é Par!");
            }
            else
            {
                Console.WriteLine("Seu numero é Impar!");
            }
        }
    }
}