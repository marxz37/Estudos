using System;
namespace CSharp
{
    public class atividadeclima
{  
    public static void Main2(string[] args)
    {
        Console.WriteLine("O computador ira tentar adivinhar qual clima voce escolheu!");
        Console.WriteLine("Escolha o clima 'Sol' ou 'Chuva'.");
        
        string sol = "sol";
        string chuva = "chuva";
        string c;
        
        do
        {
            c = Console.ReadLine();
            c = c.ToLower();
            
            if(c != sol && c != chuva)
            {
                Console.WriteLine("Escreva apenas 'Sol' ou 'Chuva'!");
            }
            else
            {
                Console.WriteLine("Verificando a condicao climatica...");
            }
        }
        while(c != sol && c != chuva); 

        Console.WriteLine($"Seu chute: {c}");

        var rnd = new Random();
        int sorteio = rnd.Next(0,2);

        string chuteDaMaquina = "";

        if(sorteio == 0)
        {
            Console.WriteLine("Chute da maquina: Sol!");
            chuteDaMaquina = "sol";
        }
        else if(sorteio == 1)
        {
            Console.WriteLine("Chute da maquina: Chuva!");
            chuteDaMaquina = "chuva";
        }

        if(chuteDaMaquina != c)
        {
            Console.WriteLine("Você venceu!");
        }
        else
        {
            Console.WriteLine("A maquina venceu!");
        }
    }
    }
}