using System;

public class listatv3
{
    public static void Main(string[] args)
    {
        double preco = 0, quantidade = 0, maior = double.MinValue, menor = double.MaxValue, soma = 0, total = 0;
        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine($"Consumidor {i}!");
            Console.Write("Escreva o preço do kWh: ");
            preco = double.Parse(Console.ReadLine());
            while (preco < 0)
            {
                Console.Write("O preço não pode ser negativo! Digite novamente: ");
                preco = double.Parse(Console.ReadLine());
            }
            Console.Write("Quantidade de kWh consumido: ");
            quantidade = double.Parse(Console.ReadLine());
            while (quantidade < 0)
            {
                Console.Write("A quantidade não pode ser negativa! Digite novamente: ");
                quantidade = double.Parse(Console.ReadLine());
            }
            soma += quantidade;

            if (maior < quantidade)
            {
                maior = quantidade;
            }

            if (menor > quantidade)
            {
                menor = quantidade;
            }
            total = preco * quantidade; 
            Console.WriteLine($"Consumidor {i}! Total a pagar: {total:C}!");
        }
        double media = soma / 50;
        Console.WriteLine("\n--- RELATÓRIO FINAL ---");
        Console.WriteLine($"Maior Consumo de kWh: {maior}!");
        Console.WriteLine($"Menor Consumo de kWh: {menor}!");
        Console.WriteLine($"Média dos consumidores: {media:F2} kWh!");
    }
}