using System;

class Program
{
    static int PositiveArray(int[] vet, int smallest = int.MaxValue, int i = 0)
    {
        if(vet.Length == 0)
        {
            Console.WriteLine("Array is empty!");
            return -1;
        } 

        if(i == vet.Length) return smallest;

        if(vet[i] < smallest) smallest = vet[i];

        return PositiveArray(vet, smallest, i+1);
    }
    static void Main()
    {
        Console.WriteLine(PositiveArray(new int[] { -11, 2, 3, 4, 5, 6 }));
    }
}