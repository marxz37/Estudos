using System;

public class listatv4
{
    public static void Main(string[] args)
    {
        double temperatura = 0, maior = double.MinValue, menor = double.MaxValue, diaMax = 0, diaMin = 0;
        Console.WriteLine("Escreva à temperatura média registrada em Belo Horizonte em cada dia do mês de abril!");
        
        for(int i = 1; i <= 31; i++)
        {
            Console.WriteLine($"Dia {i}:");
            temperatura = double.Parse(Console.ReadLine());
            
            if(maior < temperatura)
            {
                maior = temperatura;
                diaMax = i;
            }
            
            if(menor > temperatura)
            {
                menor = temperatura;
                diaMin = i;
            }
        }
        Console.WriteLine($"A maior temperatura {maior} foi no dia: {diaMax}!");
        Console.WriteLine($"A menor temperatura {menor} foi no dia: {diaMin}!");
    }
}