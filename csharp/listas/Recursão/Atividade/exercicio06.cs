using System;

class Program
{
    static int Fatorial(int n)
    {
        if (n <= 1)
            return 1;

        return n * Fatorial(n - 1);
    }

    static int SuperFatorial(int n)
    {
        if (n <= 1)
            return 1;

        return Fatorial(n) * SuperFatorial(n - 1);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(SuperFatorial(5));
    }
}
