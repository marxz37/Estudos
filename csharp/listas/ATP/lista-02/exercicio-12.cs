using System;

public class lista12
{
    public static void Main(string[] args)
    {
        //Declaração das Variaveis e Entrada do Usuário:
        Console.WriteLine("Escreva um número para ser convertido:");
        double unidade = double.Parse(Console.ReadLine());
        Console.WriteLine("-------------------[ Conversor ]----------------------");
        Console.WriteLine("Escreva um número para converter!");
        Console.WriteLine("[1] Converter de centímetros para metros [2] Converter de metros para centímetros [3] Converter de milímetros para metros [4] Converter de metros para milímetros.");
        int userChoice = int.Parse(Console.ReadLine());
        
        //Condições:
        switch(userChoice)
        {
            case 1 when unidade >= 0:
            unidade = unidade / 100;
            Console.WriteLine($"Convertido de Centímetros para Metros: {unidade} m");
            break;
            
            case 2 when unidade >= 0:
            unidade = unidade * 100;
            Console.WriteLine($"Convertido de Metros para Centímetros: {unidade} cm");
            break;
            
            case 3 when unidade >= 0:
            unidade = unidade / 1000;
            Console.WriteLine($"Convertido de Milímetros para Metros: {unidade} m");
            break;
            
            case 4 when unidade >= 0:
            unidade = unidade * 1000;
            Console.WriteLine($"Convertido de Metros para Milímetros: {unidade} mm");
            break;
            
            //Evitar com que Usuário o digite valor errado.
            default:
            Console.WriteLine("Opção Inválida ou Digite um valor positivo!");
            break;
        }
    }
}