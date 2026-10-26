using System;

class Program
{
    static bool BuscarElemento(int[] vet, int valor, int index = 0)
    {
        if (vet == null)
            throw new ArgumentNullException(nameof(vet));

        if (index < 0)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index >= vet.Length)
            return false;

        if (valor == vet[index])
            return true;

        return BuscarElemento(vet, valor, index + 1);
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(BuscarElemento(new[] { 3, 7, 3, 9, 3, 2 }, 2));
    }
}
