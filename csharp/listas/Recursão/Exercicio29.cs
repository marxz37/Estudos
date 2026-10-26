using System;

class Program
{
    static bool EhPar(int num)
    {
        if (num < 0)
            throw new ArgumentOutOfRangeException(nameof(num));

        if (num == 0)
            return true;

        return EhImpar(num - 1);
    }

    static bool EhImpar(int num)
    {
        if (num < 0)
            throw new ArgumentOutOfRangeException(nameof(num));

        if (num == 0)
            return false;

        return EhPar(num - 1);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(EhPar(3));
        Console.WriteLine(EhImpar(3));
        Console.WriteLine(EhPar(4));
        Console.WriteLine(EhImpar(4));
    }
}
