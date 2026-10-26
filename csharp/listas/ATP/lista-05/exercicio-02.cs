using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        double[] temperatura = new double[31];
        for(int i = 0; i < temperatura.Length; i++)
        {
            Console.WriteLine($"Escreva a temperatura do dia: {i+1}");
            temperatura[i] = double.Parse(Console.ReadLine());
        }
        
        double temp_desejado = 0; 
        char escolha = 's';
        
        do
        {
            Console.WriteLine($"Qual temperatura você deseja procurar:");
            temp_desejado = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Essa temperatura ocorreu nos dias: ");
            bool achar = false;
            
            for(int i = 0; i < temperatura.Length; i++)
            {
                if(temp_desejado == temperatura[i])
                {
                    Console.Write($"'{i+1}' ");
                    achar = true;
                }
            }
            
            if(achar == false)
            {
                Console.Write("Temperatura não encontrada!");
            }
            Console.WriteLine("Deseja continuar? (S/N)");
            escolha = char.Parse(Console.ReadLine().ToLower());
        }
        while(escolha == 's');
    }
}