using System;

class Program
{
    static int Difference(int[] vet)
    {
        if(vet.Length == 0)
        {
            Console.WriteLine("Array is empty!");
            return -1;
        }

        int FindMaxMin(int[] vet, int i, int max, int min)
        {
            if(i == vet.Length) return max-min;
            if(vet[i] < min) min = vet[i];
            if(vet[i] > max) max = vet[i];

            return FindMaxMin(vet,i+1,max,min);
        }
        return FindMaxMin(vet,0,int.MinValue,int.MaxValue);
    }
    static void Main()
    {
        Console.WriteLine(Difference(new int[] {1,2,3,4,5,6}));
    }
}