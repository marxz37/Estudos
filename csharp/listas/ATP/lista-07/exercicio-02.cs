using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o cateto a: ");
            double a = double.Parse(Console.ReadLine());
            
            while (a <= 0)
            {
                Console.Write("Valor inválido! O lado de um triângulo deve ser maior que zero! Digite novamente o valor do cateto a: ");
                a = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite o cateto b: ");
            double b = double.Parse(Console.ReadLine());
            
            while (b <= 0)
            {
                Console.Write("Valor inválido! O lado de um triângulo deve ser maior que zero! Digite novamente o valor docateto b: ");
                b = double.Parse(Console.ReadLine());
            }

            double resultado = Hipotenusa(a, b);
            Console.WriteLine($"A hipotenusa é: {resultado:F2}");
        }
        public static double Hipotenusa(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
    }
}