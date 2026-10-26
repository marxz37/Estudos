using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<char> pilha = new Stack<char>();

        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();

        foreach (char caractere in texto)
            pilha.Push(caractere);

        string textoInvertido = "";

        while (pilha.Count > 0)
            textoInvertido += pilha.Pop();

        Console.WriteLine("String invertida: " + textoInvertido);
    }
}
