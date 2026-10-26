using System;

class Program
{
    static int Soma(int n)
    {
        if (n == 0)
            return 0;

        return n + Soma(n - 1);
    }

    static void Main()
    {
        Console.WriteLine(Soma(4));
    }
}
