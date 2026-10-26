using System;

class Program
{
    static void Teste(int n)
    {
        if (n == 0)
            return;

        Console.WriteLine(n);
        Teste(n - 1);
    }

    static void Main()
    {
        Teste(4);
    }
}
