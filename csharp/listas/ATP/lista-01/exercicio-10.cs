using System;
namespace ListaATP1
{
    public class listatv10
    {
    public static void Main2(string[] args)
        {
        //Explicação!
        Console.WriteLine("Vamos fazer um calculo da despeza + gorjeta de um restaurante!");
        
        //Declaração das variaveis:
        double gorjeta, despeza, total, porcentual;
        
        //Entrada do Usuário:
        Console.WriteLine("Valor gasto com as despezas realizadas pelo restaurante:");
        despeza = double.Parse(Console.ReadLine());
        Console.WriteLine("Porcentual da Gorjeta do consumidor(escolha do consumidor):");
        gorjeta = double.Parse(Console.ReadLine());
        
        if(gorjeta <= 0 || despeza <= 0)
        {
            Console.WriteLine("Coloque apenas valores positivos!");
        }
        else
        {
        //Calculo:
        porcentual = (gorjeta / 100) * despeza;
        total = porcentual + despeza;
        
        //Resultado:
        Console.WriteLine($"Entrada do Usuário Despeza: {despeza}");
        Console.WriteLine($"Entrada do Usuário Porcentual da Gorjeta: {gorjeta}");
        Console.WriteLine($"Valor da Gorjeta: {porcentual}");
        Console.WriteLine($"Valor Total: {total}");

        string x = Console.ReadLine();
        }
        }
    }   
}