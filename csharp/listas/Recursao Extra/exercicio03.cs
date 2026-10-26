using System;

class Program
{
    static int SomeDigitos(int num)
    {
        if(num <= 9) return num;

        int temp = num % 10;

        return temp + SomeDigitos(num/10);
    }
    static void Main()
    {
        Console.WriteLine(SomeDigitos(1234));
    }
}