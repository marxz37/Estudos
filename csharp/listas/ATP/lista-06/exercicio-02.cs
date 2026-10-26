using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = -1;
        int m = -1;
        Random rnd = new Random();
        do
        {
            //int n = rnd.Next(0,5);
            //int m = rnd.Next(0,5);
            Console.WriteLine ("Escreva um numero inteiro para a Linha:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine ("Escreva um numero inteiro para a Coluna:");
            m = int.Parse(Console.ReadLine());
        }
        while(n <= 0 || m <= 0);
        
        int[,] mat = new int[n,m];
        
        //DECLARAÇÃO DE VALORES:
        //MATRIZ 1!
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i,j] = rnd.Next(0,99);
            }
        }
        
        //DECLARAÇÃO DE VALORES:
        //MATRIZ 2!
        int[,] mat2 = new int[n,m];
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                mat2[i,j] = rnd.Next(0,99);
            }
        }
        
        //COMPARAÇÃO PARA SABER SE HÁ VALORES IGUAIS:
        bool encontrado = false;
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                if(mat[i,j] == mat2[i,j])
                {
                    encontrado = true;
                    Console.WriteLine($"Valor igual encontrado! mat[{i},{j}] = {mat[i,j]}");
                }
            }
        }
        
        if(encontrado == false)
        {
            Console.WriteLine($"Valor não encontrado!");
        }
    }
}