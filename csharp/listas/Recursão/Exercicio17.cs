using System;

class Program
{
    static int Metodo(int n)
    {
        if (n == 1)
            return 2;

        return 2 + Metodo(n - 1);
    }

    static void Main()
    {
        Console.WriteLine(Metodo(5));
    }
}
