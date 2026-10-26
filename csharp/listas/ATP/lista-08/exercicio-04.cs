using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        string invertida = "";

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            invertida += palavra[i];
        }

        Console.WriteLine("Palavra invertida: " + invertida);
    }
}