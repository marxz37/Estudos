using System;
public class lista14
{
    public static void Main(string[] args)
    {
        //Declaração das Variaveis e Entrada do Usuário:
        Console.WriteLine("Vamos calcular seu peso ideial!");
        Console.WriteLine("Escreva sua Altura:");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva seu Sexo (M/F) :");
        char sexo = char.Parse(Console.ReadLine().ToLower());
        
        //Calculo:
        double resultado = (sexo == 'f') ? 62.1 * h - 44.7 : (sexo == 'm') ? 72.7 * h - 58 : 0;
        
        //Evitar com que Usuário o digite valor errado.
        Console.WriteLine(resultado == 0 ? "Escolha Invalida! Digite M ou F." : $"Resultado: {resultado:F2}");
    }
}   