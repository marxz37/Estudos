using System;
class lista3
{
    static void Main2(string[] arg)
    {
        //Entrada do Usuário:
        Console.WriteLine("Quanto anos?");
        int idade = int.Parse(Console.ReadLine());

        //Condições:
        if(idade >= 21)
        {
            //Entrada do Usuário:
            Console.WriteLine("Qual tipo de habilitação? Ex: A, B, C");
            char habilitacao = char.Parse(Console.ReadLine().ToLower());

            if(habilitacao == 'b')
            {
                //Entrada do Usuário:
                Console.WriteLine("Quanto tempo de carteira?");
                int tempo = int.Parse(Console.ReadLine());

                //Condições:
                if(tempo >= 2)
                {
                    Console.WriteLine("Você pode tirar a carteira da categoria D!");
                }
                else
                {
                    Console.WriteLine("Falta completar 2 anos de carteira!");
                }
            }
            else if(habilitacao == 'c')
            {
                //Entrada do Usuário:
                Console.WriteLine("Quantos anos você tem na categoria C?");
                int tempoC = int.Parse(Console.ReadLine());

                //Condições:
                if(tempoC >= 1)
                {
                    Console.WriteLine("Você pode tirar a carteira da categoria D!");
                }
                else
                {
                    Console.WriteLine("Você não pode tirar a carteira da categoria D, precisa ter 1 ano de carteina na categoria C!");
                }
            }
            else if(habilitacao == 'a')
            {
                Console.WriteLine("Você não tem a carteira da categoria B!");
            }
            else
            {
                Console.WriteLine("Escreva uma das opções!");
            }
        }
        //Caso a pessoa escrever errado ou não ter idadde o suficiente!
        else
        {
            Console.WriteLine("Você não tem idade o suficiente / Escreva apenas números!");
        }
    }
}