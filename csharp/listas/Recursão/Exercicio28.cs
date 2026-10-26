using System;

class Program
{
    static int MaiorUtilizandoAccumulator(int[] vet, int index = 0, int acumulador = int.MinValue)
    {
        if (vet == null)
            throw new ArgumentNullException(nameof(vet));

        if (vet.Length == 0)
            throw new ArgumentException("O vetor não pode estar vazio.", nameof(vet));

        if (index < 0 || index > vet.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index == vet.Length)
            return acumulador;

        if (vet[index] > acumulador)
            acumulador = vet[index];

        return MaiorUtilizandoAccumulator(vet, index + 1, acumulador);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(MaiorUtilizandoAccumulator(new[] { 15, 2, 48, 10, 33 }));
    }
}
