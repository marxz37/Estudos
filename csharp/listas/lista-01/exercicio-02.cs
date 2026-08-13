using System;
namespace ListaATP1
{
    class listatv2
    {
        static void Main2(string[] arg)
        {
            // Declaracao da variavel
            int horas, minutos, segundos, resultado;

            // Entrada do Usuário:
            Console.WriteLine("Qual o tempo transcorrido em um cronômetro em horas?");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o tempo transcorrido em um cronômetro em minutos?");
            minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o tempo transcorrido em um cronômetro em segundos?");
            segundos = int.Parse(Console.ReadLine());

            //entradas
            Console.WriteLine($"Entrada do Usuário: {horas}:{minutos}:{segundos}");
            Console.WriteLine($"Tempo transcorrido: {horas}:{minutos}:{segundos}");

            // Conversão
            horas = 60 * (horas * 60);
            minutos *= 60;

            // Resultado:
            resultado = segundos + horas + minutos;

            //Bloquear o usuario de digitar número negativo!
            if(horas < 0 || minutos < 0 || segundos < 0)
            {
                Console.WriteLine("Coloque números positivos!");
            }
            else
            {
                // Tempo digitado pelo usuário:
                Console.WriteLine($"Tempo transcorrido em segundos: {resultado}");
            }

            string x = (Console.ReadLine());
        }
    }
}