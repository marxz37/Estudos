using System;
using System.Linq; 
class Program
{
    static void Main()
    {
        int quant1 = 0;
        do
        {
            Console.WriteLine("Escreva a quantidade de elementos no vetor 1(X):");
            quant1 = int.Parse(Console.ReadLine());
        }
        while (quant1 <= 0);

        int quant2 = 0;
        do
        {
            Console.WriteLine("Escreva a quantidade de elementos no vetor 2(Y):");
            quant2 = int.Parse(Console.ReadLine());
        }
        while (quant2 <= 0);

        Random rnd = new Random();

        int[] vetx = new int[quant1];
        int[] vety = new int[quant2];

        for (int i = 0; i < vetx.Length; i++)
        {
            vetx[i] = rnd.Next(0, 10);
        }

        for (int i = 0; i < vety.Length; i++)
        {
            vety[i] = rnd.Next(0, 10);
        }

        Console.WriteLine("Vetor X: " + vetx);
        Console.WriteLine("Vetor Y: " + vety);

        if (quant1 == quant2)
        {
            Console.WriteLine("\n--- OPERAÇÕES POSIÇÃO POR POSIÇÃO ---");
            
            int[] soma = new int[quant1];
            int[] mult = new int[quant1];
            int[] diferenca = new int[quant1];

            Console.WriteLine("SOMA:");
            for (int i = 0; i < soma.Length; i++)
            {
                soma[i] = vetx[i] + vety[i];
                Console.WriteLine(soma[i]);
            }

            Console.WriteLine("MULTIPLICAÇÃO:");
            for (int i = 0; i < mult.Length; i++)
            {
                mult[i] = vetx[i] * vety[i];
                Console.WriteLine(mult[i]);
            }

            Console.WriteLine("DIFERENÇA:");
            for (int i = 0; i < diferenca.Length; i++)
            {
                diferenca[i] = vetx[i] - vety[i];
                Console.WriteLine(diferenca[i]);
            }
        }
        else
        {
            Console.WriteLine("\nAs operações de Soma, Multiplicação e Diferença não puderam ser feitas porque os vetores têm tamanhos diferentes.");
        }

        Console.WriteLine("\n--- OPERAÇÕES DE CONJUNTO ---");

        int[] intersecao = vetx.Intersect(vety).ToArray();
        Console.WriteLine("INTERSEÇÃO:");
        foreach (int item in intersecao)
        {
            Console.WriteLine(item);
        }

        int[] uniao = vetx.Union(vety).ToArray();

        Console.WriteLine("UNIÃO:");

        foreach (int item in uniao)
        {
            Console.WriteLine(item);
        }
    }
}
