using System;

class Program
{
    static string ConverterParaBinario(int n)
    {
        if (n < 2)
            return n.ToString();

        return ConverterParaBinario(n / 2) + n % 2;
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(ConverterParaBinario(13));
    }
}
