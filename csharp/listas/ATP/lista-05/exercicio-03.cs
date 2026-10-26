using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int digitos;
        do
        {
            Console.WriteLine($"Escreva quantos digitos terá o seu número: (o número deverá ser maior que 0!)");
            digitos = int.Parse(Console.ReadLine());
        }
        while(digitos < 1);
        
        int[] numero = new int[digitos];
        
        for(int i = 0; i < numero.Length; i++)
        {
            Console.Write($"Digite o dígito {i + 1}: ");
            numero[i] = int.Parse(Console.ReadLine());
        }
        
        bool palindromo = true;
        
        for(int i = numero.Length - 1, j = 0; i >= 0; i--, j++)
        {
            if(numero[i] != numero[j])
            {
                palindromo = false;
                break;
            }
        }
        
        if(palindromo)
        {
            Console.WriteLine($"Seu numero é palíndromo!");
            return;
        }
        else
        {
            Console.WriteLine($"Seu numero não é palíndromo!");
            return;
        }
    }
}           