using System;

namespace ListaATP1
{
    public class listatv5
{  
    public static void Main2(string[] args)
    {
        //declaração das variaveis
        double celsius, fahrenheit;
        
        Console.WriteLine("Escreva a temperatura Fahrenheits:");
        
        //lendo o que o usuario digitou
        fahrenheit = double.Parse(Console.ReadLine());

        //calculo para conversão
        celsius = 5 * (fahrenheit - 32) / 9;

        //entrada
        Console.WriteLine($"Entrada do usuário: {fahrenheit}°");

        //resultado
        Console.WriteLine($"Graus Fahrenheit: {fahrenheit}°");
        Console.WriteLine($"Graus Celsius: {celsius:F3}°");

        string x = Console.ReadLine();
    }
}
}