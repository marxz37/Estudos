using System;
class Program
{
    static int CalcularPell(int num, int result = 0)
    {
        if(num <= 0)
            return num;

        if(num == 1)
            return num;

        return 2 * CalcularPell(num - 1) + CalcularPell(num - 2);
    }
    static void Main(string[] arg)
    {
        Console.WriteLine(CalcularPell(2));
    }
}