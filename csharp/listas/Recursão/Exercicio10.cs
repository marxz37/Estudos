using System;

class Program
{
    static void AproximarZero(int n)
    {
        if (n > 0)
        {
            Console.WriteLine(n);
            AproximarZero(n - 1);
        }

        if (n < 0)
        {
            Console.WriteLine(n);
            AproximarZero(n + 1);
        }

        if (n == 0)
        {
            Console.WriteLine(n);
            return;
        }
    }

    static void Main(string[] arg)
    {
        AproximarZero(4);
        AproximarZero(-4);
    }
}
