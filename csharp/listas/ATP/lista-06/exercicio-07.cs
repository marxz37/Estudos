using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int m = -1;
        int n = -1;
        do
        {
            Console.WriteLine("Escreva o número de linhas (m):");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o número de colunas (n):");
            n = int.Parse(Console.ReadLine());
        }
        while(n <= 0 || m <= 0);
        
        int[,] mat = new int[m, n];
        
        for (int l = 0; l < m; l++)
        {
            for (int c = 0; c < n; c++)
            {
                mat[l,c] = rnd.Next(0,2); 
            }
        }
        
        int linhasNulas = 0;
        int colunasNulas = 0;
        
        for (int l = 0; l < m; l++)
        {
            int somaLinha = 0;
            for (int c = 0; c < n; c++)
            {
                somaLinha += mat[l,c];
            }
            if(somaLinha == 0)
            {
                linhasNulas++;
            }
        }
        
        for (int c = 0; c < n; c++)
        {
            int somaColuna = 0;
            for (int l = 0; l < m; l++)
            {
                somaColuna += mat[l,c];
            }
            if(somaColuna == 0)
            {
                colunasNulas++;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine($"Saída: A matriz tem {linhasNulas} linhas nulas e {colunasNulas} coluna nula");
        
        Console.WriteLine($"\n---MATRIZ---\n");
        for (int l = 0; l < m; l++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write($"{mat[l,c]} ");
            }
            Console.WriteLine();
        }
    }
}