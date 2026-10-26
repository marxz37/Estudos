using System;

class Program
{
    static int MaiorElemento(int[] vet, int index = 0)
    {
        if (vet == null)
            throw new ArgumentNullException(nameof(vet));

        if (vet.Length == 0)
            throw new ArgumentException("O vetor não pode estar vazio.", nameof(vet));

        if (index < 0 || index >= vet.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index == vet.Length - 1)
            return vet[index];

        int maiorAtual = MaiorElemento(vet, index + 1);

        if (vet[index] > maiorAtual)
            maiorAtual = vet[index];

        return maiorAtual;
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(MaiorElemento(new[] { 4, 19, 7, 31, 12 }, 0));
    }
}
