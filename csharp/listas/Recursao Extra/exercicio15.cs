using System;

class Program
{
    static int MultiplyProduct(int[] vet, int i = 0)
    {
        if(vet.Length == 0)
        {
            Console.WriteLine("Vetor está vazio!");
            return -1;
        } 
        if(i == vet.Length-1) return vet[i];
        return vet[i] * MultiplyProduct(vet,i+1);
    }
    static void Main()
    {
        Console.WriteLine(MultiplyProduct(new int[] {1,2,3,4,5}));
    }
}