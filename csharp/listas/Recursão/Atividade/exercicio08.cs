using System;

class Program
{
    static double CalcularSerie(int n)
    {
        if (n <= 0)
            return 0;

        return CalcularSerie(n - 1) + (1.0 + n * n) / n;
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(CalcularSerie(5));
    }
}
