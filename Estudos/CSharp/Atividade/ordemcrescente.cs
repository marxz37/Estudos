using System;

public class ordemcrescente
{
    public static void Main2(string[] args)
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
        if(num1 > num2 && num1 > num3)
        {
            if(num2 > num3)
            {
                Console.WriteLine($"{num3}, {num2}, {num1}");
            }
            else
            {
                Console.WriteLine($"{num2}, {num3}, {num1}");
            }
        }
        else if(num2 > num1 && num2 > num3)
        {
            if(num1 > num3)
            {
                Console.WriteLine($"{num3}, {num1}, {num2}");
            }
            else
            {
                Console.WriteLine($"{num1}, {num3}, {num2}");
            }
            
        }
        else if(num3 > num1 && num3 > num2)
        {
            if(num1 > num2)
            {
                Console.WriteLine($"{num2}, {num1}, {num3}");
            }
            else
            {
                Console.WriteLine($"{num1}, {num2}, {num3}");
            }
        }
        else
        {
            Console.WriteLine($"{num1}, {num2}, {num3}");
        }
    }
}