using System;
namespace ListaATP1
{
    public class listatv12
    {  
    public static void Main2(string[] args)
        {
        //Explicação!
        Console.WriteLine("Escreva quantos 'Kilowatt' utiliza em sua Casa/Residencia");
        
        //Declaração das Variaveis e Calculo:
        const int salarioMin = 1516;
        float umDecimo = (float)salarioMin / 10;
        float umKilowatt = umDecimo / 100;
        
        //Entrada do Usuário:
        float qntKilowatt = float.Parse(Console.ReadLine());
        
        //Bloquear números negativos!
        if(qntKilowatt <= 0)
        {
            Console.WriteLine("Escreva apenas números positivos e acima de zero!");
        }
        else
        {
        //Calculo:
        float totalPagar = qntKilowatt * umKilowatt;
        
        //Resultado:
        Console.WriteLine("Entrada do Usuário em quantidade de Kilowatt: "+ qntKilowatt);
        Console.WriteLine($"Valor de 100 kilowatt: {umDecimo:C}");
        Console.WriteLine($"Valor de 1 Kilowatt: {umKilowatt:C}");
        Console.WriteLine($"Valor total a pagar: {totalPagar:C}");
        }

        string x = Console.ReadLine();
        }
    }
}