using System;
class Exercicio08
{
    static double CalcularS(int n)
    {
        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += (double)(i * i + 1) / (i + 3);
        }
        return s;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o valor de n (inteiro e positivo): ");
        int n = int.Parse(Console.ReadLine());

        while (n <= 0)
        {
            Console.Write("Valor inválido! O número deve ser maior que zero. Digite novamente o valor de n: ");
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"S = {CalcularS(n):F4}");
    }
}