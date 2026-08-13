using System;
public class atividadecalculadora
{
    public static void Main2(string [] arg)
    {
        //Entrada do Usuário:
        Console.WriteLine("Número 1:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Operação:");
        string operação = Console.ReadLine();
        Console.WriteLine("Número 2:");
        double num2 = double.Parse(Console.ReadLine());

        //Escolha + Calculo:
        switch(operação)
        {
            case "/":
            num1 /= num2;
            Console.WriteLine($"{num1}");
            break;

            case "*":
            num1 *= num2;
            Console.WriteLine($"{num1}");
            break;

            case "-":
            num1 -= num2;
            Console.WriteLine($"{num1}");
            break;

            case "+":
            num1 += num2;
            Console.WriteLine($"{num1}");
            break;

            case "%":
            num1 %= num2;
            Console.WriteLine($"{num1}");
            break;

            default:
            break;
        }
    }
}