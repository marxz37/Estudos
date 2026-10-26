using System;

class Program
{
    static int SomarVetor(int[] vet, int index = 0, int acumulador = 0)
    {
        if (vet == null)
            throw new ArgumentNullException(nameof(vet));

        if (index < 0 || index > vet.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index == vet.Length)
            return acumulador;

        acumulador += vet[index];

        return SomarVetor(vet, index + 1, acumulador);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(SomarVetor(new[] { 2, 5, 7, 10 }));
    }
}
