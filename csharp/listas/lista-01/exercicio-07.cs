using System;
namespace ListaATP1
{
    public class listatv7
    {  
    public static void Main2(string[] args)
        {
            //declaracao da variavel
            double salarioUser, salarioResult = 0;
            const double salarioMin = 1516;

            //entrada do usuário:
            Console.WriteLine($"Escreva seu salário no formato x.xxx:");
            salarioUser = double.Parse(Console.ReadLine());

            if(salarioUser <= 0)
            {
                //bloquear o usuario de digitar um número negativo ou zero!
                Console.WriteLine($"Escreva um número maior que zero ou positivo!");
            }
            else 
            {
                //calculo:
                salarioResult = salarioUser / salarioMin;

                if(salarioUser == salarioMin)
                {
                    //resultado:
                    Console.WriteLine($"Exatamente um salário minimo!");
                }
                else if(salarioUser > salarioMin)
                {
                    //resultado:
                    Console.WriteLine($"Maior que o salário minimo!");
                }
                else
                {
                    //resultado:
                    Console.WriteLine($"Menor que o salário minimo!");;
                }
                //entrada do usuário:
                Console.WriteLine($"Entrada do usuario: {salarioUser:C}");
                //resultado:
                Console.WriteLine($"Total de salarios minimos: {salarioResult:N3}");
            }

            string x = Console.ReadLine();
        }
    }
}