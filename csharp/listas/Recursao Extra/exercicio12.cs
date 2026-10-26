using System;

class Program
{
    static int Razao(int reason, int first, int sequence, int soma = 0)
    {
        if(sequence == 1) return soma+first;
        return Razao(reason,first*reason,sequence-1,soma+first);
    }
    static void Main()
    {
        Console.WriteLine(Razao(4,10,3));
    }
}