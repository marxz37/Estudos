using System;
using System.Runtime.CompilerServices;
namespace CSharp
{
    class escolhaswitch
    {
        static void Main3(string[] arg)
        {
            //Explicação!
            Console.WriteLine("Você concorda com os termos?");
            Console.WriteLine("Escreva S ou N:");

            //Entrada do Usuário:
            char escolha = char.Parse(Console.ReadLine());

            //Condição:
            switch(escolha)
            {
                case 's':
                case 'S':
                Console.WriteLine("Você concorda com os termos!");
                break;

                case 'n':
                case 'N':
                Console.WriteLine("Você discorda com os termos!");
                break;

                default:
                Console.WriteLine("Escreva uma das opções!");
                break;
            }
        }
    }
}