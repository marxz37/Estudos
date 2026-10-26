using System;

class Program
{
    static bool Palindromo(string text)
    {
        if (string.IsNullOrEmpty(text))
            return false;

        string texto = text.ToLowerInvariant();
        int tam = texto.Length - 1;
        int index = 0;
        bool check = Verificacao(texto, index, tam);

        bool Verificacao(string textoVerificado, int indiceAtual, int indiceFinal)
        {
            if (indiceAtual >= indiceFinal)
                return true;

            if (textoVerificado[indiceAtual] != textoVerificado[indiceFinal])
                return false;

            return Verificacao(textoVerificado, indiceAtual + 1, indiceFinal - 1);
        }

        return check;
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(Palindromo("RADAR"));
    }
}
