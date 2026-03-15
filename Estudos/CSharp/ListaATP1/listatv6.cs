using System;

namespace ListaATP1
{
    public class listatv6
{  
    public static void Main2(string[] args)
    {
        Console.WriteLine("Vamos calcular sua média ponderada das provas!");

        //Declaração das variaveis:
        double userNumber1, userNumber2, userNumber3, userNumber4 ,userSomaTotal;
        
        const int peso_1 = 2;
        const int peso_2 = 1;
        const int peso_3 = 3;
        const int peso_4 = 4;
        double pesoSomaTotal;
        double pesoResult;
        
        //Numeros dos usuarios e conversão deles:
        Console.WriteLine("Escreva a nota Prova 1:");
        userNumber1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Escreva a nota Prova 2:");
        userNumber2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Escreva a nota Prova 3:");
        userNumber3 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Escreva a nota Prova 4:");
        userNumber4 = double.Parse(Console.ReadLine());

        
        //Calculos:
        userNumber1 *= peso_1;
        userNumber2 *= peso_2;
        userNumber3 *= peso_3;
        userNumber4 *= peso_4;
        userSomaTotal = userNumber1 + userNumber2 + userNumber3 + userNumber4;
        
        //Calculos:
        pesoSomaTotal = peso_1 + peso_2 + peso_3 + peso_4;
        pesoResult = userSomaTotal / pesoSomaTotal;
        
        //Bloquear o usuario de digitar número negativo!
        if(userNumber1 < 0 || userNumber2 < 0 || userNumber3 < 0 || userNumber4 < 0)
        {
            Console.WriteLine("Coloque números positivos!");
        }
        else
        {
        //Resultados:
        Console.WriteLine($"Resultado das multiplicações da prova com o peso: {userSomaTotal}");
        Console.WriteLine($"Resultado das somas dos pesos: {pesoSomaTotal}");
        Console.WriteLine($"Resultado da média ponderada da prova: {pesoResult}");
        }

        string x = (Console.ReadLine()); 
    }
}
}