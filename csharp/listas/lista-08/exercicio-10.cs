using System;

class Program
{
    static void Main()
    {
        string fraseA = "";
        while (fraseA.Length < 50)
        {
            Console.Write("Digite uma frase com pelo menos 50 caracteres: ");
            fraseA = Console.ReadLine();
            if (fraseA == null)
            {
                fraseA = "";
            }
        }

        string stringB = "";
        while (stringB.Length != 2)
        {
            Console.Write("Digite uma string com exatamente 2 caracteres: ");
            stringB = Console.ReadLine();
            if (stringB == null)
            {
                stringB = "";
            }
        }

        int contador = 0;
        
        for (int i = 0; i <= fraseA.Length - 2; i++)
        {
            if (fraseA[i] == stringB[0] && fraseA[i + 1] == stringB[1])
            {
                contador++;
            }
        }

        Console.WriteLine("A string '" + stringB + "' aparece " + contador + " vezes na frase.");
    }
}