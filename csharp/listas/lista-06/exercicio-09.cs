using System;
class Program 
{
    static void Main() 
    {
        double[,] matriz = new double[3, 6];

        Console.WriteLine("Digite os valores para a matriz 3x6:");
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 6; j++) 
            {
                Console.Write($"Posição [{i},{j}]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }
        
        double somaImpares = 0;
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 6; j++) 
            {
                if((j + 1) % 2 != 0) 
                {
                    somaImpares += matriz[i, j];
                }
            }
        }
        Console.WriteLine($"\n(a) Soma das colunas. Ímpares: {somaImpares}");

        double somaMedia = 0;
        for (int i = 0; i < 3; i++) 
        {
            somaMedia += matriz[i, 1];
            somaMedia += matriz[i, 3];
        }
        somaMedia /= 6;
        Console.WriteLine($"(b) Média da 2ª e 4ª. Colunas: {somaMedia:F2}");

        for (int i = 0; i < 3; i++) 
        {
            matriz[i, 5] = matriz[i, 0] + matriz[i, 1];
        }
        Console.WriteLine("(c) Sexta coluna atualizada com a soma da 1ª e 2ª.");

        Console.WriteLine("\n(d) ---Matriz Modificada---");
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 6; j++) 
            {
                Console.Write($"{matriz[i, j]:F2} ");
            }
            Console.WriteLine();
        }
    }
}