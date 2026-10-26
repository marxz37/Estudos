using System;

class Program
{
    static void Calcular(int n)
    {
        int x = n * 10;

        if (n == 0)
        {
            Console.WriteLine(x);
            return;
        }

        Calcular(n - 1);
        Console.WriteLine(x);
    }

    static void Main()
    {
        Calcular(2);
    }
}
