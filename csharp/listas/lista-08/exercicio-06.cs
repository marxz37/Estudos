using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        string criptografada = "";

        for (int i = 0; i < frase.Length; i++)
        {
            char c = char.ToLower(frase[i]);
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                criptografada += '*';
            }
            else
            {
                criptografada += frase[i];
            }
        }

        Console.WriteLine("Frase criptografada: " + criptografada);
    }
}