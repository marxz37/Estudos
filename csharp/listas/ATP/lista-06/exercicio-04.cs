using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        double[,] mat = new double[3,6];
        
        //DECLARAÇÃO DE VALORES:
        //MATRIZ 1!
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i,j] = rnd.NextDouble() * 100;
            }
        }
        Console.Write("\n---VALOR DA MATRIZ---\n");
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"{mat[i,j]:F2} ");
            }
            Console.WriteLine();
        }
        
        double soma = 0;
        double media = 0;
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            soma += mat[i,0];
            soma += mat[i,2];
            soma += mat[i,4];
            media += mat[i,3];
            media += mat[i,5];
        }
        media /= mat.GetLength(0);
        
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            mat[i,5] = mat[i,1] + mat[i,2]; 
        }
        
        Console.Write("\n---VALOR DA MATRIZ MODIFICADA---\n");
        
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"{mat[i,j]:F2} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($"Soma dos Pares 0,2,4 = {soma:F2}");
        Console.WriteLine($"Média Aritmética = {media:F2}");
    }
}