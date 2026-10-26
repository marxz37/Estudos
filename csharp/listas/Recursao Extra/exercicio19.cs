using System;

class Program
{
    static void ChangeOccurrences(int[] vet, int x, int y, int i = 0)
    {
        if(vet.Length == 0)
        {
            Console.WriteLine("Array is empty!");
            return;
        }

        if(i == vet.Length) return;

        if(vet[i] == x) vet[i] = y;

        ChangeOccurrences(vet,x,y,i+1);
    }
    static void Main()
    {
        int[] vet = {3, 2, 2, 2, 5, -1};

        foreach(int e in vet)
        {
            Console.Write($"{e} ");
        }

        ChangeOccurrences(vet,-1,3);

        Console.WriteLine();

        foreach(int e in vet)
        {
            Console.Write($"{e} ");
        }
    }
}