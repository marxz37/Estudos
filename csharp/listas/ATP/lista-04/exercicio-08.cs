using System;

public class listatv8
{
    public static void Main()
    {
        Console.Write("Digite um numero inteiro para calcular a raiz quadrada: ");
        int numero = int.Parse(Console.ReadLine()); 

        while (numero < 0)
        {
            Console.WriteLine("O numero não pode ser negativo!");
            Console.Write("Digite um numero inteiro e positivo: ");
            numero = int.Parse(Console.ReadLine());
        }

        int impar = 1;
        int contadorRaiz = 0;

        while (numero > 0)
        {
            numero = numero - impar;
            impar = impar + 2; 
            contadorRaiz = contadorRaiz + 1;
        }

        if (numero == 0)
        {
            Console.WriteLine("A raiz quadrada exata é: " + contadorRaiz);
        }
        else
        {
            Console.WriteLine("O numero não possui raiz exata.");
        }
    }
}