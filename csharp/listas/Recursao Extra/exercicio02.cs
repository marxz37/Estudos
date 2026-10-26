using System;

class Program
{
    static int Potencia(int num, int exp)
    {
        if(exp < 0) return 0;
        if(exp == 0) return 1;

        return num * Potencia(num, exp-1);
    }
    static void Main()
    {
        Console.WriteLine(Potencia(2,5));
    }
}