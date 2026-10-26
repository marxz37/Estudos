using System;

class Program
{
    static void Contagem(int n)
    {
        Console.WriteLine(n);

        if (n == 0)
            return;

        Contagem(n - 1);
    }

    static void Main()
    {
        Contagem(5);
    }
}
