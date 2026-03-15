using System;
namespace csharp
{
public class atividadeipstest
    {
    public static void Main2(string[] arg)
        {
            Console.WriteLine("Quantos IPs suspeitos foram identificados?");
            
            int x;
            bool sucesso;

            do
            {
            sucesso = int.TryParse(Console.ReadLine(), out x);
            if(!sucesso || x <= 0)
            {
                Console.WriteLine("Entrada inválida. Digite um número e que seja maior que zero.");
            }
            else
            {
                Console.WriteLine($"Quantidade de IPs: {x}");
            }
            } 
            while(!sucesso || x <= 0);
    
            Console.WriteLine("Escreva os IPs neste formato xxx.xxx.xxx.xxx!:");
            
            string[] ips = new string[x];

            for(int z = 0; z < x; z++)
            {
                Console.WriteLine($"Digite o IP {z + 1}: ");
                ips[z] = Console.ReadLine(); 
                Console.WriteLine($"IP {ips[z]} Foi registrado na base de dados!\n");
            }
            for(int z = 0; z < x; z++)
            {
                Console.WriteLine("IPs Registrados: "+ ips[z]);
            }
        }
    }
}