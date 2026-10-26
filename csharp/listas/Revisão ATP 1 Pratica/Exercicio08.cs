using System;
class Program
{
    static void AumentarSalario(ref decimal salario, decimal porcentualAumento)
    {
        salario += salario * (porcentualAumento / 100m);
    }
    static void Main(string[] arg)
    {
        decimal salario;

        Console.Write($"Escreva o seu salário: ");
        while (!decimal.TryParse(Console.ReadLine(), out salario) || salario <= 0)
        {
            Console.Write($"Valor invalido, tente apenas digitar números e maior que zero: ");
        }

        decimal porcentualAumento;

        Console.Write($"Escreva a porcentagem de aumento: ");
        while (!decimal.TryParse(Console.ReadLine(), out porcentualAumento) || porcentualAumento <= 0)
        {
            Console.Write($"Valor invalido, tente apenas digitar números e maior que zero: ");
        }

        Console.WriteLine($"Salario inicial: R${salario:F2}");

        AumentarSalario(ref salario, porcentualAumento);

        Console.WriteLine($"Salario com o aumento: R${salario:F2}");
    }
}   