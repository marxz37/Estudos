using System;

namespace CSharp
{
    class atividadeenergia
    {
        static void Main1()
        {
            Console.WriteLine("Seu nivel de Energia Amaldiçoada:");
            int x = int.Parse(Console.ReadLine());

            if(x >= 10000)
            {
                Console.WriteLine("Alerta: Maldição de Grau Especial detectada!");
            }
            else if(x >= 5000 && x <= 9999)
            {
                Console.WriteLine("Maldição de Grau 1");
            }
            else
            {
                Console.WriteLine("Maldição de Grau 2 ou inferior. Controle padrão.");
            } 
        }
    }
}