using System;

class Program
{
    static void Pares(int n)
    {
        if (n < 0 || n % 2 != 0)
        {
            Console.WriteLine("Apenas números positivos e pares!");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine(n);
            return;
        }

        Console.WriteLine(n);
        Pares(n - 2);
    }

    static void Main(string[] arg)
    {
        Pares(8);
    }
}
