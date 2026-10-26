using System;

class Program
{
    static int SomaIntervalo(int num, int num1)
    {
        if(num >= num1) return num;

        return num + SomaIntervalo(num+1,num1);
    }
    static void Main()
    {
        Console.WriteLine(SomaIntervalo(1,11));
    }
}