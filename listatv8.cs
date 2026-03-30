using System;
class listatv8
{
    static void Main2(string[] arg)
    {
        Console.WriteLine("Escreva um numero:");
        int n = int.Parse(Console.ReadLine());

        int fibonatti = 0;
        int fibonattiSoma = 1;
        int a;
        int i = 0;

        while(i < n)
        {
            Console.Write(fibonatti + " ");
            a = fibonatti;
            fibonatti = fibonattiSoma;
            fibonattiSoma = fibonatti + a;
            i++;
        }
    }
}