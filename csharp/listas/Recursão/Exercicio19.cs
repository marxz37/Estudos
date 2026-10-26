using System;

class Program
{
    static void Explorar(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Centro");
            return;
        }

        Console.WriteLine($"Entrando {n}");
        Explorar(n - 1);
        Console.WriteLine($"Saindo {n}");
    }

    static void Main(string[] arg)
    {
        Explorar(3);
    }
}
