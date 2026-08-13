using System;
public class atividadeswitchmes
{
    public static void Main3(string [] arg)
    {
        //Explicação!
        Console.WriteLine("Escreva um número do mês de 1 a 12!");

        //Entrada do Usuário
        int mes = int.Parse(Console.ReadLine());

        //Escolha do Usuário
        switch(mes)
        {
            case 1:
            Console.WriteLine("Mês: Janeiro!");
            break;

            case 2:
            Console.WriteLine("Mês: Fevereiro!");
            break;

            case 3:
            Console.WriteLine("Mês: Março!");
            break;

            case 4:
            Console.WriteLine("Mês: Abril!");
            break;

            case 5:
            Console.WriteLine("Mês: Maio!");
            break;

            case 6:
            Console.WriteLine("Mês: Junho!");
            break;

            case 7:
            Console.WriteLine("Mês: Julho!");
            break;

            case 8:
            Console.WriteLine("Mês: Agosto!");
            break;

            case 9:
            Console.WriteLine("Mês: Setembro!");
            break;

            case 10:
            Console.WriteLine("Mês: Outubro!");
            break;

            case 11:
            Console.WriteLine("Mês: Novembro!");
            break;

            case 12:
            Console.WriteLine("Mês: Dezembro!");
            break;

            default:
            Console.WriteLine("Mês invalido!");
            break;
        }
    }
}