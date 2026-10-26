using System;

class Program
{
    static int MaximoDivisorComum(int x, int y)
    {
        if (y == 0)
            return Math.Abs(x);

        return MaximoDivisorComum(y, x % y);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(MaximoDivisorComum(4, 6));
    }
}
