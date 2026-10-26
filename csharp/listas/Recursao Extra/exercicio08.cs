using System;

class Program
{
    static int Digitos(int num)
    {
        if(num < 10) return 1;

        return 1 + Digitos(num/10);
    }
    static void Main()
    {
        Console.WriteLine(Digitos(1125123));
    }
}