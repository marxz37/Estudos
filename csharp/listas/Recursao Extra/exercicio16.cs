using System;

class Program
{
    static int[] InvertArray(int[] vet)
    {
        int[] Invert(int index, int length)
        {
            if(index >= length) return vet;

            int temp = vet[index];

            vet[index] = vet[length];

            vet[length] = temp;

            return Invert(index+1,length-1);
        }
        
        return Invert(0,vet.Length-1);
    }
    static void Main()
    {
        int[] vet = {1, 2, 3, 4, 5};

        InvertArray(vet);

        foreach(var e in vet)
        {
            Console.Write($"{e} ");
        }
    }
}