using System;

class Program
{
    static int PositiveArray(int[] vet, int i = 0)
    {
        if(i == vet.Length) return 0;
        if(vet[i] > 0) return 1 + PositiveArray(vet,i+1);
        return PositiveArray(vet,i+1);
    }
    static void Main()
    {
        Console.WriteLine(PositiveArray(new int[] { -1, -2, -3, 4, 5, 6 }));
    }
}