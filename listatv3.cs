using System;

public class listatv3
{
    public static void Main2(string[] args)
    {
        int i = 1;
        double maximaDia = 0;
        double soma = 0;
        int diaMax = 0;
        while (i <= 5)
        {
            Console.WriteLine("Escreva o mm do dia:");
            double mm = double.Parse(Console.ReadLine());
            if (mm >= 0)
            {
                i++;
                if (mm > maximaDia)
                {
                    maximaDia = mm;
                    diaMax = i;
                }
                soma = soma + mm;
            }
            else
            {
                Console.WriteLine("Escreva um número positivo, mm do dia ignorado!");
            }
        }
        soma = soma / i;
        Console.WriteLine($"Maximo mm do Dia: {maximaDia}mm | No dia: {diaMax}!");
        Console.WriteLine($"Média mm do Mês: {soma:F2}!");
    }
}