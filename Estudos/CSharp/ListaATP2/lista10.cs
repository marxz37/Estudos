using System;
public class lista10
{
    public static void Main(string[] args)
    {
        //Declaração das Variaveis e Entrada do Usuário:
        Console.WriteLine("Escolha um dia da semana!");
        Console.WriteLine("Escolha um número de 1 a 7:");
        int num = int.Parse(Console.ReadLine());
        
        //Condições:
        switch(num)
        {
            case 1:
            Console.WriteLine("Domingo!");
            break;
            
            case 2:
            Console.WriteLine("Segunda-Feira!");
            break;
            
            case 3:
            Console.WriteLine("Terça-Feira!");
            break;
            
            case 4:
            Console.WriteLine("Quarta-Feira!");
            break;
            
            case 5:
            Console.WriteLine("Quinta-Feira!");
            break;
            
            case 6:
            Console.WriteLine("Sexta-Feira!");
            break;
            
            case 7:
            Console.WriteLine("Sabado!");
            break;
            
            //Evitar com que Usuário o digite valor errado.
            default:
            Console.WriteLine("Dia Invalido!");
            break;
        }
    }
}