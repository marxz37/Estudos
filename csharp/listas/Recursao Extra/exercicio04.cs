using System;

class Program
{
    static bool EhPalindromo(string palavra)
    {
        string wordLowerCase = palavra.ToLower().Replace(" ","");
        int lastIndex = wordLowerCase.Length - 1;

        bool Palindromo(string word, int index, int lastIndex)
        {
            if(index >= lastIndex) return true;

            if(word[index] != word[lastIndex]) return false;

            return Palindromo(word, index+1, lastIndex-1);
        }

        return Palindromo(wordLowerCase, 0, lastIndex);
    }
    static void Main()
    {
        Console.WriteLine(EhPalindromo("A mala nada na lama"));
    }
}