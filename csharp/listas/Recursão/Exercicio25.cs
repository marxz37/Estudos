using System;

class Program
{
    static string StringInvertida(string text, int index = 0)
    {
        if (text == null)
            throw new ArgumentNullException(nameof(text));

        if (index < 0 || index > text.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index == text.Length)
            return "";

        return StringInvertida(text, index + 1) + text[index];
    }

    static void Main(string[] arg)
    {
        Console.WriteLine(StringInvertida("RECURSAO"));
    }
}
