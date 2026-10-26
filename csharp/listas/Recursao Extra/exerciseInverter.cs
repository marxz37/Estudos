using System;
class Program
{
    static string Invert(string word)
    {
        if(word.Length <= 1) return word;

        string Inv(int lastIndex)
        {
            if(lastIndex==-1) return "";
            return word[lastIndex] + Inv(lastIndex-1);
        }
        return Inv(word.Length-1);
    }
    static void Main()
    {
        Console.WriteLine(Invert("test 123 lll"));
    }
}