using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira string: ");
        string string1 = Console.ReadLine();
        Console.Write("Digite a segunda string: ");
        string string2 = Console.ReadLine();

        if (string1 == string2)
        {
            Console.WriteLine("strings iguais");
        }
        else
        {
            if (string1.Length > string2.Length)
            {
                Console.WriteLine("Maior string: " + string1);
            }
            else if (string2.Length > string1.Length)
            {
                Console.WriteLine("Maior string: " + string2);
            }

            Console.WriteLine("Concatenacao: " + string1 + string2);
        }
    }
}