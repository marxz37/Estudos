using System;

public class descobriromenor
{
    public static void Main3(string[] args)
    {
        //Declaração das variaveis
        int num1, num2, num3;
        
        //Entrada do Usuário
        Console.WriteLine("Escreva o número 1:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o número 2:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o número 3:");
        num3 = int.Parse(Console.ReadLine());
        
        //Condições
        if(num1 < num2 & num1 < num3)
        {
            Console.WriteLine($"O número {num1} é o menor!");
        }
        else if(num2 < num1 & num2 < num3)
        {
            Console.WriteLine($"O número {num2} é o menor!");
        }
        else if(num3 < num1 & num3 < num2)
        {
            Console.WriteLine($"O número {num3} é o menor!");
        }
        else
        {
            Console.WriteLine($"Os três números são iguais!");
        }
    }
}