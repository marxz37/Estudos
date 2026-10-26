using System;

class Program
{
    static double Somar(int n)
    {
        if(n == 1)
        {
            return 1;
        }
        else
        {
            return Math.Pow(n,3) + Somar(n-1);
        }
    }
    static void Main(string[] arg)
    {
        Console.WriteLine(Somar(3));
    }
}