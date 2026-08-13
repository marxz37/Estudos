using System;
class lista1
{
    static void Main2(string[] arg)
    {
        //Entrada do Usuário:
        Console.WriteLine("Escreva um número de 0 a 5:");
        int num1 = int.Parse(Console.ReadLine());

        //Condição:
        if(num1 <= 5 && num1 >= 0)
        {
            if(num1 == 0)
            {
                Console.WriteLine("Zero!");
            }
            else if(num1 == 1)
            {
                Console.WriteLine("Um!");
            }
            else if(num1 == 2)
            {
                Console.WriteLine("Dois!");
            }
            else if(num1 == 3)
            {
                Console.WriteLine("Três!");
            }
            else if(num1 == 4)
            {
                Console.WriteLine("Quarto!");
            }
            else
            {
                Console.WriteLine("Cinco!");
            }
        }
        //Evitar com que Usuário o digite valor errado.
        else
        {
            Console.WriteLine("Valor inválido!");
        }
    }
}