using System;

class Program
{
    static void Mostrar(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(n);
            return;
        }

        Console.WriteLine(n);
        Mostrar(n - 1);
    }

    static void Main(string[] arg)
    {
        Mostrar(4);
    }
}
