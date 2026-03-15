using System;

namespace ListaATP1
{
    public class listatv6_
{  
    public static void Main2(string[] args)
        {
            //declaração do usuário:
            int brancos, nulos, validos;
            Console.WriteLine("Vamos calcular quantidade de eleitores de um município, com o número de votos!");

            //entradas:
            Console.WriteLine("Votos brancos:");
            brancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Votos nulos:");
            nulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Votos validos:");
            validos = int.Parse(Console.ReadLine());

            //declaração do usuário:
            double somaTotal, porcentagemBrancos, porcentagemNulos, porcentagemValidos;

            //calculos
            somaTotal = brancos + nulos + validos;

            porcentagemBrancos = (brancos / somaTotal) * 100;
            porcentagemNulos = (nulos / somaTotal) * 100;
            porcentagemValidos = (validos / somaTotal) * 100;

            //bloquear números negativos
            if(brancos < 0 || nulos < 0 || validos < 0)
            {
                Console.WriteLine("Coloque números positivos!");
            }
            else if(somaTotal == 0)
            {
                Console.WriteLine("Não tem eleitores!");
            }
            else
            {
                //entradas do usuário:
                Console.WriteLine($"Entrdada do Usuário Votos Brancos: {brancos}");
                Console.WriteLine($"Entrdada do Usuário Votos Nulos: {nulos}");
                Console.WriteLine($"Entrdada do Usuário Votos Validos: {validos}");
                
                //resultados:
                Console.WriteLine($"Quantidade de Eleitores: {somaTotal}");
                Console.WriteLine($"Porcentagem brancos: {porcentagemBrancos:F3}%");
                Console.WriteLine($"Porcentagem nulos: {porcentagemNulos:F3}%");
                Console.WriteLine($"Porcentagem validos: {porcentagemValidos:F3}%");
            }

            string x = (Console.ReadLine());
        }
}
}