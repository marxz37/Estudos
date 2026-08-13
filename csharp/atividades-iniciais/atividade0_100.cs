using System;

namespace CSharp
{
    public class atividade0_100
{
    public static void Main2(string[] args)
    {
        int count0_25 = 0;
        int count26_50 = 0;
        int count51_75 = 0;
        int count76_100 = 0;
        
        Console.WriteLine("Escreva 10 números de 0 a 100:");

        int i = 0;

        while(i < 10)
        {
            for(i = 0; i < 10; i++)
            {
            int z = int.Parse(Console.ReadLine());
            
            if(z <= 25)
            {
                count0_25++;
            }
            else if(z == 26 || z <= 50)
            {
                count26_50++;
            }
            else if(z == 51 || z <= 75)
            {
                count51_75++;
            }
            else if(z == 76 || z <= 100)
            {
                count76_100++;
            }
            else
            {
            Console.WriteLine("Numero ignorado, digite de 0 a 100!");
            }
            }
        }
        
        Console.WriteLine($"Numeros Informados 0-25: {count0_25}");
        Console.WriteLine($"Numeros Informados 26-50: {count26_50}");
        Console.WriteLine($"Numeros Informados 51-75: {count51_75}");
        Console.WriteLine($"Numeros Informados 76-100: {count76_100}");
    }
}
}