using System;

class Program
{
    static int Potencia(int n, int y)
    {
        if (y <= 0)
            return 1;

        return n * Potencia(n, y - 1);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(Potencia(2, 4));
    }
}
