using System;
namespace CSharp
{
    public class atividadequadradoperimetro
{  
    public static void Main2(string[] args)
        {
        //Explicação + Entrada do Usuário
        Console.WriteLine("Escreva a Altura:");
        int altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a Base:");
        int basequad = int.Parse(Console.ReadLine());

        //Declaração das variaveis + Calculo:
        double perimetro, area;

        area = altura * basequad;
        perimetro = area * 2;
        
        //Resultado!
        Console.WriteLine("Area: "+ area);
        Console.WriteLine("Perimetro: "+ perimetro);
        }
}
}