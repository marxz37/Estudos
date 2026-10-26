using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int n = -1;
        do
        {
            Console.WriteLine ("Escreva um numero inteiro para criar a matriz:");
            //int n = rnd.Next(0,5);
            n = int.Parse(Console.ReadLine());
        }
        while(n < 0);
        
        int[,] mat = new int[n,n];
        
        //DECLARAÇÃO DE VALORES:
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i,j] = rnd.Next(0,99);
            }
        }
        
        //A soma de cada linha:
        Console.WriteLine($"\n---Linha---");
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            int somaLinha = 0;
            for(int j = 0; j < mat.GetLength(1); j++)
            {
               somaLinha += mat[i,j];
            }
            Console.WriteLine($"Resultado da Soma das linhas {i}: {somaLinha}");
        }
        
        //A soma de cada coluna:
        Console.WriteLine($"\n---Coluna---");
        for(int j = 0; j < mat.GetLength(0); j++)
        {
            int somaColuna = 0;
            for(int i = 0; i < mat.GetLength(1); i++)
            {
               somaColuna += mat[i,j];
            }
            Console.WriteLine($"Resultado da Soma das Colunas {j}: {somaColuna}");
        }
        
        //A soma de cada diagonal:
        Console.WriteLine($"\n---Diagonal---");
        int somaDiagonal = 0;
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            somaDiagonal += mat[j,j];
        }
        Console.WriteLine($"Resultado da Soma da Diagonal: {somaDiagonal}");
        
        //A soma de cada diagonal invertido:
        Console.WriteLine($"\n---Diagonal Invertido---");
        int somaDiagonal_Invertido = 0;
        for(int i = 0, j = mat.GetLength(1)-1; i < mat.GetLength(0); i++, j--)
        {
            somaDiagonal_Invertido += mat[i,j];
        }
        Console.WriteLine($"Resultado da Soma da Diagonal Invertido: {somaDiagonal_Invertido}");
    }
}