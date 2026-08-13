using System;
namespace CSharp
{
    class atividadecounterstrike
    {
        static void Main2()
        {
            int kills, deaths;

            float kd;

            Console.WriteLine("Let's see your K/D in Counter Strike.");
            
            Console.WriteLine("Type your Kills:");
            kills = int.Parse(Console.ReadLine());

            Console.WriteLine("Type your Deaths:");
            deaths = int.Parse(Console.ReadLine());

            kd = (float)kills / deaths;

            if(kd < 1)
            {
                Console.WriteLine("Você está Negativo, tente melhorar.");
            }
            else
            {
                Console.WriteLine("Você está Positivo, Parabéns!");
            }

            Console.WriteLine($"Seu K/D: {kd:F4}");
        }   
    }
}
    