using System;
public class atividadeviagem
{
    public static void Main3(string[] arg)
    {
        //Declaração da variavel!
        double valorGasto = 0;

        //Entrada do Usuário:
        Console.WriteLine("Escolha um destes destinos: Norte, Nordeste, Sudeste, Sul");
        string escolha = Console.ReadLine().ToLower();

        //Condições:
        if(escolha == "norte" || escolha == "nordeste" || escolha == "sudeste"|| escolha == "sul")
        {
            if(escolha == "norte")
            {
                valorGasto += 500;
            }
            else if(escolha == "nordeste")
            {
                valorGasto += 350;
            }
            else if(escolha == "sudeste")
            {
                valorGasto += 350;
            }
            else if(escolha == "sul")
            {
                valorGasto += 300;
            }

            //Entrada do Usuário:
            Console.WriteLine("Inclui a volta? S ou N.");
            string volta = Console.ReadLine().ToLower();

            //Condições:
            if(volta == "s" && escolha == "norte")
            {
                valorGasto += 400;
            }
            else if(volta == "s" && escolha == "nordeste")
            {
                valorGasto += 300;
            }
            else if(volta == "s" && escolha == "sudeste")
            {
                valorGasto += 250;
            }
            else if(volta == "s" && escolha == "sul")
            {
                valorGasto += 250;
            }
            else if(volta != "n")
            {
                Console.WriteLine("Escolha um destes S ou N!");
                return;
            }

            //Resultado:
            Console.WriteLine("Valor Total a Pagar: {0:C}", valorGasto);
        }
        else
        {
            Console.WriteLine("Escolha um destes destinos: Norte, Nordeste, Sudeste, Sul!");
            return;
        }
    }
}