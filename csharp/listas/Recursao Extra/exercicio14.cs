using System;

class Program
{
    static void CountDecreasingEven(int num)
    {
        if(num <= 0)
        {
            Console.WriteLine("Only positive numbers!");
            return;
        }
        if(num % 2 == 1) num--;
        if(num == 0)
        {
            Console.WriteLine("Ending!");
            return;
        }

        Console.WriteLine(num);

        CountDecreasingEven(num-2);

        Console.WriteLine("Ending!");
    }
    static void Main()
    {
        CountDecreasingEven(10);
    }
}