using System;

public class lista11
{
    public static void Main(string[] args)
    {
        //Declaração das Variaveis e Entrada do Usuário:
        Console.WriteLine("Escolha um número de 0 a 4:");
        int num = int.Parse(Console.ReadLine());
        
        //Condições:
        switch(num)
        {
            case 0:
            Console.WriteLine("Zero!");
            break;
            
            case 1:
            Console.WriteLine("Um!");
            break;
            
            case 2:
            Console.WriteLine("Dois!");
            break;
            
            case 3:
            Console.WriteLine("Três!");
            break;
            
            case 4:
            Console.WriteLine("Quatro!");
            break;
            
            //Evitar com que Usuário o digite valor errado.
            default:
            Console.WriteLine("Valor Invalido!");
            break;
        }
    }
}