using System;
class Exercicio12a
{
    static void ObterMaiorElemento(int[,] matriz, out int k, out int lin, out int col)
    {
        k = matriz[0, 0];
        lin = 0;
        col = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > k)
                {
                    k = matriz[i, j];
                    lin = i;
                    col = j;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho n da matriz (n x n): ");
        int n = int.Parse(Console.ReadLine());

        while (n <= 0)
        {
            Console.Write("Tamanho inválido! A matriz precisa ser de pelo menos 1x1. Digite novamente: ");
            n = int.Parse(Console.ReadLine());
        }
        int[,] A = new int[n, n];
        Console.WriteLine("\n--- Preencha a Matriz (Valores negativos são aceitos) ---");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"A[{i}][{j}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int k, lin, col;
        ObterMaiorElemento(A, out k, out lin, out col);
        Console.WriteLine($"\nMaior elemento (k): {k}");
        Console.WriteLine($"Linha (lin): {lin}");
        Console.WriteLine($"Coluna (col): {col}");
    }
}