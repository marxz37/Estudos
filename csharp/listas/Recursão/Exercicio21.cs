using System;

class Program
{
    static int SomarVetor(int[] vet, int index = 0)
    {
        if (vet == null)
            throw new ArgumentNullException(nameof(vet));

        if (index < 0 || index > vet.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index == vet.Length)
            return 0;

        return vet[index] + SomarVetor(vet, index + 1);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(SomarVetor(new[] { 8, 3, 5, 2 }, 0));
    }
}
