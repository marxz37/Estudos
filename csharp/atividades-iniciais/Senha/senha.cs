using System;

namespace csharp
{
    public class senha
    {
    public static void Main2(string[] arg)
    {
        Console.WriteLine("Digite sua senha:");
        const int senhaCorreta = 1234;
        int x;
        do
        {
            bool sucesso = int.TryParse(Console.ReadLine(), out x);
            if(x != senhaCorreta && sucesso == false)
            {
                Console.WriteLine("Apenas números por favor!");
            }
            else if(x != senhaCorreta)
            {
                Console.WriteLine("Senha Incorreta!"); 
            }
            else
            {
                Console.WriteLine("Senha Correta!"); 
            }
        }
        while(x != senhaCorreta);
    }
    }
}
