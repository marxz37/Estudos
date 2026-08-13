using System;
class Exercicio01
{
    static int MenorValor(int a, int b, int c, int d)
    {
        int menor = a;
        if (b < menor) menor = b;
        if (c < menor) menor = c;
        if (d < menor) menor = d;
        return menor;
    }
 
    static void Main(string[] args)
    {
        Console.Write("Digite o 1º número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o 2º número: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o 3º número: ");
        int n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite o 4º número: ");
        int n4 = int.Parse(Console.ReadLine());
 
        Console.WriteLine("Menor valor: " + MenorValor(n1, n2, n3, n4));
    }
}
 