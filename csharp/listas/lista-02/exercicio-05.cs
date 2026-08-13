using System;
namespace HelloWorld
{
    public class lista5
    {
        static void Main2(string[] arg)
        {
            //Entrada do Usuário:
            Console.WriteLine("Escreva sua idade:");
            int x = int.Parse(Console.ReadLine());

            //Condições:
            if(x >= 5 && x <= 7)
            {
                Console.WriteLine("Você está na categoria Infantil A!");
            }
            else if(x >= 8 && x <= 10)
            {
                Console.WriteLine("Você está na categoria Infantil B!");
            }
            else if(x >= 11 && x <= 13)
            {
                Console.WriteLine("Você está na categoria Juvenil A!");
            }
            else if(x >= 14 && x <= 17)
            {
                Console.WriteLine("Você está na categoria Juvenil B!");
            }
            else if(x >= 18)
            {
                Console.WriteLine("Você está na categoria Senior!");
            }
            else
            {
                Console.WriteLine("Você não tem idade o suficiente ou digite apenas números positivos!");
            }
        }    
    }
}   