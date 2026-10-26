using System;

class lista2
{
    static void Main(string[] args)
    {
        // Entrada do Usuário:
        Console.WriteLine("Escreva a idade 1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a idade 2:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a idade 3:");
        int num3 = int.Parse(Console.ReadLine());

        // Condições:
        if (num1 > num2 && num1 > num3) 
        {
            if (num2 > num3)
            {
                Console.WriteLine($"O maior número {num1}, o menor número {num3}");
            }
            else
            {
                Console.WriteLine($"O maior número {num1}, o menor número {num2}");
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            if (num1 > num3)
            {
                Console.WriteLine($"O maior número {num2}, o menor número {num3}");
            }
            else
            {
                Console.WriteLine($"O maior número {num2}, o menor número {num1}");
            }
        }
        else if (num3 > num1 && num3 > num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"O maior número {num3}, o menor número {num2}");
            }
            else
            {
                Console.WriteLine($"O maior número {num3}, o menor número {num1}");
            }
        }
        else
        {
            Console.WriteLine("Existem idades iguais!");
        }
    }
}