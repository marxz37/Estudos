using System;
namespace CSharp
{
public class lista4
    {
        static void Main2(string[] arg)
        {
            //Entrada do Usuário:
            Console.WriteLine("Escreva um numero:");
            int num = int.Parse(Console.ReadLine());

            double num2 = (double)num % 3;

            //Condições:
            if (num2 == 0)
            {
                Console.WriteLine("Ele é divisivel por 3!");
            }
            else
            {
                Console.WriteLine("Ele não é divisivel por 3!");
            }

            double num3 = (double)num % 5;

            if (num3 == 0)
            {
                Console.WriteLine("Ele é divisivel por 5:");
            }
            else
            {
                Console.WriteLine("Ele não é divisivel por 5!");
            }
        }
    }
}