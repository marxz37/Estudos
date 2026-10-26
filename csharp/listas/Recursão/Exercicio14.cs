using System;

class Program
{
    static void Misterio(int n)
    {
        if (n == 0)
            return;

        Console.WriteLine($"A{n}");
        Misterio(n - 1);
        Console.WriteLine($"B{n}");
    }

    static void Main()
    {
        Misterio(3);
    }
}
