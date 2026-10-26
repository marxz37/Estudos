using System;

class Program
{
    static void Problema(int n)
    {
        Console.WriteLine(n);

        if (n >= 10)
            return;

        Problema(n + 1);
    }

    static void Main()
    {
        Problema(1);
    }
}
