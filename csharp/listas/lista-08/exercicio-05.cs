using System;

class Program
{
    static bool VerificarPalindromo(string texto)
    {
        if (texto == null)
        {
            return false;
        }

        string textoTratado = "";
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] != ' ')
            {
                textoTratado += char.ToLower(texto[i]);
            }
        }

        int tamanho = textoTratado.Length;
        for (int i = 0; i < tamanho / 2; i++)
        {
            if (textoTratado[i] != textoTratado[tamanho - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Digite uma frase para verificar se eh palindromo: ");
        string entrada = Console.ReadLine();
        
        bool resultado = VerificarPalindromo(entrada);
        Console.WriteLine("Eh palindromo? " + resultado);
    }
}