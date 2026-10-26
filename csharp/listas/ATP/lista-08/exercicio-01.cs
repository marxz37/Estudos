using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();
        Console.Write("Digite um caractere: ");
        string caractereStr = Console.ReadLine();

        if (caractereStr.Length > 0)
        {
            char caractere = caractereStr[0];
            int contador = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == caractere)
                {
                    contador++;
                }
            }

            Console.WriteLine("O caractere '" + caractere + "' aparece " + contador + " vezes na string.");
        }
    }
}