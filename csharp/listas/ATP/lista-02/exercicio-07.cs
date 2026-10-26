using System;
class lista7
{
    static void Main(string[] arg)
    {
        //Declaração das Variaveis:
        double distancia, peso, preco, frete;
        double pkm = 1;

        //Entrada do Usuário:
        Console.WriteLine("Digite quantos km:");
        distancia = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantos kg:");
        peso = double.Parse(Console.ReadLine());

        //Condições:
        if(distancia <= 0)
        {
            Console.WriteLine("Escreva um número positivo!");
            return;
        }
        else if(peso <= 0)
        {
            Console.WriteLine("Escreva um número positivo!");
            return;
        }

        if(distancia <= 5 && peso <= 20)
        {
            Console.WriteLine("Urgencia Sim ou Não?");
            string urgencia = Console.ReadLine().ToLower();
            if(urgencia == "sim")
            {
                double total = pkm * distancia;
                frete = (total * 30) / 100;
                double seguro = (total * 20) / 100;
                preco = frete + distancia + seguro;
                Console.WriteLine("Valor total com urgência Moto: {0:C}", preco);
                frete = ((pkm * distancia) * 70) / 100;
                preco = frete + distancia;
                Console.WriteLine("Valor total com urgência Van: {0:C}", preco);
                frete = ((pkm * distancia) * 100) / 100;
                preco = frete + distancia; 
                Console.WriteLine("Valor total com urgência Caminhão: {0:C}", preco); 
            }
            else if(urgencia == "nao")
            {
                preco = pkm * distancia;
                Console.WriteLine("Valor total frete: {0:C}", preco);
            }
            else
            {
                Console.WriteLine("Escolha uma das opções!");
                return;
            }
        }
        else if(distancia > 5 && peso <= 1000)
        {
            Console.WriteLine("Urgencia Sim ou Não?");
            string urgencia = Console.ReadLine().ToLower();
            if(urgencia == "sim")
            {
                frete = ((pkm * distancia) * 70) / 100;
                preco = frete + distancia;
                Console.WriteLine("Valor total com urgência Van: {0:C}", preco);  
                frete = ((pkm * distancia) * 100) / 100;
                preco = frete + distancia; 
                Console.WriteLine("Valor total com urgência Caminhão: {0:C}", preco); 
            }
            else if(urgencia == "nao")
            {
                preco = pkm * distancia;
                Console.WriteLine("Valor total frete: {0:C}", preco);
            }
            else
            {
                Console.WriteLine("Escolha uma das opções!");
                return;
            }
        }
        else if(distancia > 5 && peso > 1000)
        {
            Console.WriteLine("Urgencia Sim ou Não?");
            string urgencia = Console.ReadLine().ToLower();
            if(urgencia == "sim")
            {
                frete = ((pkm * distancia) * 100) / 100;
                preco = frete + distancia;
                Console.WriteLine("Valor total com urgência: {0:C}", preco);   
            }
            else if(urgencia == "nao")
            {
                preco = pkm * distancia;
                Console.WriteLine("Valor total frete: {0:C}", preco);
            }
            else
            {
                Console.WriteLine("Escolha uma das opções!");
                return;
            }
        }
        else
        //Caso o Usuário escrever errado!
        {
            Console.WriteLine("Escreva um numero valido!");
            return;
        }
    }
}