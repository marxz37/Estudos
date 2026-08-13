using System;
class Exercicio03
{
    static int Mmc(int a, int b)
    {
        int produto = a * b;
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return produto / a;
    }

    static int Mdc(int a, int b, int c)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        while (c != 0)
        {
            int temp = c;
            c = a % c;
            a = temp;
        }
        return a;
    }

    static int LerNumeroPositivo(string mensagem)
    {
        int numero;
        do
        {
            Console.Write(mensagem);
            numero = int.Parse(Console.ReadLine());
            
            if (numero <= 0)
            {
                Console.WriteLine("Valor inválido! Digite um número inteiro maior que zero.");
            }
        } while (numero <= 0);
        
        return numero;
    }

    static void Main(string[] args)
    {
        int opcao = 0;
        while (opcao != 3)
        {
            Console.WriteLine("\n1) Calcular MMC");
            Console.WriteLine("2) Calcular MDC");
            Console.WriteLine("3) Sair do programa");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                int a = LerNumeroPositivo("Digite o 1º número: ");
                int b = LerNumeroPositivo("Digite o 2º número: ");
                
                Console.WriteLine($"MMC({a}, {b}) = {Mmc(a, b)}");
            }
            else if (opcao == 2)
            {
                int a = LerNumeroPositivo("Digite o 1º número: ");
                int b = LerNumeroPositivo("Digite o 2º número: ");
                int c = LerNumeroPositivo("Digite o 3º número: ");
                
                Console.WriteLine($"MDC({a}, {b}, {c}) = {Mdc(a, b, c)}");
            }
            else if (opcao != 3)
            {
                Console.WriteLine("Opção inválida!");
            }
        }
        Console.WriteLine("Encerrando o programa...");
    }
}