using System;

public class FibonacciVetores
{
    public static void Main(string[] args)
    {
        Console.Write("n = ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Por favor, insira um valor inteiro positivo.");
            return;
        }

        int[] fib = new int[n];

        if (n >= 1) fib[0] = 1;
        if (n >= 2) fib[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        Console.Write("Crescente: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(fib[i] + (i < n - 1 ? ", " : ".\n"));
        }

        Console.Write("Decrescente: ");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(fib[i] + (i > 0 ? ", " : ".\n"));
        }

        Console.Write("Posição para busca: ");
        if (!int.TryParse(Console.ReadLine(), out int posicao) || posicao < 1 || posicao > n)
        {
            Console.WriteLine("Posição inválida.");
            return;
        }

        int valorCrescente = fib[posicao - 1]; 
        int valorDecrescente = fib[n - posicao]; 

        Console.WriteLine($"Posição {posicao} -> resulta no valor {valorCrescente} e {valorDecrescente}.");
    }
}