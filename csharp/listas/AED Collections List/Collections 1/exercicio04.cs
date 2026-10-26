using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pilha = new Stack<int>();

        Console.Write("Digite um valor positivo: ");
        int num = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        for (int i = 0; i < num; i++)
        {
            pilha.Push(a);

            int temp = a + b;
            a = b;
            b = temp;
        }

        while (pilha.Count > 0)
        {
            Console.Write($"{pilha.Pop()}, ");
        }
    }
}
