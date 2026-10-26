using System;
class Exercicio04
{
    static void CalcularMedia(int n1, int n2, int n3, char tipo)
    {
        if (tipo == 'A')
        {
            double media = (n1 + n2 + n3) / 3.0;
            Console.WriteLine("Média Aritmética: " + media);
        }
        else if (tipo == 'P')
        {
            double media = (n1 * 5.0 + n2 * 3.0 + n3 * 2.0) / 10.0;
            Console.WriteLine("Média Ponderada: " + media);
        }
        else
        {
            Console.WriteLine("Não é possível fazer nenhum cálculo.");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o 1º número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o 2º número: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o 3º número: ");
        int n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite A (aritmética) ou P (ponderada): ");
        char tipo = char.ToUpper(Console.ReadLine()[0]);

        CalcularMedia(n1, n2, n3, tipo);
    }
}