using System;

namespace ListaATP2
{
    public class lista8
    {
        public static void Main(string[] arg)
        {
            //Declaração das Variaveis e Entrada do Usuário:
            Console.WriteLine("Escreva a quantidade de litros no edificio que foi consumido:");
            double taxaAgua = 305.55, taxaEsgoto = 226.05, valor = 0;
            double userLitros = double.Parse(Console.ReadLine());
            double litros = userLitros / 1000;

            //Calculo:
            valor = taxaAgua + taxaEsgoto;

            //Condições:
            if (litros > 0)
            {
                Console.WriteLine($"Litros do Usuario: {userLitros}");
                Console.WriteLine($"Litros no Total: {litros}");
                if (litros >= 0 && litros <= 75)
                {
                    valor = valor + (litros * 2.11) + (litros * 1.56);
                    Console.WriteLine($"Valor Total: {valor:C}");
                }
                else if (litros >= 75 && litros <= 150)
                {
                    valor = valor + (75 * 2.11) + (75 * 1.56);
                    litros = litros - 75;
                    valor = valor + (litros * 4.496) + (litros * 3.327);
                    Console.WriteLine($"Valor Total: {valor:C}");
                }
                else if (litros >= 150 && litros <= 225)
                {
                    valor = valor + (75 * 2.11) + (75 * 1.56);
                    valor = valor + (75 * 4.496) + (75 * 3.327);
                    litros = litros - 150;
                    valor = valor + (litros * 6.968) + (litros * 5.156);
                    Console.WriteLine($"Valor Total: {valor:C}");
                }
                else if (litros > 225)
                {
                    valor = valor + (75 * 2.11) + (75 * 1.56);
                    valor = valor + (75 * 4.496) + (75 * 3.327);
                    valor = valor + (75 * 6.968) + (75 * 5.156);
                    litros = litros - 150;
                    valor = valor + (litros * 9.512) + (litros * 7.039);
                    Console.WriteLine($"Valor Total: {valor:C}");
                }
            }
            else
            //Caso o Usuário escrever errado!
            {
                Console.WriteLine("Escreva um número positivo!:");
            }
            
        }
    }
}