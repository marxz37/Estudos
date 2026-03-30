using System;

public class listatv6
{
    public static void Main2(string[] args)
    {
        int userNumber = 1;
        double salario;
        while (userNumber != 4)
        {
            Console.WriteLine("[1] Novo Usuário [2] Férias [3] Décimo Terceiro [4] Sair!");
            Console.WriteLine("Escolha uma das opções!");
            userNumber = int.Parse(Console.ReadLine());
            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("Escreva o seu salario:");
                    salario = double.Parse(Console.ReadLine());
                    while (salario <= 0)
                    {
                        Console.WriteLine("Tente digitar um número positivo!");
                        salario = double.Parse(Console.ReadLine());
                    }
                    if (salario > 0 && salario <= 999)
                    {
                        double bonus = salario * 0.15;
                        Console.WriteLine($"Seu salario: {salario:C}");
                        Console.WriteLine($"Seu com o bonus: {salario + bonus:C}");
                    }
                    else if (salario >= 1000 && salario <= 2000)
                    {
                        double bonus = salario * 0.10;
                        Console.WriteLine($"Seu salario: {salario:C}");
                        Console.WriteLine($"Seu com o bonus: {salario + bonus:C}");
                    }
                    else if (salario >= 2001)
                    {
                        double bonus = salario * 0.05;
                        Console.WriteLine($"Seu salario: {salario:C}");
                        Console.WriteLine($"Seu com o bonus: {salario + bonus:C}");
                    }
                    else
                    {
                        Console.WriteLine("Tente digitar um número positivo!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Escreva o seu salario:");
                    salario = double.Parse(Console.ReadLine());
                    while (salario <= 0)
                    {
                        Console.WriteLine("Tente digitar um número positivo!");
                        Console.WriteLine("Escreva o seu salario:");
                        salario = double.Parse(Console.ReadLine());
                    }
                    double feriaSalario = salario + (salario / 3);
                    Console.WriteLine($"Seu salario {salario:C} com as férias: {salario + feriaSalario:C}");
                    break;

                case 3:
                    Console.WriteLine("Escreva o seu salario:");
                    salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva ate 12 o número de meses trabalhados:");
                    double meses = double.Parse(Console.ReadLine());
                    if (meses <= 0 || salario <= 0 || meses > 12)
                    {
                        while (meses <= 0 || salario <= 0 || meses > 12)
                        {
                            Console.WriteLine("Escreva o salario/mês acima de 0!");
                            salario = double.Parse(Console.ReadLine());
                            Console.WriteLine("Escreva o numero do mes acima de 0!");
                            meses = double.Parse(Console.ReadLine());
                        }
                    }
                    double decimoTerceiro = (salario * meses) / 12;
                    Console.WriteLine($"Valor do Decimo Terceiro: {decimoTerceiro:C}.");
                    Console.WriteLine($"Valor do Salario + Decimo Terceiro: {salario + decimoTerceiro:C}.");
                    break;

                case 4:
                    return;
                    break;

                default:
                    Console.WriteLine("Escreva um número das opções!");
                    break;
            }
        }
    }
}