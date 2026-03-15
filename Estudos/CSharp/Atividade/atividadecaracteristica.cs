using System;
public class atividadecaracteristica
{
    public static void Main2(string[] arg)
    {
        //Explicação!
        Console.WriteLine("Repare a seguinte característica do número 3025: 30 + 25 = 55 e 552 = 3025.");
        Console.WriteLine("Vamos criar um programa que reconheça essa característica!");
        
        //Declaração das variaveis!
        double num, result;

        //Entrada do Usuário:
        Console.WriteLine("Escreva um número com 4 digitos:");
        num = double.Parse(Console.ReadLine());

        //Calculos:
        int restoUltimosDig = (int)num % 100;
        int restoPrimeirosDig = (int)num / 100;
        result = (double)Math.Pow((restoUltimosDig + restoPrimeirosDig),2);

        //Resultado:
        Console.WriteLine($"Separação dos Primeiros Números: {restoPrimeirosDig}");
        Console.WriteLine($"Separação dos Últimos Números: {restoUltimosDig}");
        Console.WriteLine($"Resultado: {result}");

        //Verificação da característica!
        if(num == result)
        { 
            Console.WriteLine("Apresenta a mesma característica!");
        }
        else
        {
            Console.WriteLine("Não apresenta a mesma característica!");
        }
    }
}