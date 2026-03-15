using System;
namespace CSharp
{
    public class atividademetroscentimetros
{  
    public static void Main2(string[] args)
        {
        double metros, centimetros;
        
        Console.WriteLine("Quantos metros:");
        metros = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade de Metros {0}m:", metros);
        centimetros = metros * 100;     
        Console.WriteLine("Convertido para Centimentros: {0}cm", centimetros);
        }
}
}