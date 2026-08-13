using System;

namespace Atividade
{
    public class atividademediaprova
{  
    public static void Main2(string[] args)
    {
    float n1, n2, n3, n4, result;
        
    Console.WriteLine("Escreva as suas 4 notas da suas provas:");
    Console.WriteLine("Nota 1:");
    n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Nota 2:");
    n2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Nota 3:");
    n3 = float.Parse(Console.ReadLine());
    Console.WriteLine("Nota 4:");
    n4 = float.Parse(Console.ReadLine());
        
    result = (n1 + n2 + n3 + n4) / 4;
    Console.WriteLine("Média:"+ result);
    }
}
}