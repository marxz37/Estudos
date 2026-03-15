using System;

namespace CSharp
{
    public class atividademediaif
{
    public static void Main2(string[] args)
        {
        float nota1, nota2, nota3, nota4, notaTotal, freq;
        Console.WriteLine ("Digite a nota das suas 4 provas!");
        
        Console.WriteLine ("Nota 1:");
        nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine ("Nota 2:");
        nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine ("Nota 3:");
        nota3 = float.Parse(Console.ReadLine());
        Console.WriteLine ("Nota 4:");
        nota4 = float.Parse(Console.ReadLine());
        
        notaTotal = nota1 + nota2 + nota3 + nota4;
        
        Console.WriteLine ("Frequencia:");
        freq = int.Parse(Console.ReadLine());
        
        if(notaTotal >= 60 && freq >= 75)
        {
            Console.WriteLine ("Aprovado!");
        }
        else
        {
            Console.WriteLine ("Reprovado!");
        }
        }
    }
}