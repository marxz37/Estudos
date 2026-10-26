using System;

class Program
{
    static void Teste(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        Teste(n - 1);
        Console.WriteLine(n);
    }

    static void Main()
    {
        Teste(4);
    }
}
