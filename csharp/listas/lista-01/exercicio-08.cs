using System;
namespace ListaATP1
{
    public class listatv8
    { 
        public static void Main2(string[] args)
        {
        //Explicação!
        Console.WriteLine("Vamos inverter as variáveis!");
        
        //Entrada do Usuário:
        Console.WriteLine("Escreva o número 1:");
        long a = long.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o número 2:");
        long b = long.Parse(Console.ReadLine());
        
        //Entrada do Usuário:
        Console.WriteLine("Entrada do usuário 1: {0}", a);
        Console.WriteLine("Entrada do usuário 2: {0}", b);
        
        //Declaração das variaveis
        //Exemplo: a = 300 b = 6000;
        a = a/*300*/ + b/*6000*/;
        b = a/*6300*/ - b/*6000*/;
        a = a/*6300*/ - b/*300*/;
        
        //Resultado:
        Console.WriteLine("Numero 1 = {0} Numero 2 = {1}", a, b);

        string x = Console.ReadLine();
        }
    }
}