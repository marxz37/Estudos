using System;
class Program 
{
    static void Main() 
    {
        double[,] matriz = new double[10, 10];
        
        for (int i = 0; i < 10; i++) 
        {
            for (int j = 0; j < 10; j++) 
            {
                if (i < j) 
                {
                    matriz[i, j] = 2 * i + 7 * j - 2;
                } 
                else if (i == j) 
                {
                    matriz[i, j] = 3 * Math.Pow(i, 2) - 1;
                } 
                else 
                {
                    matriz[i, j] = 4 * Math.Pow(i, 3) - 5 * Math.Pow(j, 2);
                }
            }
        }

        Console.WriteLine("---MATRIZ GERADA---");
        for (int i = 0; i < 10; i++) 
        {
            for (int j = 0; j < 10; j++) 
            {
                Console.Write($"{matriz[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}