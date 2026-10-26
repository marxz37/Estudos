using System;

public class Program
{
    public static void Main()
    {
        int[,] matrizA = new int[4,4];

        Random rnd = new Random();

        for(int i = 0; i < matrizA.GetLength(0); i++)
        {
            for(int j = 0; j < matrizA.GetLength(1); j++)
            {
                int valor;
                Console.Write($"Escreva um número (matrizA[{i},{j}]): ");
                while (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.Write($"Entrada inválida. Digite novamente (matrizA[{i},{j}]): ");
                }
                matrizA[i, j] = valor;
            }
        }

        for(int i = 0; i < matrizA.GetLength(0); i++)
        {
            for(int j = 0; j < matrizA.GetLength(1); j++)
            {
                Console.Write($"{matrizA[i,j]}\t");
            }
            Console.WriteLine();
        }

        int linhaNula = 0;
        int colunaNula = 0;

        for(int l = 0; l < matrizA.GetLength(0); l++)
        {
            bool verificarLinhaNula = true;
            for(int c = 0; c < matrizA.GetLength(1); c++)
            {
                if (matrizA[l,c] != 0)
                {
                    verificarLinhaNula = false;
                    break;
                }
                
            }
            if (verificarLinhaNula)
            {
                linhaNula++;
            }
        }

        for(int c = 0; c < matrizA.GetLength(1); c++)
        {
            bool verificarColunaNula = true;
            for(int l = 0; l < matrizA.GetLength(0); l++)
            {
                if (matrizA[l,c] != 0)
                {
                    verificarColunaNula = false;
                    break;
                }
            }
            if (verificarColunaNula)
            {
                colunaNula++;
            }
        }

        Console.WriteLine($"Total de Linhas nulas: {linhaNula}");
        Console.WriteLine($"Total de Colunas nulas: {colunaNula}");
    }
}