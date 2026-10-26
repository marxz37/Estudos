using System;

class Program
{
    static void MinMoedas(int[] moedas, int total)
    {
        int Min(int i, int total, int temp = 0)
        {
            if(total == 0) return 0;

            if(total / moedas[i] >= 1) temp = total/moedas[i];

            int totalMoedas = temp;

            if(moedas[i] == 25 && temp >= 1)
            {
                Console.WriteLine($"Total de moedas de 25: {temp}");
            }
            if(moedas[i] == 10 && temp >= 1)
            {
                Console.WriteLine($"Total de moedas de 10: {temp}");
            }
            if(moedas[i] == 5 && temp >= 1)
            {
                Console.WriteLine($"Total de moedas de 5: {temp}");
            }
            if(moedas[i] == 1 && temp >= 1)
            {
                Console.WriteLine($"Total de moedas de 1: {temp}");
            }
            
            return totalMoedas + Min(i-1, total-(temp*moedas[i]));
        }
        Console.WriteLine($"Total: {Min(moedas.Length-1, total)}");
        return;
    }
    static void Main()
    {
        int[] moedas = { 1, 5, 10, 25 };

        MinMoedas(moedas,111);
    }
}