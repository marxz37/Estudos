using System;
public class OperacoesConjuntos
{
    public static void Main(string[] args)
    {
        int[] x = new int[5];
        int[] y = new int[5];

        Console.WriteLine("Preencha o vetor X (5 números sem repetir):");
        for (int i = 0; i < x.Length; i++)
        {
            Console.Write($"x[{i}]: ");
            x[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nPreencha o vetor Y (5 números sem repetir):");
        for (int i = 0; i < y.Length; i++)
        {
            Console.Write($"y[{i}]: ");
            y[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n----- SOMA -----");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{x[i] + y[i]} ");
        }

        Console.WriteLine("\n\n----- PRODUTO -----");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{x[i] * y[i]} ");
        }

        Console.WriteLine("\n\n----- DIFERENÇA (X - Y) -----");
        for (int i = 0; i < 5; i++)
        {
            bool existeEmY = false;
            for (int j = 0; j < 5; j++)
            {
                if (x[i] == y[j])
                {
                    existeEmY = true;
                    break;
                }
            }
            if (!existeEmY)
            {
                Console.Write($"{x[i]} ");
            }
        }

        Console.WriteLine("\n\n----- INTERSEÇÃO -----");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (x[i] == y[j])
                {
                    Console.Write($"{x[i]} ");
                    break;
                }
            }
        }

        Console.WriteLine("\n\n----- UNIÃO -----");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{x[i]} ");
        }

        for (int i = 0; i < 5; i++)
        {
            bool existeEmX = false;
            for (int j = 0; j < 5; j++)
            {
                if (y[i] == x[j])
                {
                    existeEmX = true;
                    break;
                }
            }
            if (!existeEmX)
            {
                Console.Write($"{y[i]} ");
            }
        }
        Console.WriteLine();
    }
}