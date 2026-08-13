using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int[,] mat = new int[4,4];
        bool matriz_triangular_superior = true; 
        
        // DECLARAÇÃO DE VALORES:
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"mat[{i},{j}] = ");
                mat[i,j] = int.Parse(Console.ReadLine());
            }
        }  
        Console.WriteLine();
        for(int i = 1; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < i; j++)
            {
                if(mat[i,j] != 0)
                {
                    matriz_triangular_superior = false;
                }
            }
        }
        
        if(matriz_triangular_superior == true)
        {
            Console.WriteLine("É uma matriz triangular superior!");
        }
        else
        {
            Console.WriteLine("Não é uma matriz triangular superior!");
        }
    }
}