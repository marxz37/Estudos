using System;

class Program
{
    static int DividirDoisNumeros(int num, int num2)
    {
        if(num2 == 0) return 0;
        if(num < num2) return 0;

        return 1 + DividirDoisNumeros(num-num2,num2);
    }
    static void Main()
    {
        Console.WriteLine(DividirDoisNumeros(74,5));
    }
}