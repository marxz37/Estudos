using System;

public class atividademaioroumenor
{
    public static void Main2(string[] args)
    {
        //Declaração das variaveis
        int num1, num2;
        
        //Entrada do Usuário
        Console.WriteLine ("Escreva o número 1:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Escreva o número 2:");
        num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Entrada do Usuário 1:");
        Console.WriteLine ("Entrada do Usuário 2:");
        
        //Condições | Resultado:
        if(num1 == num2)
        {
            Console.WriteLine ("O número {0} é igual ao número {1}!", num1, num2);
        }
        else if(num1 > num2)
        {
            Console.WriteLine ("O número {0} é maior que o {1}!", num1, num2);
        }
        else
        {
            Console.WriteLine ("O número {1} é maior que o {0}!", num1, num2);
        }
    }
}