using System;

class listatv1
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 25; i++)
        {
            Console.WriteLine($"\n--- Pedreiro: {i} ---");
            Console.Write("Valor do vale-alimentação (almoço): ");
            double valeAlimentacao = double.Parse(Console.ReadLine());
            while (valeAlimentacao < 0)
            {
                Console.Write("Valor inválido! Digite um valor maior ou igual a zero: ");
                valeAlimentacao = double.Parse(Console.ReadLine());
            }
            Console.Write("Valor de um vale-transporte: ");
            double valeTransporte = double.Parse(Console.ReadLine());
            while (valeTransporte < 0)
            {
                Console.Write("Valor inválido! Digite um valor maior ou igual a zero: ");
                valeTransporte = double.Parse(Console.ReadLine());
            }
            Console.Write("Quantos metros quadrados (m²) foram produzidos: ");
            double produzido = double.Parse(Console.ReadLine());
            while (produzido < 0)
            {
                Console.Write("A produção não pode ser negativa! Digite novamente: ");
                produzido = double.Parse(Console.ReadLine());
            }
            double valorMetro;
            if (produzido < 10)
            {
                valorMetro = 10.00;
            }
            else if (produzido <= 20)
            {
                valorMetro = 11.50;
            }
            else
            {
                valorMetro = 13.00;
            }
            double pagamentoTotal = (produzido * valorMetro) + valeAlimentacao + (valeTransporte * 2);
            Console.WriteLine($"O pedreiro {i} deve receber hoje: {pagamentoTotal:C}");
        }
        Console.WriteLine("\nProcessamento de todos os pedreiros concluído.");
    }
}