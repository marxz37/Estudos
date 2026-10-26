using System;

class Program
{
    static int CountCharacters(string word, char character, int count = 0, int i = 0)
    {
        if(i == word.Length) return count;

        if(word[i] == character) count++;
        
        return CountCharacters(word,character,count,i+1);
    }
    static void Main()
    {
        Console.WriteLine(CountCharacters("sdawddwasawdasasawd",'s'));
    }
}