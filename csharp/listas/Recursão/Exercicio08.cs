using System;

class Program
{
    static void Diminuir(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        Console.WriteLine(n);
        Diminuir(n - 1);
    }

    static void Main()
    {
        Diminuir(3);
    }
}
