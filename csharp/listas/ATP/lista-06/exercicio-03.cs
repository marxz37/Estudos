using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        double[,] mat = new double[10,10];
        
        //DECLARAÇÃO DE VALORES:
        //MATRIZ 1!
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i,j] = rnd.Next(0,99);
            }
        }
        
        Console.Write($"\n---MATRIZ NORMAL 10x10---\n");
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"{mat[i,j]} ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine($"\n---MATRIZ MODIFICADO 10x10---\n");
        double sqrt = 0;
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            mat[i,i] = Math.Sqrt(mat[i,i]);
        }
        
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"{mat[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}