using System;

public class listatv7
{
    public static void Main()
    {
        char continuar;
        do
        {
            Console.Clear();
            Console.Write("Digite o salário bruto do funcionário (Ex: 3000.00): R$ ");
            
            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                while (salario < 0)
                {
                    Console.Write("O salário não pode ser negativo! Digite novamente: R$ ");
                    double.TryParse(Console.ReadLine(), out salario);
                }

                double inss = 0;
                double maxFaixa1 = 105.90;
                double maxFaixa2 = 112.92;
                double maxFaixa3 = 160.00;
                double maxFaixa4 = 530.04;

                if (salario <= 1412.00)
                {
                    inss = salario * 0.075;
                }
                else if (salario <= 2666.68)
                {
                    inss = maxFaixa1 + ((salario - 1412.00) * 0.09);
                }
                else if (salario <= 4000.03)
                {
                    inss = maxFaixa1 + maxFaixa2 + ((salario - 2666.68) * 0.12);
                }
                else if (salario <= 7786.02)
                {
                    inss = maxFaixa1 + maxFaixa2 + maxFaixa3 + ((salario - 4000.03) * 0.14);
                }
                else
                {
                    inss = maxFaixa1 + maxFaixa2 + maxFaixa3 + maxFaixa4;
                }

                inss = Math.Round(inss, 2);

                Console.WriteLine($"\nValor total do desconto do INSS: R$ {inss:F2}");
            }
            else
            {
                Console.WriteLine("\nValor inválido. Certifique-se de digitar números válidos.");
            }

            Console.WriteLine("Deseja informar um novo salário? (S: sim, N: não): ");
            continuar = char.Parse(Console.ReadLine().ToLower());

        } while (continuar == 's');
    }
}