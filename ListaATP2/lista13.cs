using System;

public class lista13
{
    public static void Main(string[] args)
    {
        //Declaração das Variaveis e Entrada do Usuário:
        Console.WriteLine("Vamos adivinhar se é uma vogal!");
        Console.WriteLine("Escreva uma letra:");
        char letra = char.Parse(Console.ReadLine().ToLower());

        //Condições:
        switch(letra)
        {
            case 'a':
            Console.WriteLine("É uma Vogal!");
            break;
            
            case 'e':
            Console.WriteLine("É uma Vogal!");
            break;
            
            case 'i':
            Console.WriteLine("É uma Vogal!");
            break;
            
            case 'o':
            Console.WriteLine("É uma Vogal!");
            break;
            
            case 'u':
            Console.WriteLine("É uma Vogal!");
            break;
            
            //Evitar com que Usuário o digite valor errado.
            default:
            Console.WriteLine("Não é uma Vogal!");
            break;
        }
    }
}