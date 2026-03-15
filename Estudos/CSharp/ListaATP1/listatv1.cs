using System;
namespace ListaATP1
{
    class listatv1
    {
        static void Main2(string[] arg)
        {
            //declaracao das variaveis
            int a, b;
            double soma, produto, quociente, diferenca;
            
            //recebendo a entrada do usuario
            Console.WriteLine("Escreva o primeiro número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número:");
            b = int.Parse(Console.ReadLine());

            //calculo
            soma = a + b;
            produto = a * b;
            quociente = (double)a / b;
            diferenca = a - b;

            //Bloquear o usuario de digitar número negativo!
            if(a < 0 || b < 0)
            {
                Console.WriteLine("Coloque números positivos!");
            }
            else
            {
            //Entradas
            Console.WriteLine($"Entrada do usuário 1: {a}");
            Console.WriteLine($"Entrada do usuário 2: {b}");
            //resultado
            Console.WriteLine($"Resultado da Soma: {soma}");
            Console.WriteLine($"Resultado do Produto: {produto}");
            Console.WriteLine($"Resultado do Quociente {quociente:F5}");
            Console.WriteLine($"Resultado do Diferença: {diferenca}");
            } 

            string x = (Console.ReadLine());
        }
    }
}