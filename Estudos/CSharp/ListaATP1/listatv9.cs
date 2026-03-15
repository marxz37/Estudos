using System;
namespace ListaATP1
{
    public class listatv9
    {  
    public static void Main2(string[] args)
        {
        //Explicação
        Console.WriteLine("Vamos fazer um calculo de fração!");
        
        //Declaração das variaveis!
        double num1, num2;
        
        //Entrada do Usuário
        Console.WriteLine("Escreva o numerador:");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o denominador:");
        num2 = double.Parse(Console.ReadLine());
        
        //Bloqueando o Usuário digitar 0 no denominador!
        if(num2 == 0)
        {
            Console.WriteLine("Escreva algum número que não seja 0 no denominador!");
        }
        else
        {
        //Mostrando a Entrada do Usuário
        Console.WriteLine($"Entrada do usuário no numerador: "+ num1);
        Console.WriteLine($"Entrada do usuário no denominador: "+ num2);
        
        //Calculo:
        double total = num1 / num2;
        
        //Resultado:
        Console.WriteLine($"Resultado: {total:N2}");

        string x = Console.ReadLine();
        }
        }
    }
}