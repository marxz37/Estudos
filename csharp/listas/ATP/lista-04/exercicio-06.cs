using System;

public class listatv6
{
    public static void Main(string[] args)
    {
        double temperatura = 0;
        int opcao = 0;
        do
        {
            Console.WriteLine("1. Converter de Celsius para Fahrenheit");
            Console.WriteLine("2. Converter de Celsius para Kelvin");
            Console.WriteLine("3. Converter de Fahrenheit para Celsius");
            Console.WriteLine("4. Converter de Fahrenheit para Kelvin");
            Console.WriteLine("5. Converter de Kelvin para Celsius");
            Console.WriteLine("6. Converter de Kelvin para Fahrenheit");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                Console.WriteLine("Escreva a Quantidade de Celsius: ");
                temperatura = double.Parse(Console.ReadLine());
                temperatura = temperatura * 1.8 + 32;
                Console.WriteLine($"Convertido em Fahrenheit: {temperatura}°.");
                break;

                case 2:
                Console.WriteLine("Escreva a Quantidade de Celsius: ");
                temperatura = double.Parse(Console.ReadLine());
                temperatura = temperatura + 273.15;
                Console.WriteLine($"Convertido em Kelvin: {temperatura}v.");
                break;

                case 3:
                Console.WriteLine("Escreva a Quantidade de Fahrenheit: ");
                temperatura = double.Parse(Console.ReadLine());
                temperatura = (temperatura - 32) / 1.8;
                Console.WriteLine($"Convertido em Celsius: {temperatura}°.");
                break;

                case 4:
                Console.WriteLine("Escreva a Quantidade de Fahrenheit: ");
                temperatura = double.Parse(Console.ReadLine());
                temperatura = ((temperatura - 32) * 5 / 9) + 273.15;
                Console.WriteLine($"Convertido em Kelvin: {temperatura}°.");
                break;

                case 5:
                Console.WriteLine("Escreva a Quantidade de Kelvin: ");
                temperatura = double.Parse(Console.ReadLine());
                temperatura = temperatura - 273.15;
                Console.WriteLine($"Convertido em Celsius: {temperatura}°.");
                break;

                case 6:
                Console.WriteLine("Escreva a Quantidade de Kelvin: ");
                temperatura = double.Parse(Console.ReadLine());
                temperatura = ((temperatura - 273.15) * 1.8) + 32;
                Console.WriteLine($"Convertido em Fahrenheit: {temperatura}°.");
                break;

                case 7:
                break;

                default:
                Console.WriteLine($"Escolha uma das opções!");
                break;
            }
        }
        while(opcao != 7);
    }
}