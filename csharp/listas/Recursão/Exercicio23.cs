using System;

class Program
{
    static int ContarOcorrencias(int[] vet, int valor, int index = 0)
    {
        if (vet == null)
            throw new ArgumentNullException(nameof(vet));

        if (index < 0)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index >= vet.Length)
            return 0;

        int quant = 0;

        if (valor == vet[index])
            quant = 1;

        return quant + ContarOcorrencias(vet, valor, index + 1);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(ContarOcorrencias(new[] { 3, 7, 3, 9, 3, 2 }, 3));
    }
}
