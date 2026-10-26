using System;

class Program
{
    static int SegundaMaiorOcorrencia(
        int[] vet,
        int index = 0,
        int maior = int.MinValue,
        int segundaMaior = int.MinValue)
    {
        if (vet == null)
            throw new ArgumentNullException(nameof(vet));

        if (vet.Length < 2)
            throw new ArgumentException("O vetor precisa ter pelo menos dois elementos.", nameof(vet));

        if (index < 0 || index > vet.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index == vet.Length)
            return segundaMaior;

        if (vet[index] > maior)
        {
            segundaMaior = maior;
            maior = vet[index];
        }
        else if (vet[index] < maior && vet[index] > segundaMaior)
        {
            segundaMaior = vet[index];
        }

        return SegundaMaiorOcorrencia(vet, index + 1, maior, segundaMaior);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(SegundaMaiorOcorrencia(new[] { 8, 20, 4, 20, 15, 3 }));
    }
}
