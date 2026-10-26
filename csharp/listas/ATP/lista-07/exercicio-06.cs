using System;
class Exercicio06
{
    static void MultiplicarEscalar(int[,] matriz, int n)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
            for (int j = 0; j < matriz.GetLength(1); j++)
                matriz[i, j] *= n;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
                Console.Write(matriz[i, j].ToString().PadLeft(6));
            Console.WriteLine();
        }
    }

    static int LerDimensaoValida(string mensagem)
    {
        int valor;
        do
        {
            Console.Write(mensagem);
            valor = int.Parse(Console.ReadLine());
            if (valor <= 0)
            {
                Console.WriteLine("Tamanho inválido! A dimensão da matriz deve ser maior que zero.");
            }
        } while (valor <= 0);
        return valor;
    }

    static void Main(string[] args)
    {
        int linhas = LerDimensaoValida("Digite o número de linhas: ");
        int colunas = LerDimensaoValida("Digite o número de colunas: ");

        int[,] A = new int[linhas, colunas];

        Console.WriteLine("\n--- Preencha a Matriz (Valores podem ser negativos) ---");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"A[{i}][{j}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz A original:");
        ImprimirMatriz(A);

        Console.Write("\nDigite o escalar n: ");
        int n = int.Parse(Console.ReadLine());

        MultiplicarEscalar(A, n);

        Console.WriteLine($"\nMatriz A após multiplicação por {n}:");
        ImprimirMatriz(A);
    }
}