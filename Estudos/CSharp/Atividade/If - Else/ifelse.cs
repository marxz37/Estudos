using System;
namespace csharp
{
    class ifelse
    {
        static void Main2(string[] arg)
        {
            int idade;
            string vip, amigo;
            bool sucesso;
            do
            {
            Console.WriteLine("Quantos anos você tem?");
            sucesso = int.TryParse(Console.ReadLine(), out idade);
            if(sucesso == false)
                {
                    Console.WriteLine("Escreva apenas números!");
                }
                else if(idade < 18)
                {
                    Console.WriteLine("Você não tem idade para entrar!");
                }
            }
            while(!sucesso);

            bool confirmado;
            
            Console.WriteLine("Amigo do Chefe?");
            
            
            do
            {
            amigo = Console.ReadLine().ToLower();
            if(amigo == "sim" || amigo == "s" || amigo == "nao" || amigo == "n")
            {
                confirmado = true;
            }
            else
            {
                confirmado = false;
                Console.WriteLine("Apenas Escreva sim, s, nao, n!");
            }
            }
            while(!confirmado);

            
            if(amigo == "sim" || amigo == "s")
            {
                Console.WriteLine("Pode entrar!");
                Environment.Exit(0);
            }
            else if(amigo == "nao" || amigo == "n")
            {
                Console.WriteLine("Verificando!");
            }
            Console.WriteLine("Você tem VIP?");
            vip = Console.ReadLine().ToLower();

            if(vip == "sim" || vip == "s")
            {
                Console.WriteLine("Pode entrar!");
            }
            
            else if(vip == "nao" || vip == "n")
            {
                Console.WriteLine("Cai fora daqui!");
            }
            
        }
    }
}