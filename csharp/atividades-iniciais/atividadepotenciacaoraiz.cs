using System;
namespace CSharp
{
    public class atividadepotenciacaoraiz
    {
        public static void Main2(string[] args)
    {
        double num1, num2, pow1, pow2;

        Console.WriteLine("Escreva dois numeros!");
        Console.WriteLine("Numero 1:");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Numero 2:");
        num2 = double.Parse(Console.ReadLine());
        
        pow1 = Math.Pow(num1, 2);
        pow2 = Math.Pow(num2, 2);

        double somaPow = pow1 + pow2;
        
        double raiz = Math.Sqrt(somaPow);
        
        Console.WriteLine(raiz);
    }
    } 
}
